﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AESkryptering
{
    public class Encrypt
    {
        //static void Main(string[] args)
        //{
        //    // The plaintext string
        //    string plaintext = "Hello, Baha'is of the World!";

        //    // The password used to encrypt the string
        //    string password = "my-secret-ian-password";

        //    // Encrypt the string
        //    string encrypted = EncryptString(plaintext, password);

        //    // Decrypt the encrypted string
        //    string decrypted = DecryptString(encrypted, password);

        //    // Print the original and decrypted strings
        //    Console.WriteLine("Original:  " + plaintext);
        //    Console.WriteLine("Decrypted: " + decrypted);
        //}

        


        public static string EncryptString(string plaintext, string password)
        {
            // Convert the plaintext string to a byte array
            byte[] plaintextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);

            byte[] salt = new byte[8];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(salt);
            }

            // Derive a new password using the PBKDF2 algorithm and a random salt
            Rfc2898DeriveBytes passwordBytes = new Rfc2898DeriveBytes(password, salt, 1000, HashAlgorithmName.SHA256);

            // Use the password to encrypt the plaintext
            Aes encryptor = Aes.Create();
            encryptor.Key = passwordBytes.GetBytes(32);
            encryptor.IV = passwordBytes.GetBytes(16);
           
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(salt, 0, salt.Length); 

                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(plaintextBytes, 0, plaintextBytes.Length);
                    cs.FlushFinalBlock();
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static string DecryptString(string encrypted, string password)
        {
            try
            {
                // Convert the encrypted string to a byte array
                byte[] encryptedBytes = Convert.FromBase64String(encrypted);

                byte[] salt = new byte[8];
                Array.Copy(encryptedBytes, 0, salt, 0, salt.Length);

                // Derive the password using the PBKDF2 algorithm
                Rfc2898DeriveBytes passwordBytes = new Rfc2898DeriveBytes(password, salt, 1000, HashAlgorithmName.SHA256);

                // Use the password to decrypt the encrypted string
                Aes encryptor = Aes.Create();
                encryptor.Key = passwordBytes.GetBytes(32);
                encryptor.IV = passwordBytes.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedBytes, salt.Length, encryptedBytes.Length - salt.Length);
                        cs.FlushFinalBlock();
                    }
                    return $"Decrypted message: {System.Text.Encoding.UTF8.GetString(ms.ToArray())}";
                }
            }
            catch
            {
                return "Wrong password!";
            }
        }
    }
}
