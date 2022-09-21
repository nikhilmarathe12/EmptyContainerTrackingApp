using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ContainerTrackingApp.AES256
{
    public class AES256Encryption
    {
  
        public AES256Encryption()
        { 
            
        }
        #region "Commented"
        //public string Encryption(string Password)
        //{

        //    string encrypted = EncryptTextToMemory(Password).ToString();
        //    return encrypted;
        //}

        //public string EncryptTextToMemory(string plainText)
        //{
        //    string Company = "premierinfo";
        //    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(Company, 12);
        //    byte[] key = Encoding.ASCII.GetBytes(hashedPassword);
        //    //// Create secret IV
        //    byte[] iv = new byte[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        //    try
        //    {
        //        // Instantiate a new Aes object to perform string symmetric encryption
        //        Aes encryptor = Aes.Create();

        //        encryptor.Mode = CipherMode.CBC;
        //        //encryptor.KeySize = 256;
        //        //encryptor.BlockSize = 128;
        //        //encryptor.Padding = PaddingMode.Zeros;

        //        // Set key and IV
        //        encryptor.Key = key.Take(32).ToArray();
        //        encryptor.IV = iv;

        //        // Instantiate a new MemoryStream object to contain the encrypted bytes
        //        MemoryStream memoryStream = new MemoryStream();

        //        // Instantiate a new encryptor from our Aes object
        //        ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

        //        // Instantiate a new CryptoStream object to process the data and write it to the 
        //        // memory stream
        //        CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

        //        // Convert the plainText string into a byte array
        //        byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

        //        // Encrypt the input plaintext string
        //        cryptoStream.Write(plainBytes, 0, plainBytes.Length);

        //        // Complete the encryption process
        //        cryptoStream.FlushFinalBlock();

        //        // Convert the encrypted data from a MemoryStream to a byte array
        //        byte[] cipherBytes = memoryStream.ToArray();

        //        // Close both the MemoryStream and the CryptoStream
        //        memoryStream.Close();
        //        cryptoStream.Close();

        //        // Convert the encrypted byte array to a base64 encoded string
        //        string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

        //        // Return the encrypted data as a string
        //        return cipherText;
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public string DecryptString(string cipherText)
        //{
        //    string Company = "premierinfo";
        //    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(Company, 12);
        //    byte[] key = Encoding.ASCII.GetBytes(hashedPassword);
        //    //// Create secret IV
        //    byte[] iv = new byte[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        //    // Instantiate a new Aes object to perform string symmetric encryption
        //    Aes encryptor = Aes.Create();

        //    encryptor.Mode = CipherMode.CBC;
        //    //encryptor.KeySize = 256;
        //    //encryptor.BlockSize = 128;
        //    //encryptor.Padding = PaddingMode.Zeros;

        //    // Set key and IV
        //    encryptor.Key = key.Take(32).ToArray();
        //    encryptor.IV = iv;

        //    // Instantiate a new MemoryStream object to contain the encrypted bytes
        //    MemoryStream memoryStream = new MemoryStream();

        //    // Instantiate a new encryptor from our Aes object
        //    ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

        //    // Instantiate a new CryptoStream object to process the data and write it to the 
        //    // memory stream
        //    CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

        //    // Will contain decrypted plaintext
        //    string plainText = String.Empty;

        //    try
        //    {
        //        // Convert the ciphertext string into a byte array
        //        byte[] cipherBytes = Convert.FromBase64String(cipherText);

        //        // Decrypt the input ciphertext string
        //        cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

        //        // Convert the decrypted data from a MemoryStream to a byte array
        //        byte[] plainBytes = memoryStream.ToArray();

        //        // Convert the decrypted byte array to string
        //        plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);

        //        // Complete the decryption process
        //        cryptoStream.FlushFinalBlock();
        //    }
        //    finally
        //    {
        //        // Close both the MemoryStream and the CryptoStream
        //        memoryStream.Close();
        //        //cryptoStream.Close();
        //    }

        //    // Return the decrypted data as a string
        //    return plainText;
        //}
        #endregion

        public string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}