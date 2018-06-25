using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptConnString
{
    public partial class frmEncryptConnString : Form
    {
        private string STR_CNN_FILE = "";

        public frmEncryptConnString()
        {
            InitializeComponent();
        }

        private static char KeysENTER
        {
            get
            {
                return (char)13;
            }
        }

        private void txtProgramTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtServer.Focus();
            }
        }

        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtDBName.Focus();
            }
        }

        private void txtDBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtUserID.Focus();
            }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtUserPwd.Focus();
            }
        }

        private void txtUserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtTimeout.Focus();
            }
        }

        private void txtTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtKdCabang.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateEncryptFile();
        }

        private void CreateEncryptFile()
        {
            StringBuilder strEncrypt = new StringBuilder();
            string strMyConnString = txtProgramTitle.Text;
            char myCodeEncrypt;
            int[] SecretCode = new int[] {20, 8, 18, 6, 16, 4};
            System.IO.FileStream file = new System.IO.FileStream(Application.StartupPath + @"\CnnString.cnn", System.IO.FileMode.Create);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(file);

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeEncrypt = (char)((int)((char)strMyConnString[i]) + SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strEncrypt.Append(myCodeEncrypt);
            }
            writer.WriteLine(strEncrypt.ToString());

            #region Connection to Database
            strEncrypt = new StringBuilder();

            if (chkAzure.Checked)
            {
                strMyConnString = @"Server=" + txtServer.Text + ";Initial Catalog=" + txtDBName.Text +
                    ";Persist Security Info=False;Connect Timeout=" + txtTimeout.Text + ";User ID=" +
                    txtUserID.Text + ";Password=" + txtUserPwd.Text + ";MultipleActiveResultSets=False;Encrypt=True;" +
                    "TrustServerCertificate=False;";
            }
            else
            {
                strMyConnString = @"Data Source=" + txtServer.Text + ";Database=" + txtDBName.Text +
                    ";Integrated Security=False;Connect Timeout=" + txtTimeout.Text + "; User Instance=False;User ID=" +
                    txtUserID.Text + ";Password=" + txtUserPwd.Text;
            }

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeEncrypt = (char)((int)((char)strMyConnString[i]) + SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strEncrypt.Append(myCodeEncrypt);
            }

            writer.WriteLine(strEncrypt.ToString());

            #endregion

            #region Code Branch
            strEncrypt = new StringBuilder();

            strMyConnString = txtKdCabang.Text;
            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeEncrypt = (char)((int)((char)strMyConnString[i]) + SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strEncrypt.Append(myCodeEncrypt);
            }

            writer.WriteLine(strEncrypt.ToString());

            #endregion

            #region WarehouseID 
            strEncrypt = new StringBuilder();

            strMyConnString = txtWarehouseID.Text;
            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeEncrypt = (char)((int)((char)strMyConnString[i]) + SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strEncrypt.Append(myCodeEncrypt);
            }

            writer.WriteLine(strEncrypt.ToString());

            #endregion

            #region Printer Name
            strEncrypt = new StringBuilder();

            strMyConnString = txtPrinterName.Text;
            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeEncrypt = (char)((int)((char)strMyConnString[i]) + SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strEncrypt.Append(myCodeEncrypt);
            }

            writer.WriteLine(strEncrypt.ToString());

            #endregion

            #region SQL Server Service Name
            strEncrypt = new StringBuilder();

            strMyConnString = txtSQLServ.Text;
            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeEncrypt = (char)((int)((char)strMyConnString[i]) + SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strEncrypt.Append(myCodeEncrypt);
            }

            writer.Write(strEncrypt.ToString());

            #endregion

            writer.Close();
            file.Close();

            MessageBox.Show("File Connection String has been successfully Created!!!", "My Programs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtKdCabang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtWarehouseID.Focus();
            }
        }

        private void txtPrinterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                btnSave.Focus();
            }
        }

        private void txtWarehouseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == KeysENTER)
            {
                e.Handled = true;
                txtPrinterName.Focus();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEncryptionFile();
        }

        public bool DecryptConnString(out string Title, out string ConnectionString, out string KdCabang, out string warehousePenjualan, out string PrinterName, out string sqlServiceName)
        {
            ConnectionString = Title = KdCabang = warehousePenjualan = PrinterName = sqlServiceName = "";
            System.Text.StringBuilder strDecrypt = new System.Text.StringBuilder();
            string strMyConnString;
            char myCodeDecrypt;
            int[] SecretCode = new int[] { 20, 8, 18, 6, 16, 4 };
            System.IO.FileStream file;
            
            if(STR_CNN_FILE == string.Empty)
                STR_CNN_FILE = System.Windows.Forms.Application.StartupPath + @"\" + "CnnString.cnn";

            try
            {
                file = new System.IO.FileStream(STR_CNN_FILE, System.IO.FileMode.Open);
            }
            catch
            {
                return false;
            }

            System.IO.StreamReader reader = new System.IO.StreamReader(file);
            strMyConnString = reader.ReadLine();

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeDecrypt = (char)((int)((char)strMyConnString[i]) - SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strDecrypt.Append(myCodeDecrypt);
            }
            Title = strDecrypt.ToString();

            #region Connection String
            strDecrypt = new System.Text.StringBuilder();
            strMyConnString = reader.ReadLine();

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeDecrypt = (char)((int)((char)strMyConnString[i]) - SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strDecrypt.Append(myCodeDecrypt);
            }
            ConnectionString = strDecrypt.ToString();
            #endregion

            #region Kode Cabang
            strDecrypt = new System.Text.StringBuilder();
            strMyConnString = reader.ReadLine();

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeDecrypt = (char)((int)((char)strMyConnString[i]) - SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strDecrypt.Append(myCodeDecrypt);
            }
            KdCabang = strDecrypt.ToString();
            #endregion

            #region Warehouse Penjualan Default
            strDecrypt = new System.Text.StringBuilder();
            strMyConnString = reader.ReadLine();

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeDecrypt = (char)((int)((char)strMyConnString[i]) - SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strDecrypt.Append(myCodeDecrypt);
            }
            warehousePenjualan = strDecrypt.ToString();
            #endregion

            #region Printer Name
            strDecrypt = new System.Text.StringBuilder();
            strMyConnString = reader.ReadLine();

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeDecrypt = (char)((int)((char)strMyConnString[i]) - SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strDecrypt.Append(myCodeDecrypt);
            }
            PrinterName = strDecrypt.ToString();
            #endregion

            #region SQL Server Service Name
            strDecrypt = new System.Text.StringBuilder();
            strMyConnString = reader.ReadLine();
            reader.Close();
            reader.Dispose();
            reader = null;
            file.Close();
            file.Dispose();
            file = null;

            if (strMyConnString == null)
            {
                strMyConnString = @"a[eW\(gY^KhTfMeY";
            }

            for (int i = 0, pjgConnString = strMyConnString.Length, idxCode = 0, pjgIdxCode = 6; i < pjgConnString; i++)
            {
                myCodeDecrypt = (char)((int)((char)strMyConnString[i]) - SecretCode[idxCode++]);
                if (idxCode >= pjgIdxCode)
                    idxCode = 0;
                strDecrypt.Append(myCodeDecrypt);
            }
            sqlServiceName = strDecrypt.ToString();
            #endregion

            strDecrypt = null;
            SecretCode = null;
            return true;
        }

        private void LoadEncryptionFile()
        {
            string title, connString, kdCabang, warehouseIDDef, printerName, sqlServiceName;

            if (!DecryptConnString(out title, out connString, out kdCabang, out warehouseIDDef, out printerName, out sqlServiceName))
            {
                MessageBox.Show("File Connection String Cannot be found!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            try
            {
                string[] mySplit = connString.Split(';');
                string tmp;
                int lengthTmp;

                tmp = mySplit[0];
                lengthTmp = tmp.IndexOf('=') + 1;
                txtServer.Text = tmp.Substring(lengthTmp, tmp.Length - lengthTmp);

                tmp = mySplit[1];
                lengthTmp = tmp.IndexOf('=') + 1;
                txtDBName.Text = tmp.Substring(lengthTmp, tmp.Length - lengthTmp);

                tmp = mySplit[5];
                lengthTmp = tmp.IndexOf('=') + 1;
                txtUserID.Text = tmp.Substring(lengthTmp, tmp.Length - lengthTmp);

                tmp = mySplit[6];
                lengthTmp = tmp.IndexOf('=') + 1;
                txtUserPwd.Text = tmp.Substring(lengthTmp, tmp.Length - lengthTmp);

                tmp = mySplit[3];
                lengthTmp = tmp.IndexOf('=') + 1;
                txtTimeout.Text = tmp.Substring(lengthTmp, tmp.Length - lengthTmp);
            }
            catch
            {
            }

            txtProgramTitle.Text = title;
            txtKdCabang.Text = kdCabang;
            txtWarehouseID.Text = warehouseIDDef;
            txtPrinterName.Text = printerName;
            txtSQLServ.Text = sqlServiceName;
        }

        private void frmEncryptConnString_DragDrop(object sender, DragEventArgs e)
        {
            //e.Data.GetData(typeof(System.IO.File))
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] strDropFile = (string[])e.Data.GetData(DataFormats.FileDrop);

                STR_CNN_FILE = strDropFile[0];

                LoadEncryptionFile();
            }
        }

        private void frmEncryptConnString_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void chkAzure_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkAzure.Checked)
            {
                txtServer.Text = @".\SQLExpress";
            }
            else
            {
                txtServer.Text = @"tcp:enixmomo.database.windows.net,1433";
            }
        }
    }
}
