using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LavaJ
{
    public partial class FrmCadAtendente : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        public FrmCadAtendente()
        {
            InitializeComponent();
            DisplayData();
        }

        private void FrmCadAtendente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetAt1.TbFunc'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFuncTableAdapter.Fill(this.dataSetAt1.TbFunc);
            // TODO: esta linha de código carrega dados na tabela 'dataSetAt.TbFunc'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFuncTableAdapter.Fill(this.dataSetAt.TbFunc);
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
        }

        private void DisplayData()
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM dbo.TbFunc", conn);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            txtIDAt.Text = dt.Rows.Count.ToString();
            conn.Close();
            Refresh();
        }

        private void LimparRegistro()
        {
            txtIDAt.Text = "";
            mskDataCad.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            mskCont1At.Text = "";
            mskCont2At.Text = "";
            mskCPF.Text = "";
            mskDatNasc.Text = "";
        }

        private void BntNovo_Click(object sender, EventArgs e)
        {
            if (BntNovo.Text == "Novo")
            {
                LimparRegistro();
                mskDataCad.Text = DateTime.Now.ToShortDateString();
                txtNome.Focus();
                BntNovo.Text = "Cancelar";
                BntSalva.Enabled = true;
                BntExcluir.Enabled = false;
                BntFechar.Enabled = false;
                groupBox1.Enabled = true;

            }
            else
            {
                BntNovo.Text = "Novo";
                BntSalva.Enabled = false;
                BntExcluir.Enabled = true;
                BntFechar.Enabled = true;
                groupBox1.Enabled = false;
                LimparRegistro();
            }
        }

        private void BntSalva_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && mskCPF.Text != "" && mskCont1At.Text != "" && mskCont2At.Text != "" && mskDatNasc.Text != "")
            {
                try
                {

                    string sqlQuery = "INSERT INTO dbo.TbFunc (dt_cad, nome, nasc, endereco, cpf, cidade, uf, contato1, contato2)VALUES(@dt_cad, @nome, @nasc, @endereco, @cpf, @cidade, @uf, @contato1, @contato2)";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@dt_cad", mskDataCad.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@nasc", mskDatNasc.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    this.mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    string cpf = mskCPF.Text;
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@uf", txtUF.Text);
                    cmd.Parameters.AddWithValue("@contato1", mskCont1At.Text);
                    cmd.Parameters.AddWithValue("@contato2", mskCont2At.Text);

                    cmd.CommandText = sqlQuery;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Funcionário realizado com sucesso!");
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
                    BntNovo.Text = "Novo";
                    BntSalva.Enabled = false;
                    BntExcluir.Enabled = true;
                    BntFechar.Enabled = true;
                    groupBox1.Enabled = false;
                }
            }
        }

        private void BntExcluir_Click(object sender, EventArgs e)
        {
            int ID = 0;

            if (dataGridView.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                if (ID > 0)
                {

                    if (MessageBox.Show("Confirma excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("DELETE TbFunc where ID=@id", conn);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];

                txtIDAt.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                mskDataCad.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNome.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                mskDatNasc.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEndereco.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                mskCPF.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCidade.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtUF.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                mskCont1At.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                mskCont2At.Text = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                this.Close();
            }
        }

        public void FrmCadAtendente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void exibirCompletoToolStripMenuItem_Click(object sender, EventArgs e)
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
