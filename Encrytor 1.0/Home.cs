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
            //if using DES
            key = cryptoFunctions.RandomString();
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
                cryptoFunctions.EncryptFile(@"E:\puka.txt", @"E:\Encrypted.txt", key);
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

        }

    }
}
