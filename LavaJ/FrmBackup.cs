using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LavaJ
{

    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string sql = "";
        string strConn = "";

        private void FrmBackup_Load(object sender, EventArgs e)
        {

            textBoxServerName.Text = System.Net.Dns.GetHostName().ToUpper() + @"\SQLEXPRESS";
            ComboBoxDatabase.SelectedIndex = 0;
        }


        public void Createconnection()
        {
            try
            {
                strConn = "Data Source = " + textBoxServerName.Text.Trim() + "; Trusted_Connection = true;";
                conn = new SqlConnection(strConn);
                conn.Open();
                sql = "SELECT * FROM sys.databases";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ComboBoxDatabase.Items.Add(reader[0].ToString());
                }
                textBoxServerName.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelarbnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntConectar_Click(object sender, EventArgs e)
        {
            if (bntConectar.Text == "Conectar")
            {
                Createconnection();
                bntConectar.Text = "Desconectar";
                ComboBoxDatabase.Enabled = true;
                groupBackup.Enabled = true;
                groupRestore.Enabled = true;
            }
            else
            {
                bntConectar.Text = "Conectar";
                ComboBoxDatabase.Enabled = false;
                groupBackup.Enabled = false;
                groupRestore.Enabled = false;
                ComboBoxDatabase.Items.Clear();
                ComboBoxDatabase.Items.Add("Selecione...");
                ComboBoxDatabase.SelectedIndex = 0;
                ComboBoxDatabase.Enabled = false;
                textBoxBackup.Clear();
                textBoxRestore.Clear();
            }
        }

        private void ComboBoxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDatabase.SelectedIndex != 0)
            {
                groupBackup.Enabled = true;
                groupRestore.Enabled = true;
            }
            else
            {
                groupBackup.Enabled = false;
                groupRestore.Enabled = false;
                textBoxBackup.Clear();
                textBoxRestore.Clear();
            }
        }

        private void textBoxBackup_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBackup.Text.Trim() != string.Empty)
            {
                bntBackup.Enabled = true;
            }
            else
            {
                bntBackup.Enabled = false;
            }
        }

        private void textBoxRestore_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRestore.Text.Trim() != string.Empty)
            {
                bntRestore.Enabled = true;
            }
            else
            {
                bntRestore.Enabled = false;
            }
        }

        private void bntSelecionarBk_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxBackup.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void bntBackup_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                sql = "BACKUP DATABASE " + ComboBoxDatabase.Text + " TO DISK ='" + textBoxBackup.Text.Trim() + "\\" + ComboBoxDatabase.Text + "-" + DateTime.Now.ToString("dddd, dd MM yyyy HH-mm-ss") + ".bak'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Backup Database realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntSelecionarRest_Click(object sender, EventArgs e)
        {
            if (textBoxRestore.Text != @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup") openFileDialog1.InitialDirectory = textBoxRestore.Text;

            openFileDialog1.Filter = "SQL backup (*.bak)|*.bak|Todos Arquivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxRestore.Text = openFileDialog1.FileName;
            }

        }

        private void bntRestore_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                sql = "ALTER DATABASE " + ComboBoxDatabase.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += " RESTORE DATABASE " + ComboBoxDatabase.Text + " FROM DISK = '" + textBoxRestore.Text.Trim() + "' WITH REPLACE;";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Database Restore realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
