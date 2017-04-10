using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;


namespace Encrytor_1._0
{
    public partial class Title : MetroFramework.Forms.MetroForm 
    {
        string key ;
        public Title()
        {
            InitializeComponent();
        }
        private string publicKey;
        private string publicKeyID;

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

             
                String folderPath = chooseFiles.SelectedPath;
                //String[] files = 

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

            key = cryptoFunctions.generateKey();
            if (System.Windows.Forms.MessageBox.Show(key, "Copy key to Clipboard", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                Clipboard.SetText(key);
                keyTextBox.PasswordChar = '*';
                keyTextBoxVerify.PasswordChar = '*';

                keyTextBox.Text = key;
                keyTextBoxVerify.Text = key;
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
                    MessageBox.Show(fileList.Items[i].SubItems[1].Text);
                    string fileToEncrypt = fileList.Items[i].SubItems[1].Text;
                    
                    cryptoFunctions.EncryptFile(@fileToEncrypt, @fileToEncrypt + ".fek",key);
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
            ofd.Filter = Encrytor_1._0.Properties.Resources.XML_File_Type;
            ofd.Title = Encrytor_1._0.Properties.Resources.DialogTitle_SelectPublicKey;
            ofd.ShowDialog();

            //
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            fileList.Items.Clear();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //check if files are encrypted ones
            for (int i = 0; i < fileList.Items.Count; i++)
            {
                //MessageBox.Show(fileList.Items[i].SubItems[1].Text);
                string fileType = fileList.Items[i].SubItems[2].Text;
                //MessageBox.Show(fileType);
                if (fileType != ".fek")
                {
                    MessageBox.Show("invalid files selected. please check and verify file type");
                }
                else
                {
                    //check if keys are the same

                    if (keyTextBox.Text == keyTextBoxVerify.Text && keyTextBox.Text != "" && keyTextBoxVerify.Text != "")
                    {
                        MessageBox.Show("keys are simmilar");
                        //String a = fileList.Items[1].SubItems[1].Text;
                        key = keyTextBox.Text;
                        for (int fn = 0; fn < fileList.Items.Count; fn++)
                        {
                            MessageBox.Show(fileList.Items[fn].SubItems[1].Text);
                            string fileToDecrypt = fileList.Items[fn].SubItems[1].Text;
                            //cryptoFunctions.DecryptFile(@fileToDecrypt, @fileToDecrypt.Replace(".fek", ""), key);
                            //cryptoFunctions.DecryptFiles(@fileToDecrypt, @fileToDecrypt.Replace(".fek", ""), key);
                            cryptoFunctions.DecryptFile(@fileToDecrypt, @fileToDecrypt.Replace(".fek", ""), key);
                           // MessageBox.Show("Keys arssdcdsc");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Keys are not the same. Please Verify", " Error");
                    }
                }
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
    }
}
