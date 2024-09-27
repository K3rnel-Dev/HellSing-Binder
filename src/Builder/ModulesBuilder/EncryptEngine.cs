﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Builder.ModulesBuilder
{
    internal class EncryptEngine
    {
        public static void EncryptFileAndSave(string filePath, string xorKey, string outputFilePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] encryptedBytes = new byte[fileBytes.Length];

            for (int i = 0; i < fileBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(fileBytes[i] ^ xorKey[i % xorKey.Length]);
            }

            File.WriteAllBytes(outputFilePath, encryptedBytes);
        }

        public static string StringEncryptor(string inputString, string xorKey)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString); 
            byte[] keyBytes = Encoding.UTF8.GetBytes(xorKey);
            byte[] outputBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }
            return Convert.ToBase64String(outputBytes);
        }

        public static string GenerateRandomStr(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}