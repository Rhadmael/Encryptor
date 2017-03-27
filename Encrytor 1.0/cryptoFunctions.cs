using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Encrytor_1._0
{
    class cryptoFunctions
    {
        //AES Encryption Methods
        public static string generateKey(){
            int size = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder res = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()){
                //crete a unsigned byte array
                byte[] ubuffer = new byte[sizeof(uint)];

                while (size -- > 0){
                    rng.GetBytes(ubuffer);
                    uint num = BitConverter.ToUInt32(ubuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }

            }
            return res.ToString();
        }

        public static void EncryptFile(string fileToEncrypt, string encryptedFile, string @password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = encryptedFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);
                
                RijndaelManaged AES = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    AES.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(fileToEncrypt, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
                MessageBox.Show(fileToEncrypt + "Encryption Successfull");
                
            }

            catch{
                MessageBox.Show("Encryption failed!, please try again", "Error");
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string @password)
        {

            try{
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
                MessageBox.Show(inputFile + " decryption successfull", "Success");

            }
            catch{
                MessageBox.Show("Decryption failed!, please try again", "Error");
            }
        }
        public static string MakePath(string plainFilePath, string newSuffix)
        {
            string encryptedFileName = System.IO.Path.GetFileNameWithoutExtension(plainFilePath) + newSuffix;
            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(plainFilePath), encryptedFileName);
        }
        
    }
}
