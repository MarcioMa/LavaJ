using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LavaJ
{
    public partial class FrmAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        public FrmAdmin()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM dbo.TbAdmin", conn);
            da.Fill(dt);
            txtIDAdmin.Text = dt.Rows.Count.ToString();
            conn.Close();
            Refresh();
        }

        private void LimparRegistro()
        {
            txtIDAdmin.Text = "";
            txtAdmin.Text = "";
            txtSenhaAdmin.Text = "";
            txtUser.Text = "";
            txtSenhaUser.Text = "";
            chkViewAdmin.Checked = false;
            chkViewUser.Checked = false;
        }

        private void BntSalva_Click(object sender, EventArgs e)
        {
            if (txtIDAdmin.Text == "")
            {
                try
                {
                    string sqlQuery = "INSERT INTO dbo.TbAdmin (admin, senhaAd, operador, senhaOp)VALUES(@admin, @senhaAd, @operador, @senhaOp)";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@admin", txtIDAdmin.Text);
                    cmd.Parameters.AddWithValue("@senhaAd", txtSenhaAdmin.Text);
                    cmd.Parameters.AddWithValue("@operador", txtUser.Text);
                    cmd.Parameters.AddWithValue("@senhaOp", txtSenhaUser.Text);

                    cmd.CommandText = sqlQuery;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro administrativo realizado com sucesso!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    DisplayData();
                    bntNovo.Text = "Novo";
                    BntSalva.Enabled = false;
                    BntReiniciar.Enabled = true;
                    BntFechar.Enabled = true;
                    groupBox1.Enabled = false;
                }
            }
            else
            {
                AtualizarDados();
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {

            if (bntNovo.Text == "Novo" && MessageBox.Show("Confirma alterações Administrativa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtAdmin.Focus();
                bntNovo.Text = "Cancelar";
                BntSalva.Enabled = true;
                BntReiniciar.Enabled = false;
                BntFechar.Enabled = false;
                groupBox1.Enabled = true;

            }
            else
            {
                bntNovo.Text = "Novo";
                BntSalva.Enabled = false;
                BntReiniciar.Enabled = true;
                BntFechar.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void BntReiniciar_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtIDAdmin.Text);

            try
            {
                if (MessageBox.Show("Confirma resete todas senhas Administrativa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && txtIDAdmin.Text != "")
                {
                    string sqlQuery = "UPDATE dbo.TbAdmin SET admin = @admin, senhaAd = @senhaAd, operador = @operador, senhaOp = @senhaOp  WHERE Id=@id";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);

                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@admin", "Administrador");
                    cmd.Parameters.AddWithValue("@senhaAd", "admin");
                    cmd.Parameters.AddWithValue("@operador", "User");
                    cmd.Parameters.AddWithValue("@senhaOp", "123");


                    cmd.CommandText = sqlQuery;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registro reiniciado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                DisplayData();
                bntNovo.Text = "Novo";
                BntSalva.Enabled = false;
                BntReiniciar.Enabled = true;
                BntFechar.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void AtualizarDados()
        {
            ID = Convert.ToInt32(txtIDAdmin.Text);

            try
            {
                if (MessageBox.Show("Confirma Atualização do registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string sqlQuery = "UPDATE dbo.TbAdmin SET admin = @admin, senhaAd = @senhaAd, operador = @operador, senhaOp = @senhaOp  WHERE Id=@id";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);

                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@admin", txtAdmin.Text);
                    cmd.Parameters.AddWithValue("@senhaAd", txtSenhaAdmin.Text);
                    cmd.Parameters.AddWithValue("@operador", txtUser.Text);
                    cmd.Parameters.AddWithValue("@senhaOp", txtSenhaUser.Text);


                    cmd.CommandText = sqlQuery;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                DisplayData();
                bntNovo.Text = "Novo";
                BntSalva.Enabled = false;
                BntReiniciar.Enabled = true;
                BntFechar.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void chkViewAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewAdmin.Checked == true)
            {
                txtSenhaAdmin.PasswordChar = '\u0000';
            }
            else
            {
                txtSenhaAdmin.PasswordChar = '*';
            }
        }

        private void chkViewUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewUser.Checked == true)
            {
                txtSenhaUser.PasswordChar = '\u0000';
            }
            else
            {
                txtSenhaUser.PasswordChar = '*';
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetAdmin.TbAdmin'. Você pode movê-la ou removê-la conforme necessário.
            this.tbAdminTableAdapter.Fill(this.dataSetAdmin.TbAdmin);

        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                this.Close();
            }
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (groupBox1.Enabled != false)
            {
                e.Cancel = true;
                MessageBox.Show("Cancelar ou finalizar inclusão registro antes de fechar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
