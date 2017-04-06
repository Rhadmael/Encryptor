using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Encrytor_1._0
{
    class cryptoFunctions
    {

        public static string RandomString()
        {
            int length = 32;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
        public static void EncryptFile(string inputFileName, string outputFileName, string key) {

            
            //craete two Filestream objects to read and write 
            FileStream filein = new FileStream(inputFileName, FileMode.Open, FileAccess.Read);
            FileStream fileout = new FileStream(outputFileName, FileMode.Create, FileAccess.Write);

            // Declare an inatance of AES

            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();

            AES.Key = ASCIIEncoding.ASCII.GetBytes(key);
            AES.IV = ASCIIEncoding.ASCII.GetBytes(key);

            //crete encrypted file
            ICryptoTransform encryptedFile = AES.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(fileout, encryptedFile, CryptoStreamMode.Write);


            byte[] bytearrayinput = new byte[filein.Length - 1];
            filein.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptoStream.Write(bytearrayinput, 0, bytearrayinput.Length);


        }
        static void DecryptFile(string sInputFilename,
                string sOutputFilename,
                string sKey)
        {
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            AES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set initialization vector.
            AES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            //Create a file stream to read the encrypted file back.
            FileStream fsread = new FileStream(sInputFilename,
                                       FileMode.Open,
                                       FileAccess.Read);
            //Create a DES decryptor from the DES instance.
            ICryptoTransform desdecrypt = AES.CreateDecryptor();
            //Create crypto stream set to read and do a 
            //DES decryption transform on incoming bytes.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread,
                                                     desdecrypt,
                                                     CryptoStreamMode.Read);
            //Print the contents of the decrypted file.
            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }

    }
}
