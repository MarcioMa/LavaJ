using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LavaJ
{
    public partial class FrmCadServico : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;

        int ID = 0;
        public FrmCadServico()
        {
            InitializeComponent();
            DisplayData();
        }

        private void FrmCadServico_Load(object sender, EventArgs e)
        {
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
        }
        private void DisplayData()
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM dbo.TbServico", conn);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            txtIDServ.Text = dt.Rows.Count.ToString();
            conn.Close();
            Refresh();
        }

        private void LimparRegistro()
        {
            txtIDServ.Text = "";
            txtValorServ.Text = "";
            txtServico.Text = "";
            txtDescricao.Text = "";
        }

        private void BntNovoServ_Click(object sender, EventArgs e)
        {

            if (BntNovoServ.Text == "Novo")
            {
                LimparRegistro();
                txtValorServ.Focus();
                BntNovoServ.Text = "Cancelar";
                BntSalvaServ.Enabled = true;
                BntExcluirServ.Enabled = false;
                BntFecharServ.Enabled = false;
                groupBox1.Enabled = true;

            }
            else
            {
                BntNovoServ.Text = "Novo";
                BntSalvaServ.Enabled = false;
                BntExcluirServ.Enabled = true;
                BntFecharServ.Enabled = true;
                groupBox1.Enabled = false;
                LimparRegistro();
            }
        }

        private void BntSalvaServ_Click(object sender, EventArgs e)
        {
            if (txtValorServ.Text != "" && txtServico.Text != "" && txtDescricao.Text != "")
            {
                try
                {

                    string sqlQuery = "INSERT INTO dbo.TbServico(valor, servico, descricao )VALUES(@valor, @servico, @descricao)";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@valor", txtValorServ.Text);
                    cmd.Parameters.AddWithValue("@servico", txtServico.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                    cmd.CommandText = sqlQuery;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro serviço realizado com sucesso!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    dt.Rows.Clear();
                    dataGridView.Refresh();
                    DisplayData();
                    BntNovoServ.Text = "Novo";
                    BntSalvaServ.Enabled = false;
                    BntExcluirServ.Enabled = true;
                    BntFecharServ.Enabled = true;
                    groupBox1.Enabled = false;
                }
            }


        }

        private void BntExcluirServ_Click(object sender, EventArgs e)
        {
            int ID = 0;

            if (dataGridView.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                if (ID > 0)
                {

                    if (MessageBox.Show("Confirma excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE TbServico where ID=@id", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registro deletado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dt.Rows.Clear();
                        dataGridView.Refresh();
                        DisplayData();
                        LimparRegistro();
                        ID = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione registro deseja deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Não tem registro para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtIDServ.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtValorServ.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtServico.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescricao.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BntFecharServ_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                this.Close();
            }
        }

        public void FrmCadServico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (groupBox1.Enabled != false)
            {
                e.Cancel = true;
                MessageBox.Show("Cancelar ou finalizar inclusão registro antes de fechar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        {
                            contextMenuStrip1.Show(this, new Point(e.X, e.Y));
                        }
                        break;
                }
            }
        }

        private void exibirCompletoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            dataGridView.Dock = DockStyle.Fill;
        }

        private void exibirNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            dataGridView.Dock = DockStyle.Bottom;
        }
    }
}
