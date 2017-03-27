using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Xml.XPath;
using Microsoft.Win32;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;



namespace Encrytor_1._0
{
    public partial class Title : MetroFramework.Forms.MetroForm 
    {
        string key ;
        public Title()
        {
            this.freeEvent = new EventWaitHandle(true, EventResetMode.ManualReset);
            InitializeComponent();
        }
        private string publicKey;
        private string privateKey;
        private string publicKeyID;
        private string manifestFilePath;

        public string PublicKey
        {
            get
            {
                return this.publicKey;
            }
            set
            {
                if (value != this.publicKey)
                {
                    this.publicKey = value;
                    MessageBox.Show("PublicKey");
                }
            }

        }
        public string PrivateKey
        {
            get
            {
                return this.privateKey;
            }
            set
            {
                if (value != this.privateKey)
                {
                    this.publicKey = value;
                    MessageBox.Show("PrivateKey");
                }
            }

        }
        public string PublicKeyID
        {
            get
            {
                return this.publicKeyID;
            }
            set
            {
                if (value != this.publicKeyID)
                {
                    this.publicKeyID = value;
                    MessageBox.Show("PublicKeyID");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog chooseFiles = new System.Windows.Forms.FolderBrowserDialog();
           
            if (chooseFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileList.Items.Clear();

                string[] files = Directory.GetFiles(chooseFiles.SelectedPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string extension = Path.GetExtension(file);
                    string path = Path.GetFullPath(file);

                    ListViewItem item = new ListViewItem(fileName);
                    item.SubItems.Add(path);
                    item.SubItems.Add(extension);
                    long size = new System.IO.FileInfo(file).Length;
                    item.SubItems.Add(size.ToString());
                    item.SubItems.Add("ready");
                    item.Tag = file;

                    fileList.Items.Add(item);

                }
            }
            else {
                MessageBox.Show("Alert","non selected");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            fileList.Items.Clear();
            //fileList.Clear();
            OpenFileDialog ChooseFile = new OpenFileDialog();
            ChooseFile.Multiselect = true;
            ChooseFile.Title = "Select File To Encrypt";
            ChooseFile.ShowDialog();
            string[] filePath = ChooseFile.FileNames;
            string[] fileName = ChooseFile.SafeFileNames;
            

            for (int a = 0; a < fileName.Length; a++) {
                string name = fileName[a];
                string[] splitName = name.Split('.');
                int last = splitName.Length;

                string fName = @name;
                string path = @filePath[a];
                string extension;

                extension = Path.GetExtension(fName);

                ListViewItem file = new ListViewItem(splitName[0]);

                file.SubItems.Add(filePath[a]);
                //file.SubItems.Add(splitName[last-1]);
                file.SubItems.Add(extension);
                long size = new System.IO.FileInfo(filePath[a]).Length;
                file.SubItems.Add(size.ToString());
                file.SubItems.Add("ready");

                fileList.Items.Add(file);
                //fileList.BackColor = Color.Green;
                
            }
            
        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void keyGen_Click(object sender, EventArgs e)
        {

            string Genkey = cryptoFunctions.generateKey();
            if (System.Windows.Forms.MessageBox.Show(Genkey, "Copy key to Clipboard", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Clipboard.SetText(Genkey);
                keyTextBox.PasswordChar = '*';
                keyTextBoxVerify.PasswordChar = '*';

                keyTextBox.Text = Genkey;
                keyTextBoxVerify.Text = Genkey;
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            //check if keys are the same

            if (keyTextBox.Text == keyTextBoxVerify.Text && keyTextBox.Text != "" && keyTextBoxVerify.Text != "")
            {
                MessageBox.Show("okay");
                //String a = fileList.Items[1].SubItems[1].Text;
                string key = keyTextBox.Text;

                for (int i = 0; i < fileList.Items.Count; i++)
                {
                    string fileToEncrypt = fileList.Items[i].SubItems[1].Text;
                    cryptoFunctions.EncryptFile(@fileToEncrypt, @fileToEncrypt + ".aesEncrypt",key);
                    fileList.Items[i].SubItems[4].Text = "Encrypted";
                    fileList.Items[i].BackColor = Color.LightCyan;
                }
                
                
            }
            else{
                MessageBox.Show("Keys are not the same. Please Verify", " Error");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            //fbd.Description = Encrytor_1._0.Properties.Resources.DialogTitle_CreateKey;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string publicKeyPath = System.IO.Path.Combine(fbd.SelectedPath, "publicKey.xml");
                string privateKeyPath = System.IO.Path.Combine(fbd.SelectedPath, "privateKey.xml");

                string publicKey;
                string privateKey;
                pki.GenerateRSAKeyPair(out publicKey, out privateKey);
                using (StreamWriter sw = File.CreateText(publicKeyPath))
                {
                    sw.Write(publicKey);
                }

                using (StreamWriter sw = File.CreateText(privateKeyPath))
                {
                    sw.Write(privateKey);
                }
            }
        }

        private void useOld_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".xml";
            ofd.Title = "Select Public Key";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    this.PublicKey = sr.ReadToEnd();
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            fileList.Items.Clear();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //check if keys are the same
            if (keyTextBox.Text == keyTextBoxVerify.Text && keyTextBox.Text != "" && keyTextBoxVerify.Text != ""){
                MessageBox.Show("keys are simmilar");
                
                //check if files are encrypted ones
                for (int i = 0; i < fileList.Items.Count; i++)
                {
                    string fileType = fileList.Items[i].SubItems[2].Text;

                    //MessageBox.Show(fileType);
                    if (fileType != ".aesEncrypt")
                    {
                        MessageBox.Show("invalid files selected. please check and verify file type");
                    }
                    else
                    {
                        //String a = fileList.Items[1].SubItems[1].Text;
                        key = keyTextBox.Text;
                        for (int fn = 0; fn < fileList.Items.Count; fn++)
                        {
                            string fileToDecrypt = fileList.Items[fn].SubItems[1].Text;
                            cryptoFunctions.DecryptFile(@fileToDecrypt, @fileToDecrypt.Replace("aesEncrypt", ""), key);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Keys are not the same. Please Verify", " Error");
            }
        }

        private void keyTextBox_Click(object sender, EventArgs e)
        {

        }


        private void EncryptFile(string inputFile, string outputFile, string pass)
        {
            try
            {
                MessageBox.Show(pass);
                string password = @pass; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }

        private EventWaitHandle freeEvent;

        private void metroButton6_Click(object sender, EventArgs e)
        {
            try {

                if (!this.freeEvent.WaitOne(0))
                {
                    MessageBox.Show(Properties.Resources.Backend_Busy);
                    return;
                }

                if (string.IsNullOrEmpty(publicKey))
                {
                    MessageBox.Show(this, Properties.Resources.Error_Need_PublicKey);
                    return;
                }

                for (int i = 0; i < fileList.Items.Count; i++)
                {
                    string fileToEncrypt = fileList.Items[i].SubItems[1].Text;
                    string encryptedFilePath = cryptoFunctions.MakePath(@fileToEncrypt, ".encrypted");
                    string manifestFilePath = cryptoFunctions.MakePath(@fileToEncrypt, ".manifest.xml");
                    fileList.Items[i].SubItems[4].Text = "Encrypted";

                    var t = Task.Factory.StartNew(() =>
                    {
                        freeEvent.Reset();
                        string s = pki.Encrypt(fileToEncrypt, encryptedFilePath, manifestFilePath, this.publicKey);

                        freeEvent.Set();
                    });
                }   
            
            }
            catch{
                MessageBox.Show("Encryption failed!", "Error");
            }   
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.freeEvent.WaitOne(0))
                {
                    MessageBox.Show(Properties.Resources.Backend_Busy);
                    return;
                }

                string rsaKey = this.privateKey;

                for (int i = 0; i < fileList.Items.Count; i++)
                {
                    string fileToDecrypt = fileList.Items[i].SubItems[1].Text;
                    string decryptedFilePath = cryptoFunctions.MakePath(fileToDecrypt, ".decrypted");
                    string dirName = Path.GetDirectoryName(fileToDecrypt);
                    string fileN = Path.GetFileNameWithoutExtension(fileToDecrypt);
                    string manifestFile = dirName + "\\" + fileN + ".manifest.xml";
                    MessageBox.Show(manifestFile);
                    XDocument doc = XDocument.Load(manifestFile);
                    XElement aesKeyElement = doc.Root.XPathSelectElement("./DataEncryption/AESEncryptedKeyValue/Key");
                    byte[] aesKey = pki.RSADescryptBytes(Convert.FromBase64String(aesKeyElement.Value), rsaKey);
                    XElement aesIvElement = doc.Root.XPathSelectElement("./DataEncryption/AESEncryptedKeyValue/IV");
                    byte[] aesIv = pki.RSADescryptBytes(Convert.FromBase64String(aesIvElement.Value), rsaKey);


                    var t = Task.Factory.StartNew(() =>
                    {
                        freeEvent.Reset();
                        pki.DecryptFile(decryptedFilePath, fileToDecrypt, aesKey, aesIv);
                        freeEvent.Set();
                        
                    });

                    fileList.Items[i].SubItems[4].Text = "Decrypted";
                } 
            }
            catch {
                MessageBox.Show("Error in decryption, try again");
            }     
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ChoosePrivate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".xml";
            ofd.Title = "Select Private Key";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    this.privateKey = sr.ReadToEnd();
                    MessageBox.Show(this.privateKey);
                }
            }

        }
    }
}
