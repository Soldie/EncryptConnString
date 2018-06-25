namespace EncryptConnString
{
    partial class frmEncryptConnString
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProgramTitle = new System.Windows.Forms.TextBox();
            this.lblProgramTitle = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.lblUserPwd = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.txtKdCabang = new System.Windows.Forms.TextBox();
            this.lblKdCabang = new System.Windows.Forms.Label();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.lblPrinterName = new System.Windows.Forms.Label();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.lblWarehouseID = new System.Windows.Forms.Label();
            this.lblSQLServ = new System.Windows.Forms.Label();
            this.txtSQLServ = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chkAzure = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Create File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProgramTitle
            // 
            this.txtProgramTitle.AllowDrop = true;
            this.txtProgramTitle.Location = new System.Drawing.Point(126, 8);
            this.txtProgramTitle.Name = "txtProgramTitle";
            this.txtProgramTitle.Size = new System.Drawing.Size(100, 20);
            this.txtProgramTitle.TabIndex = 1;
            this.txtProgramTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProgramTitle_KeyPress);
            // 
            // lblProgramTitle
            // 
            this.lblProgramTitle.AutoSize = true;
            this.lblProgramTitle.Location = new System.Drawing.Point(12, 11);
            this.lblProgramTitle.Name = "lblProgramTitle";
            this.lblProgramTitle.Size = new System.Drawing.Size(69, 13);
            this.lblProgramTitle.TabIndex = 0;
            this.lblProgramTitle.Text = "Program Title";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(126, 59);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(100, 20);
            this.txtDBName.TabIndex = 5;
            this.txtDBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDBName_KeyPress);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(12, 62);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(84, 13);
            this.lblDatabase.TabIndex = 4;
            this.lblDatabase.Text = "Database Name";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(126, 85);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '*';
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 7;
            this.txtUserID.Text = "sa";
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(12, 88);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "User ID";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(126, 111);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(100, 20);
            this.txtUserPwd.TabIndex = 9;
            this.txtUserPwd.Text = "@saprogram";
            this.txtUserPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPwd_KeyPress);
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.Location = new System.Drawing.Point(12, 114);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(53, 13);
            this.lblUserPwd.TabIndex = 8;
            this.lblUserPwd.Text = "Password";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(126, 34);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(157, 20);
            this.txtServer.TabIndex = 3;
            this.txtServer.Text = ".\\SQLExpress";
            this.txtServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 37);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(126, 137);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(100, 20);
            this.txtTimeout.TabIndex = 11;
            this.txtTimeout.Text = "30";
            this.txtTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeout_KeyPress);
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(12, 140);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(50, 13);
            this.lblTimeOut.TabIndex = 10;
            this.lblTimeOut.Text = "Time Out";
            // 
            // txtKdCabang
            // 
            this.txtKdCabang.Location = new System.Drawing.Point(126, 163);
            this.txtKdCabang.MaxLength = 5;
            this.txtKdCabang.Name = "txtKdCabang";
            this.txtKdCabang.Size = new System.Drawing.Size(100, 20);
            this.txtKdCabang.TabIndex = 13;
            this.txtKdCabang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKdCabang_KeyPress);
            // 
            // lblKdCabang
            // 
            this.lblKdCabang.AutoSize = true;
            this.lblKdCabang.Location = new System.Drawing.Point(12, 166);
            this.lblKdCabang.Name = "lblKdCabang";
            this.lblKdCabang.Size = new System.Drawing.Size(44, 13);
            this.lblKdCabang.TabIndex = 12;
            this.lblKdCabang.Text = "Cabang";
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(126, 217);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(100, 20);
            this.txtPrinterName.TabIndex = 17;
            this.txtPrinterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrinterName_KeyPress);
            // 
            // lblPrinterName
            // 
            this.lblPrinterName.AutoSize = true;
            this.lblPrinterName.Location = new System.Drawing.Point(12, 220);
            this.lblPrinterName.Name = "lblPrinterName";
            this.lblPrinterName.Size = new System.Drawing.Size(68, 13);
            this.lblPrinterName.TabIndex = 16;
            this.lblPrinterName.Text = "Printer Name";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.Location = new System.Drawing.Point(126, 189);
            this.txtWarehouseID.MaxLength = 3;
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(100, 20);
            this.txtWarehouseID.TabIndex = 15;
            this.txtWarehouseID.Text = "PJL";
            this.txtWarehouseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWarehouseID_KeyPress);
            // 
            // lblWarehouseID
            // 
            this.lblWarehouseID.AutoSize = true;
            this.lblWarehouseID.Location = new System.Drawing.Point(12, 192);
            this.lblWarehouseID.Name = "lblWarehouseID";
            this.lblWarehouseID.Size = new System.Drawing.Size(73, 13);
            this.lblWarehouseID.TabIndex = 14;
            this.lblWarehouseID.Text = "WarehouseID";
            // 
            // lblSQLServ
            // 
            this.lblSQLServ.AutoSize = true;
            this.lblSQLServ.Location = new System.Drawing.Point(12, 246);
            this.lblSQLServ.Name = "lblSQLServ";
            this.lblSQLServ.Size = new System.Drawing.Size(108, 13);
            this.lblSQLServ.TabIndex = 19;
            this.lblSQLServ.Text = "SQL SERVICE Name";
            // 
            // txtSQLServ
            // 
            this.txtSQLServ.Location = new System.Drawing.Point(126, 243);
            this.txtSQLServ.Name = "txtSQLServ";
            this.txtSQLServ.Size = new System.Drawing.Size(157, 20);
            this.txtSQLServ.TabIndex = 20;
            this.txtSQLServ.Text = "MSSQL$SQLEXPRESS";
            // 
            // btnLoad
            // 
            this.btnLoad.AllowDrop = true;
            this.btnLoad.Location = new System.Drawing.Point(96, 275);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkAzure
            // 
            this.chkAzure.AutoSize = true;
            this.chkAzure.Location = new System.Drawing.Point(232, 10);
            this.chkAzure.Name = "chkAzure";
            this.chkAzure.Size = new System.Drawing.Size(77, 17);
            this.chkAzure.TabIndex = 21;
            this.chkAzure.Text = "SQL Azure";
            this.chkAzure.UseVisualStyleBackColor = true;
            this.chkAzure.CheckedChanged += new System.EventHandler(this.chkAzure_CheckedChanged);
            // 
            // frmEncryptConnString
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 310);
            this.Controls.Add(this.chkAzure);
            this.Controls.Add(this.lblSQLServ);
            this.Controls.Add(this.txtSQLServ);
            this.Controls.Add(this.lblPrinterName);
            this.Controls.Add(this.lblWarehouseID);
            this.Controls.Add(this.lblKdCabang);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblUserPwd);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblProgramTitle);
            this.Controls.Add(this.txtPrinterName);
            this.Controls.Add(this.txtWarehouseID);
            this.Controls.Add(this.txtKdCabang);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtProgramTitle);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmEncryptConnString";
            this.Text = "Create Connection String";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmEncryptConnString_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmEncryptConnString_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProgramTitle;
        private System.Windows.Forms.Label lblProgramTitle;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.Label lblUserPwd;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.TextBox txtKdCabang;
        private System.Windows.Forms.Label lblKdCabang;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label lblPrinterName;
        private System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.Label lblWarehouseID;
        private System.Windows.Forms.Label lblSQLServ;
        private System.Windows.Forms.TextBox txtSQLServ;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chkAzure;
    }
}

