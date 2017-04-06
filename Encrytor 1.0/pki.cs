using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Encrytor_1._0
{
    public class pki
    {
        /// <summary>
        /// Generate RSA key pair
        /// </summary>
        /// <param name="publicKey">Receive public key</param>
        /// <param name="privateKey">Receive private key</param>
        public static void GenerateRSAKeyPair(out string publicKey, out string privateKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            publicKey = rsa.ToXmlString(false);
            privateKey = rsa.ToXmlString(true);
        }

        /// <summary>
        /// Encrypt a file
        /// </summary>
        /// <param name="plainFilePath">Full path of the file to be encrypted</param>
        /// <param name="encryptedFilePath">Full path of the encrypted file</param>
        /// <param name="manifestFilePath">Full path of the generated manifest file</param>
        /// <param name="product">Product name</param>
        /// <param name="productVersion">Product version</param>
        /// <param name="rsaKey">RSA key used to encrypt the one-time symmetrical key</param>
        /// <param name="rsaKeyId">RSA key id for backend index</param>
        /// <returns>Encryption information including symmetrical keys for data encryption and signature, just for debug purpose</returns>
        public static string Encrypt(string plainFilePath,
            string encryptedFilePath,
            string manifestFilePath,
            string rsaKey)
        {
            byte[] signatureKey = GenerateRandom(64);
            byte[] encryptionKey = GenerateRandom(16);
            byte[] encryptionIV = GenerateRandom(16);

            EncryptFile(plainFilePath, encryptedFilePath, encryptionKey, encryptionIV);

            byte[] signature = CalculateSignature(encryptedFilePath, signatureKey);

            CreateManifest(signature, signatureKey, encryptionKey, encryptionIV, rsaKey, manifestFilePath);

            return CreateEncryptionInfoXml(signatureKey, encryptionKey, encryptionIV);
        }

        /// <summary>
        /// Create encryption information in the form of xml string
        /// </summary>
        /// <param name="signatureKey">Signature Key</param>
        /// <param name="encryptionKey">AES Encryption key</param>
        /// <param name="encryptionIV">AES Encryption key IV</param>
        /// <returns>xml string containing key informations</returns>
        private static string CreateEncryptionInfoXml(byte[] signatureKey, byte[] encryptionKey, byte[] encryptionIV)
        {
            string template = "<EncryptionInfo>" +
                "<AESKeyValue>" +
                "<Key/>" +
                "<IV/>" +
                "</AESKeyValue>" +
                "<HMACSHAKeyValue/>" +
                "</EncryptionInfo>";

            XDocument doc = XDocument.Parse(template);
            doc.Descendants("AESKeyValue").Single().Descendants("Key").Single().Value = Convert.ToBase64String(encryptionKey);
            doc.Descendants("AESKeyValue").Single().Descendants("IV").Single().Value = Convert.ToBase64String(encryptionIV);
            doc.Descendants("HMACSHAKeyValue").Single().Value = Convert.ToBase64String(signatureKey);
            return doc.ToString();
        }

        /// <summary>
        /// Generate random byte array
        /// </summary>
        /// <param name="length">array length</param>
        /// <returns>Random byte array</returns>
        private static byte[] GenerateRandom(int length)
        {
            byte[] bytes = new byte[length];
            using (RNGCryptoServiceProvider random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(bytes);
            }

            return bytes;
        }

        /// <summary>
        /// Encrypt a file with AES
        /// </summary>
        /// <param name="plainFilePath">Full path of the file to be encrypted</param>
        /// <param name="encryptedFilePath">Full path of the encrypted file</param>
        /// <param name="key">AES key</param>
        /// <param name="iv">AES IV</param>
        private static void EncryptFile(string plainFilePath,
            string encryptedFilePath,
            byte[] key,
            byte[] iv)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (FileStream plain = File.Open(plainFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (FileStream encrypted = File.Open(encryptedFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (CryptoStream cs = new CryptoStream(encrypted, encryptor, CryptoStreamMode.Write))
                        {
                            plain.CopyTo(cs);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Encrypt a file with AES
        /// </summary>
        /// <param name="plainFilePath">Full path of the encrypted file</param>
        /// <param name="encryptedFilePath">Full path of the file to be decrypted</param>
        /// <param name="key">AES key</param>
        /// <param name="iv">AES IV</param>
        public static void DecryptFile(string plainFilePath, string encryptedFilePath, byte[] key, byte[] iv)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 128;
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (FileStream plain = File.Open(plainFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (FileStream encrypted = File.Open(encryptedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (CryptoStream cs = new CryptoStream(plain, decryptor, CryptoStreamMode.Write))
                        {
                            encrypted.CopyTo(cs);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Encrypt byte array with RSA
        /// </summary>
        /// <param name="datas">byte array to be encrypted</param>
        /// <param name="keyXml">RSA key</param>
        /// <returns>Encrypted array</returns>
        public static byte[] RSAEncryptBytes(byte[] datas, string keyXml)
        {
            byte[] encrypted = null;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(keyXml);
                encrypted = rsa.Encrypt(datas, true);
            }

            return encrypted;
        }

        /// <summary>
        /// Decrypt byte array with RSA
        /// </summary>
        /// <param name="datas">byte array to be decrypted</param>
        /// <param name="keyXml">RSA key</param>
        /// <returns>Decrypted array</returns>
        public static byte[] RSADescryptBytes(byte[] datas, string keyXml)
        {
            byte[] decrypted = null;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(keyXml);
                decrypted = rsa.Decrypt(datas, true);
            }

            return decrypted;
        }

        /// <summary>
        /// Calculate file signature
        /// </summary>
        /// <param name="filePath">Full path of the file for calculating signature</param>
        /// <param name="key">key for calculating signature</param>
        /// <returns>Signature array</returns>
        private static byte[] CalculateSignature(string filePath, byte[] key)
        {
            byte[] sig = null;
            using (HMACSHA256 sha = new HMACSHA256(key))
            {
                using (FileStream f = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    sig = sha.ComputeHash(f);
                }
            }

            return sig;
        }

        /// <summary>
        /// Create manifest file of a encrypted package, used for backend parsing
        /// </summary>
        /// <param name="signature">Data signature</param>
        /// <param name="signatureKey">Data signature key</param>
        /// <param name="encryptionKey">AES encryption key</param>
        /// <param name="encryptionIv">AES encryption IV</param>
        /// <param name="product">Product name</param>
        /// <param name="productVersion">Product version</param>
        /// <param name="rsaKey">RSA key</param>
        /// <param name="rsaKeyID">RSA key ID</param>
        /// <param name="manifestFilePath">Output manifest file path</param>
        private static void CreateManifest(byte[] signature,
            byte[] signatureKey,
            byte[] encryptionKey,
            byte[] encryptionIv,
            string rsaKey,
            string manifestFilePath)
        {
            string template = "<DataInfo>" +
                "<Encrypted>True</Encrypted>" +
                "<KeyEncryption algorithm='RSA2048'>" +
                "</KeyEncryption>" +
                "<DataEncryption algorithm='AES128'>" +
                "<AESEncryptedKeyValue>" +
                "<Key/>" +
                "<IV/>" +
                "</AESEncryptedKeyValue>" +
                "</DataEncryption>" +
                "<DataSignature algorithm='HMACSHA256'>" +
                "<Value />" +
                "<EncryptedKey />" +
                "</DataSignature>" +
                "</DataInfo>";

            XDocument doc = XDocument.Parse(template);
            doc.Descendants("DataEncryption").Single().Descendants("AESEncryptedKeyValue").Single().Descendants("Key").Single().Value = System.Convert.ToBase64String(RSAEncryptBytes(encryptionKey, rsaKey));
            doc.Descendants("DataEncryption").Single().Descendants("AESEncryptedKeyValue").Single().Descendants("IV").Single().Value = System.Convert.ToBase64String(RSAEncryptBytes(encryptionIv, rsaKey));
            doc.Descendants("DataSignature").Single().Descendants("Value").Single().Value = System.Convert.ToBase64String(signature);
            doc.Descendants("DataSignature").Single().Descendants("EncryptedKey").Single().Value = System.Convert.ToBase64String(RSAEncryptBytes(signatureKey, rsaKey));

            doc.Save(manifestFilePath);
        }
    }
}
