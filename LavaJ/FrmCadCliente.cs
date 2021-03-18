using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace LavaJ
{
    public partial class FrmCadCliente : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;
        bool checkbntSalvar = true;
        int ID = 0;

        public FrmCadCliente()
        {
            InitializeComponent();
            DisplayData();
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetCliente.TbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.dataSetCliente.TbCliente);

            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
        }

        private void DisplayData()
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM dbo.TbCliente", conn);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            txtIDCliente.Text = dt.Rows.Count.ToString();
            conn.Close();
            Refresh();
        }

        private void LimparRegistro()
        {
            txtIDCliente.Text = "";
            mskDtCadCli.Text = "";
            mskContato1.Text = "";
            mskContato2.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskPlaca.Text = "";
            txtVeiculo.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtObs.Text = "";
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            if (bntNovo.Text == "Novo")
            {
                LimparRegistro();
                mskDtCadCli.Text = DateTime.Now.ToShortDateString();
                txtNome.Focus();
                bntNovo.Text = "Cancelar";
                bntSalva.Enabled = true;
                bntExcluir.Enabled = false;
                bntAtualizar.Enabled = false;
                bntFechar.Enabled = false;
                groupBox1.Enabled = true;

            }
            else
            {
                bntNovo.Text = "Novo";
                bntSalva.Enabled = false;
                bntExcluir.Enabled = true;
                bntAtualizar.Enabled = true;
                bntAtualizar.Text = "Atualizar";
                bntFechar.Enabled = true;
                groupBox1.Enabled = false;
                LimparRegistro();
            }
        }

        private void bntSalva_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && mskContato1.Text != "" && txtVeiculo.Text != "" && mskPlaca.Text != "" && txtCidade.Text != "" && txtUF.Text != "")
            {
                try
                {

                    string sqlQuery = "INSERT INTO dbo.TbCliente (dt_cad, contato1, contato2, nome, veiculo_mod, endereco, placa, cidade, uf, obs) VALUES(@dt_cad, @contato1, @contato2, @nome, @veiculo_mod, @endereco, @placa, @cidade, @uf, @obs )";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@dt_cad", mskDtCadCli.Text);
                    cmd.Parameters.AddWithValue("@contato1", mskContato1.Text);
                    cmd.Parameters.AddWithValue("@contato2", mskContato2.Text);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@veiculo_mod", txtVeiculo.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@placa", mskPlaca.Text);
                    cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("@uf", txtUF.Text);
                    cmd.Parameters.AddWithValue("@obs", txtObs.Text);

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
                    bntNovo.Text = "Novo";
                    bntSalva.Enabled = false;
                    bntExcluir.Enabled = true;
                    bntAtualizar.Enabled = true;
                    bntFechar.Enabled = true;
                    groupBox1.Enabled = false;
                    LimparRegistro();
                }
            }
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            int ID = 0;

            if (dataGridView.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                if (ID > 0)
                {

                    if (MessageBox.Show("Confirma excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE TbCliente where ID=@id", conn);
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
                    MessageBox.Show("Selecione registro deseja deletar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Não tem registro para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {


                if (bntAtualizar.Text == "Atualizar")
                {
                    bntAtualizar.Text = "Gravar";
                    bntNovo.Text = "Cancelar";
                    mskDtCadCli.Enabled = false;
                    txtNome.Enabled = false;
                    bntExcluir.Enabled = false;
                    bntFechar.Enabled = false;
                    bntSalva.Enabled = false;
                    groupBox1.Enabled = true;
                }
                else
                {
                    AtualizarDados();
                    checkbntSalvar = false;
                    bntAtualizar.Text = "Atualizar";
                    bntNovo.Text = "Novo";
                    mskDtCadCli.Enabled = true;
                    txtNome.Enabled = true;
                    bntExcluir.Enabled = true;
                    bntFechar.Enabled = true;
                    bntSalva.Enabled = false;
                    groupBox1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Selecione registro deseja alterar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AtualizarDados()
        {
            ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            try
            {
                if (ID > 0)
                {
                    if (MessageBox.Show("Confirma Atualização do registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string sqlQuery = "UPDATE dbo.TbCliente SET contato1 =  @contato1, contato2 =  @contato2, veiculo_mod = @veiculo_mod, endereco = @endereco, placa = @placa, cidade = @cidade, uf = @uf, obs = @obs WHERE Id=@id";

                        conn.Open();
                        cmd = new SqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@contato1", mskContato1.Text);
                        cmd.Parameters.AddWithValue("@contato2", mskContato2.Text);
                        cmd.Parameters.AddWithValue("@veiculo_mod", txtVeiculo.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@placa", mskPlaca.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@uf", txtUF.Text);
                        cmd.Parameters.AddWithValue("@obs", txtObs.Text);


                        cmd.CommandText = sqlQuery;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione Registro deseja atualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                dt.Rows.Clear();
                dataGridView.Refresh();
                DisplayData();
                checkbntSalvar = false;
                bntAtualizar.Text = "Atualizar";
                bntExcluir.Enabled = true;
                bntNovo.Enabled = true;
                bntFechar.Enabled = true;
                bntSalva.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == false)
            {
                this.Close();
            }
        }

        private void FrmCadCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (groupBox1.Enabled != false)
            {
                e.Cancel = true;
                MessageBox.Show("Cancelar ou finalizar inclusão registro antes de fechar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtIDCliente.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            mskDtCadCli.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            mskContato1.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskContato2.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNome.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtVeiculo.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEndereco.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            mskPlaca.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCidade.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtUF.Text = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtObs.Text = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

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

        private void bntPastaFoto_Click(object sender, EventArgs e)
        {
            FrmFoto frmFoto = new FrmFoto();
            frmFoto.ShowDialog();

            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmFoto")
                {
                    i = -1;
                    break;
                }
            }

            if (i != 0)
            {
                FrmFoto frmCad = new FrmFoto();
                frmCad.ShowDialog();
            }
        }
    }
}
