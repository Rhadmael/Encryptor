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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.pkiCreate = new MetroFramework.Controls.MetroPanel();
            this.keyGen = new MetroFramework.Controls.MetroButton();
            this.keyVerify = new MetroFramework.Controls.MetroLabel();
            this.keyTextBoxVerify = new MetroFramework.Controls.MetroTextBox();
            this.Encrypt = new MetroFramework.Controls.MetroButton();
            this.keyToEncrypt = new MetroFramework.Controls.MetroLabel();
            this.fileList = new MetroFramework.Controls.MetroListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.encryptLink = new MetroFramework.Controls.MetroLink();
            this.decryptLink = new MetroFramework.Controls.MetroLink();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.useOld = new MetroFramework.Controls.MetroButton();
            this.pkiCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkiCreate
            // 
            this.pkiCreate.Controls.Add(this.useOld);
            this.pkiCreate.Controls.Add(this.metroButton3);
            this.pkiCreate.Controls.Add(this.metroComboBox1);
            this.pkiCreate.Controls.Add(this.keyGen);
            this.pkiCreate.Controls.Add(this.keyVerify);
            this.pkiCreate.Controls.Add(this.keyTextBoxVerify);
            this.pkiCreate.Controls.Add(this.Encrypt);
            this.pkiCreate.Controls.Add(this.keyToEncrypt);
            this.pkiCreate.Controls.Add(this.fileList);
            this.pkiCreate.Controls.Add(this.keyTextBox);
            this.pkiCreate.Controls.Add(this.metroButton2);
            this.pkiCreate.Controls.Add(this.metroButton1);
            this.pkiCreate.HorizontalScrollbarBarColor = true;
            this.pkiCreate.HorizontalScrollbarHighlightOnWheel = false;
            this.pkiCreate.HorizontalScrollbarSize = 10;
            this.pkiCreate.Location = new System.Drawing.Point(23, 63);
            this.pkiCreate.Name = "pkiCreate";
            this.pkiCreate.Size = new System.Drawing.Size(730, 439);
            this.pkiCreate.TabIndex = 0;
            this.pkiCreate.VerticalScrollbarBarColor = true;
            this.pkiCreate.VerticalScrollbarHighlightOnWheel = false;
            this.pkiCreate.VerticalScrollbarSize = 10;
            this.pkiCreate.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // keyGen
            // 
            this.keyGen.Location = new System.Drawing.Point(100, 392);
            this.keyGen.Name = "keyGen";
            this.keyGen.Size = new System.Drawing.Size(96, 23);
            this.keyGen.TabIndex = 15;
            this.keyGen.Text = "Generate Key";
            this.keyGen.UseSelectable = true;
            this.keyGen.Click += new System.EventHandler(this.keyGen_Click);
            // 
            // keyVerify
            // 
            this.keyVerify.AutoSize = true;
            this.keyVerify.Location = new System.Drawing.Point(18, 349);
            this.keyVerify.Name = "keyVerify";
            this.keyVerify.Size = new System.Drawing.Size(65, 19);
            this.keyVerify.TabIndex = 14;
            this.keyVerify.Text = "Verify Key";
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
            this.keyTextBoxVerify.Location = new System.Drawing.Point(100, 349);
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
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(517, 349);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(187, 23);
            this.Encrypt.TabIndex = 12;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseSelectable = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // keyToEncrypt
            // 
            this.keyToEncrypt.AutoSize = true;
            this.keyToEncrypt.Location = new System.Drawing.Point(18, 307);
            this.keyToEncrypt.Name = "keyToEncrypt";
            this.keyToEncrypt.Size = new System.Drawing.Size(33, 19);
            this.keyToEncrypt.TabIndex = 11;
            this.keyToEncrypt.Text = "Key ";
            // 
            // fileList
            // 
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
            this.filePath.Width = 241;
            // 
            // fileType
            // 
            this.fileType.Text = "File Type";
            this.fileType.Width = 95;
            // 
            // fileSize
            // 
            this.fileSize.Text = "File Size";
            this.fileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fileSize.Width = 74;
            // 
            // fileStatus
            // 
            this.fileStatus.Text = "File Status";
            this.fileStatus.Width = 112;
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
            this.keyTextBox.Location = new System.Drawing.Point(100, 307);
            this.keyTextBox.MaxLength = 32767;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '\0';
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
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(629, 307);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Select File";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(517, 307);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Select Folder";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // encryptLink
            // 
            this.encryptLink.Location = new System.Drawing.Point(277, 27);
            this.encryptLink.Name = "encryptLink";
            this.encryptLink.Size = new System.Drawing.Size(115, 23);
            this.encryptLink.TabIndex = 1;
            this.encryptLink.Text = "Encrypt Files";
            this.encryptLink.UseSelectable = true;
            this.encryptLink.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // decryptLink
            // 
            this.decryptLink.Location = new System.Drawing.Point(398, 27);
            this.decryptLink.Name = "decryptLink";
            this.decryptLink.Size = new System.Drawing.Size(115, 23);
            this.decryptLink.TabIndex = 2;
            this.decryptLink.Text = "Decrypt Files";
            this.decryptLink.UseSelectable = true;
            this.decryptLink.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "DES",
            "RSA PKI"});
            this.metroComboBox1.Location = new System.Drawing.Point(100, 257);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 16;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(238, 392);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(96, 23);
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "New PKI";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // useOld
            // 
            this.useOld.Location = new System.Drawing.Point(359, 392);
            this.useOld.Name = "useOld";
            this.useOld.Size = new System.Drawing.Size(96, 23);
            this.useOld.TabIndex = 18;
            this.useOld.Text = "Use Esisting PKI";
            this.useOld.UseSelectable = true;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Controls.Add(this.decryptLink);
            this.Controls.Add(this.encryptLink);
            this.Controls.Add(this.pkiCreate);
            this.Name = "Title";
            this.Text = "File Encryptor V 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pkiCreate.ResumeLayout(false);
            this.pkiCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pkiCreate;
        private MetroFramework.Controls.MetroLink encryptLink;
        private MetroFramework.Controls.MetroLink decryptLink;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
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
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton useOld;
    }
}

