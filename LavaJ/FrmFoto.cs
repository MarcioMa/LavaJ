using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace LavaJ
{
    public partial class FrmFoto : Form
    {
        string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dbLavaJato\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;


        public FrmFoto()
        {
            InitializeComponent();
            comboBoxPlaca.SelectedIndex = 0;

        }

        private void FrmFoto_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            getImagensSQLServer(conn);
            CarregarPlaca();
        }

        void getImagensSQLServer(SqlConnection conn)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM TbFoto ", conn);

                DataSet ds = new DataSet();

                if (ds.Tables.Count != 0)
                {
                    da.Fill(ds, "TbFoto");
                    dataGridView.DataSource = ds.Tables["TbFoto"];
                }
                else
                {
                    MessageBox.Show("Não tem fotos registrada na base de dados!", "Aviso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                textBoxCodigo.Text = (dataGridView.Rows[e.RowIndex].Cells["Id"].Value).ToString();
                textBoxDescricao.Text = "";
            }
        }

        protected void CarregaFoto()
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.pictureBox.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            CarregaFoto();
            textBoxDescricao.ReadOnly = false;
            textBoxDescricao.Text = "";
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescricao.Text))
            {
                MessageBox.Show("Informe a descrição ou selecione da imagem deseja salvar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                if (cmd.Parameters.Count == 0)
                {
                    this.cmd.CommandText = "INSERT INTO TbFoto(placa,descricao,imagem) values(@placa,@descricao,@imagem)";
                    this.cmd.Parameters.Add("@placa", System.Data.SqlDbType.VarChar, 10);
                    this.cmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar, 50);
                    this.cmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                }
                this.cmd.Parameters["@placa"].Value = this.comboBoxPlaca.Text;
                this.cmd.Parameters["@descricao"].Value = this.textBoxDescricao.Text;
                this.cmd.Parameters["@imagem"].Value = this.vetorImagens;

                int iresultado = this.cmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao incluir imagem no banco de dados.");

                getImagensSQLServer(conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                textBoxDescricao.ReadOnly = true;
            }


        }

        private void buttonCarregar_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text == string.Empty && dataGridView.Rows.Count <= 0)
            {
                MessageBox.Show("Selecione foto deseja exibir!", "Aviso",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                cmd = new SqlCommand("SELECT imagem from TbFoto WHERE id=@id", conn);
                cmd.Parameters.Add("@id", SqlDbType.Int, 4);
                cmd.Parameters["@id"].Value = this.textBoxCodigo.Text;


                conn.Open();
                byte[] vetorImagem = (byte[])cmd.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();

                pictureBox.Image = Image.FromFile(strNomeArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CarregarPlaca()
        {
            DataTable dt = new DataTable();

            try
            {
                String slqQuery = "SELECT * FROM TbCliente";
                conn.Open();
                da = new SqlDataAdapter(slqQuery, conn);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.comboBoxPlaca.DisplayMember = "placa";
                this.comboBoxPlaca.DataSource = dt;
            }
        }

        void getPlacaSQLServer(SqlConnection conn)
        {

            try
            {
                cmd = new SqlCommand("SELECT * from TbFoto WHERE placa=@placa", conn);
                cmd.Parameters.Add("@placa", SqlDbType.VarChar, 10);
                cmd.Parameters["@placa"].Value = this.comboBoxPlaca.Text;

                da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "TbFoto");

                dataGridView.DataSource = ds.Tables["TbFoto"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void getTodasPlacaSQLServer(SqlConnection conn)
        {

            try
            {
                cmd = new SqlCommand("SELECT * from TbFoto", conn);

                da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "TbFoto");

                dataGridView.DataSource = ds.Tables["TbFoto"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAbrirPlaca_Click(object sender, EventArgs e)
        {
            if (comboBoxPlaca.Text == string.Empty)
            {
                MessageBox.Show("Selecione Placa deseja!", "Aviso",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                getPlacaSQLServer(conn);
            }
        }

        private void buttonAbrirTodo_Click(object sender, EventArgs e)
        {
            comboBoxPlaca.Text = "";
            getTodasPlacaSQLServer(conn);
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            if (pictureBox.Dock == DockStyle.None)
            {
                toolTip1.SetToolTip(pictureBox, "Para aumentar clique duas vezes aqui!");
            }
            else
            {
                toolTip1.SetToolTip(pictureBox, "Para diminuir clique duas vezes aqui!");
            }

        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox.Dock == DockStyle.None)
            {
                pictureBox.Dock = DockStyle.Fill;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                dataGridView.Visible = false;
            }
            else
            {
                pictureBox.Dock = DockStyle.None;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                dataGridView.Visible = true;
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int ID = 0;

            if (dataGridView.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                if (ID > 0)

                    if (MessageBox.Show("Deseja excluir o registro atual?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE TbFoto WHERE ID=@id", conn);
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        dataGridView.Refresh();
                        getTodasPlacaSQLServer(conn);
                    }
                    else
                    {
                        MessageBox.Show("Favor Selecionar registro deseja excluir!", "Aviso");
                    }
            }
            else
            {
                MessageBox.Show("Selecione registro deseja excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text != string.Empty && textBoxDescricao.ReadOnly != true)
            {
                buttonSalvar.Enabled = true;
            }
            else
            {
                buttonSalvar.Enabled = false;
            }
        }
    }
}

