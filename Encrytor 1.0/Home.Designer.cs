namespace Encrytor_1._0
{
    partial class Title
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))), System.Drawing.SystemColors.InactiveCaption, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title));
            this.pkiCreate = new MetroFramework.Controls.MetroPanel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.fileList = new MetroFramework.Controls.MetroListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectFile = new MetroFramework.Controls.MetroButton();
            this.selectFolder = new MetroFramework.Controls.MetroButton();
            this.DESEncryption = new System.Windows.Forms.GroupBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.keyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.keyToEncrypt = new MetroFramework.Controls.MetroLabel();
            this.keyTextBoxVerify = new MetroFramework.Controls.MetroTextBox();
            this.keyVerify = new MetroFramework.Controls.MetroLabel();
            this.Encrypt = new MetroFramework.Controls.MetroButton();
            this.keyGen = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AESDecrypt = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.choosePublic = new MetroFramework.Controls.MetroButton();
            this.ChoosePrivate = new MetroFramework.Controls.MetroButton();
            this.pkiCreate.SuspendLayout();
            this.DESEncryption.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkiCreate
            // 
            this.pkiCreate.Controls.Add(this.metroButton5);
            this.pkiCreate.Controls.Add(this.fileList);
            this.pkiCreate.Controls.Add(this.selectFile);
            this.pkiCreate.Controls.Add(this.selectFolder);
            this.pkiCreate.Controls.Add(this.DESEncryption);
            this.pkiCreate.Controls.Add(this.groupBox2);
            this.pkiCreate.HorizontalScrollbarBarColor = true;
            this.pkiCreate.HorizontalScrollbarHighlightOnWheel = false;
            this.pkiCreate.HorizontalScrollbarSize = 10;
            this.pkiCreate.Location = new System.Drawing.Point(23, 63);
            this.pkiCreate.Name = "pkiCreate";
            this.pkiCreate.Size = new System.Drawing.Size(730, 473);
            this.pkiCreate.TabIndex = 0;
            this.pkiCreate.VerticalScrollbarBarColor = true;
            this.pkiCreate.VerticalScrollbarHighlightOnWheel = false;
            this.pkiCreate.VerticalScrollbarSize = 10;
            this.pkiCreate.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(180, 247);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 21;
            this.metroButton5.Text = "Clear";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // fileList
            // 
            this.fileList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.filePath,
            this.fileType,
            this.fileSize,
            this.fileStatus});
            this.fileList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileList.FullRowSelect = true;
            this.fileList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.fileList.Location = new System.Drawing.Point(18, 16);
            this.fileList.Name = "fileList";
            this.fileList.OwnerDraw = true;
            this.fileList.Size = new System.Drawing.Size(697, 222);
            this.fileList.TabIndex = 10;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.UseSelectable = true;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged_1);
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 171;
            // 
            // filePath
            // 
            this.filePath.Text = "Path";
            this.filePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filePath.Width = 241;
            // 
            // fileType
            // 
            this.fileType.Text = "File Type";
            this.fileType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileType.Width = 95;
            // 
            // fileSize
            // 
            this.fileSize.Text = "File Size";
            this.fileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileSize.Width = 74;
            // 
            // fileStatus
            // 
            this.fileStatus.Text = "File Status";
            this.fileStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileStatus.Width = 112;
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(99, 247);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 5;
            this.selectFile.Text = "Select File";
            this.selectFile.UseSelectable = true;
            this.selectFile.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(18, 247);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(75, 23);
            this.selectFolder.TabIndex = 4;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseSelectable = true;
            this.selectFolder.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DESEncryption
            // 
            this.DESEncryption.Controls.Add(this.metroButton4);
            this.DESEncryption.Controls.Add(this.keyTextBox);
            this.DESEncryption.Controls.Add(this.keyToEncrypt);
            this.DESEncryption.Controls.Add(this.keyTextBoxVerify);
            this.DESEncryption.Controls.Add(this.keyVerify);
            this.DESEncryption.Controls.Add(this.Encrypt);
            this.DESEncryption.Controls.Add(this.keyGen);
            this.DESEncryption.Location = new System.Drawing.Point(18, 276);
            this.DESEncryption.Name = "DESEncryption";
            this.DESEncryption.Size = new System.Drawing.Size(331, 184);
            this.DESEncryption.TabIndex = 19;
            this.DESEncryption.TabStop = false;
            this.DESEncryption.Text = "AES Encryption";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(220, 116);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(96, 23);
            this.metroButton4.TabIndex = 16;
            this.metroButton4.Text = "Decrypt";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // keyTextBox
            // 
            // 
            // 
            // 
            this.keyTextBox.CustomButton.Image = null;
            this.keyTextBox.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.keyTextBox.CustomButton.Name = "";
            this.keyTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyTextBox.CustomButton.TabIndex = 1;
            this.keyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyTextBox.CustomButton.UseSelectable = true;
            this.keyTextBox.CustomButton.Visible = false;
            this.keyTextBox.Lines = new string[0];
            this.keyTextBox.Location = new System.Drawing.Point(114, 31);
            this.keyTextBox.MaxLength = 32767;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '*';
            this.keyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyTextBox.SelectedText = "";
            this.keyTextBox.SelectionLength = 0;
            this.keyTextBox.SelectionStart = 0;
            this.keyTextBox.ShortcutsEnabled = true;
            this.keyTextBox.Size = new System.Drawing.Size(202, 23);
            this.keyTextBox.TabIndex = 8;
            this.keyTextBox.UseSelectable = true;
            this.keyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.keyTextBox.Click += new System.EventHandler(this.keyTextBox_Click);
            // 
            // keyToEncrypt
            // 
            this.keyToEncrypt.AutoSize = true;
            this.keyToEncrypt.Location = new System.Drawing.Point(32, 31);
            this.keyToEncrypt.Name = "keyToEncrypt";
            this.keyToEncrypt.Size = new System.Drawing.Size(33, 19);
            this.keyToEncrypt.TabIndex = 11;
            this.keyToEncrypt.Text = "Key ";
            // 
            // keyTextBoxVerify
            // 
            // 
            // 
            // 
            this.keyTextBoxVerify.CustomButton.Image = null;
            this.keyTextBoxVerify.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.keyTextBoxVerify.CustomButton.Name = "";
            this.keyTextBoxVerify.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keyTextBoxVerify.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyTextBoxVerify.CustomButton.TabIndex = 1;
            this.keyTextBoxVerify.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyTextBoxVerify.CustomButton.UseSelectable = true;
            this.keyTextBoxVerify.CustomButton.Visible = false;
            this.keyTextBoxVerify.Lines = new string[0];
            this.keyTextBoxVerify.Location = new System.Drawing.Point(114, 73);
            this.keyTextBoxVerify.MaxLength = 32767;
            this.keyTextBoxVerify.Name = "keyTextBoxVerify";
            this.keyTextBoxVerify.PasswordChar = '\0';
            this.keyTextBoxVerify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyTextBoxVerify.SelectedText = "";
            this.keyTextBoxVerify.SelectionLength = 0;
            this.keyTextBoxVerify.SelectionStart = 0;
            this.keyTextBoxVerify.ShortcutsEnabled = true;
            this.keyTextBoxVerify.Size = new System.Drawing.Size(202, 23);
            this.keyTextBoxVerify.TabIndex = 13;
            this.keyTextBoxVerify.UseSelectable = true;
            this.keyTextBoxVerify.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyTextBoxVerify.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keyVerify
            // 
            this.keyVerify.AutoSize = true;
            this.keyVerify.Location = new System.Drawing.Point(32, 73);
            this.keyVerify.Name = "keyVerify";
            this.keyVerify.Size = new System.Drawing.Size(66, 19);
            this.keyVerify.TabIndex = 14;
            this.keyVerify.Text = "Verify Key";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(114, 116);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(96, 23);
            this.Encrypt.TabIndex = 12;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseSelectable = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // keyGen
            // 
            this.keyGen.Location = new System.Drawing.Point(114, 155);
            this.keyGen.Name = "keyGen";
            this.keyGen.Size = new System.Drawing.Size(202, 23);
            this.keyGen.TabIndex = 15;
            this.keyGen.Text = "Generate Key";
            this.keyGen.UseSelectable = true;
            this.keyGen.Click += new System.EventHandler(this.keyGen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChoosePrivate);
            this.groupBox2.Controls.Add(this.AESDecrypt);
            this.groupBox2.Controls.Add(this.metroButton6);
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.choosePublic);
            this.groupBox2.Location = new System.Drawing.Point(375, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 184);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PKI Encryption";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AESDecrypt
            // 
            this.AESDecrypt.Location = new System.Drawing.Point(209, 116);
            this.AESDecrypt.Name = "AESDecrypt";
            this.AESDecrypt.Size = new System.Drawing.Size(96, 23);
            this.AESDecrypt.TabIndex = 19;
            this.AESDecrypt.Text = "Decrypt";
            this.AESDecrypt.UseSelectable = true;
            this.AESDecrypt.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(103, 116);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(96, 23);
            this.metroButton6.TabIndex = 17;
            this.metroButton6.Text = "Encrypt";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(103, 35);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(202, 23);
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "New PKI";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Key ";
            // 
            // choosePublic
            // 
            this.choosePublic.Location = new System.Drawing.Point(103, 73);
            this.choosePublic.Name = "choosePublic";
            this.choosePublic.Size = new System.Drawing.Size(96, 23);
            this.choosePublic.TabIndex = 18;
            this.choosePublic.Text = "Public Key";
            this.choosePublic.UseSelectable = true;
            this.choosePublic.Click += new System.EventHandler(this.useOld_Click);
            // 
            // ChoosePrivate
            // 
            this.ChoosePrivate.Location = new System.Drawing.Point(209, 73);
            this.ChoosePrivate.Name = "ChoosePrivate";
            this.ChoosePrivate.Size = new System.Drawing.Size(96, 23);
            this.ChoosePrivate.TabIndex = 20;
            this.ChoosePrivate.Text = "Private Key";
            this.ChoosePrivate.UseSelectable = true;
            this.ChoosePrivate.Click += new System.EventHandler(this.ChoosePrivate_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 546);
            this.Controls.Add(this.pkiCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Title";
            this.Text = "File Encryptor V 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pkiCreate.ResumeLayout(false);
            this.DESEncryption.ResumeLayout(false);
            this.DESEncryption.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pkiCreate;
        private MetroFramework.Controls.MetroButton selectFolder;
        private MetroFramework.Controls.MetroButton selectFile;
        private MetroFramework.Controls.MetroTextBox keyTextBox;
        private MetroFramework.Controls.MetroListView fileList;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader filePath;
        private System.Windows.Forms.ColumnHeader fileType;
        private System.Windows.Forms.ColumnHeader fileStatus;
        private System.Windows.Forms.ColumnHeader fileSize;
        private MetroFramework.Controls.MetroLabel keyToEncrypt;
        private MetroFramework.Controls.MetroButton keyGen;
        private MetroFramework.Controls.MetroLabel keyVerify;
        private MetroFramework.Controls.MetroTextBox keyTextBoxVerify;
        private MetroFramework.Controls.MetroButton Encrypt;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton choosePublic;
        private System.Windows.Forms.GroupBox DESEncryption;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton AESDecrypt;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton ChoosePrivate;
    }
}

