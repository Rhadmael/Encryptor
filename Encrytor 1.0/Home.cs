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
        private string product;
        private string productVersion;
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

                ListViewItem file = new ListViewItem(splitName[0]);
                file.SubItems.Add(filePath[a]);
                file.SubItems.Add(splitName[last-1]);
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
            /*if using DES
            key = cryptoFunctions.RandomString();
            if (System.Windows.Forms.MessageBox.Show(key, "Copy key to Clipboard", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                Clipboard.SetText(key);
                keyTextBox.PasswordChar = '*';
                keyTextBoxVerify.PasswordChar = '*';

                keyTextBox.Text = key;
                keyTextBoxVerify.Text = key;
            }
             * */
            key = cryptoFunctions.GenerateKey();
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

                for (int i = 1; i < fileList.Items.Count; i++)
                {
                    MessageBox.Show(fileList.Items[i].SubItems[1].Text);
                    string fileToEncrypt = fileList.Items[i].SubItems[1].Text;
                    cryptoFunctions.EncryptFile(@fileToEncrypt, @fileToEncrypt+".lkj", key);
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

    }
}
