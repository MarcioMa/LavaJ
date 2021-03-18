using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LavaJ
{
    public partial class FrmLogin : Form
    {
        FrmMain frmMain { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt;
        SqlDataAdapter da;
        string sqlQuery = "";

        public FrmLogin(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Trim() != string.Empty)
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            sqlQuery = "SELECT * FROM TbAdmin WHERE admin = '" + textBoxLogin.Text.Trim() + "' AND senhaAd = '" + textBoxSenha.Text.Trim() + "';";

            da = new SqlDataAdapter(sqlQuery, conn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.frmMain.toolStripStatusLabel5.Text = textBoxLogin.Text;
                this.frmMain.Adminlogin = true;
                this.frmMain.Enabled = true;
                conn.Close();
                this.Close();
                this.Dispose();

            }
            else
            {
                sqlQuery = "SELECT * FROM TbAdmin WHERE operador = '" + textBoxLogin.Text.Trim() + "' AND senhaOp = '" + textBoxSenha.Text.Trim() + "';";


                da = new SqlDataAdapter(sqlQuery, conn);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.frmMain.toolStripStatusLabel5.Text = textBoxLogin.Text;
                    this.frmMain.Enabled = true;
                    this.frmMain.Adminlogin = false;
                    conn.Close();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLogin.Text = "";
                    textBoxSenha.Text = "";
                    textBoxLogin.Focus();
                }
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma fechamento do sistema?", "Fechar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}