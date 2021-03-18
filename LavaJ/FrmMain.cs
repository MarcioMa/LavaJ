using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LavaJ
{
    public partial class FrmMain : Form
    {
        string chkStatus = "";
        public int TipoRelatorio;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;
        public bool Adminlogin;

        //Inicializa componentes Form
        public FrmMain()
        {
            InitializeComponent();
            groupBoxRegistro.Enabled = false;
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        //Carregar datagridview
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisplayData();

            //Carrega sistema sistema de login
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.Show();
            this.Enabled = false;
        }

        //carregar cboServiços 
        public void carregaCBO()
        {
            dt = new DataTable();
            try
            {
                String slqQuery = "SELECT * FROM TbServico";
                conn.Open();
                da = new SqlDataAdapter(slqQuery, conn);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.cboServico.DisplayMember = "Servico";
                this.cboServico.DataSource = dt;
                this.cboValor.DisplayMember = "Valor";
                this.cboValor.DataSource = dt;
            }
        }

        //Carregar cboFuncionarios
        public void CarregarFunc()
        {
            dt = new DataTable();
            //Carrega Nomes TbFunc
            try
            {
                String slqQuery = "SELECT * FROM TbFunc";
                conn.Open();
                da = new SqlDataAdapter(slqQuery, conn);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.cboAtendente.DisplayMember = "nome";
                this.cboAtendente.DataSource = dt;
            }
        }

        //Carrega cboCliente
        public void CarregarCliente()
        {
            dt = new DataTable();

            try
            {
                String slqQuery = "SELECT * FROM TbCliente";
                conn.Open();
                da = new SqlDataAdapter(slqQuery, conn);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.cboCliente.DisplayMember = "nome";
                this.cboCliente.DataSource = dt;
                this.cboPlaca.DisplayMember = "placa";
                this.cboPlaca.DataSource = dt;
                this.cboVeiculo.DisplayMember = "veiculo_Mod";
                this.cboVeiculo.DataSource = dt;
                this.cboContato.DisplayMember = "contato1";
                this.cboContato.DataSource = dt;
                this.cboEndereco.DisplayMember = "endereco";
                this.cboEndereco.DataSource = dt;
            }
        }

        //Alterar textos ao mudar index
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeClien.Text = cboCliente.Text;
            mskPlaca.Text = cboPlaca.Text;
            txtVeiculo.Text = cboVeiculo.Text;
            mskContato.Text = cboContato.Text;
            txtEndereco.Text = cboEndereco.Text;
        }
        private void cboValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Text = cboValor.Text;
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            carregaCBO();
            CarregarFunc();
            CarregarCliente();

            if (bntNovo.Text == "Novo")
            {
                LimparRegistro();
                GerarOs();
                cboAtendente.Focus();
                bntNovo.Text = "Salvar";
                bntLimpar.Text = "Cancelar";
                groupBoxRegistro.Enabled = true;
                bntAtualizar.Enabled = false;
                bntExcluir.Enabled = false;
                menuStrip1.Enabled = false;
            }
            else
            {
                SalvarRegistro();
                bntNovo.Text = "Novo";
                bntLimpar.Text = "Limpar";
                groupBoxRegistro.Enabled = false;
                bntAtualizar.Enabled = true;
                bntExcluir.Enabled = true;
                menuStrip1.Enabled = true;
                LimparRegistro();

            }
        }
        private void bntLimpar_Click(object sender, EventArgs e)
        {
            if (bntLimpar.Text == "Limpar")
            {
                LimparRegistro();
            }
            else
            {
                bntNovo.Text = "Novo";
                bntNovo.Enabled = true;
                bntLimpar.Text = "Limpar";
                bntAtualizar.Text = "Atualizar";
                bntAtualizar.Enabled = true;
                bntExcluir.Enabled = true;
                menuStrip1.Enabled = true;
                groupBoxRegistro.Enabled = false;
                LimparRegistro();
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

                        conn.Open();
                        cmd = new SqlCommand("DELETE TbNumOs WHERE ID=@id", conn);
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        dt.Rows.Clear();
                        dataGridView.Refresh();
                        DisplayData();
                        LimparRegistro();
                        ID = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Favor Selecionar registro deseja excluir!", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Não tem registro para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Preencher datagridview
        public void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM dbo.TbNumOs", conn);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        //Gerar numero de registro
        private void GerarOs()
        {
            DateTime aDate = DateTime.Now;

            string numMesAno = DateTime.Now.ToString("yyyyMMdd");
            Random rand = new Random();
            int n = rand.Next(100, 999);
            string tReg = n.ToString("000");
            lblVRegistro.Text = numMesAno + tReg;
        }

        //Limpar formulario 
        private void LimparRegistro()
        {
            lblVRegistro.Text = "";
            mskDtEntrada.Text = "";
            mskHrEntrada.Text = "";
            mskDtSaida.Text = "";
            mskHrSaida.Text = "";
            mskContato.Text = "";
            mskPlaca.Text = "";
            txtValor.Text = "";
            txtNomeClien.Text = "";
            txtVeiculo.Text = "";
            txtEndereco.Text = "";
            txtAnotacao.Text = "";
            txtStatus.Text = "";
            cboServico.Text = "Selecione...";
            cboCliente.Text = "Selecione...";
            cboAtendente.Text = "Selecione...";
            ChkReceber.Checked = false;
            ChkFinalizado.Checked = false;
            ChkPago.Checked = false;
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            //Verificar Atualização de Valores ao atualizar finalizado; 
            if (txtStatus.Text != "Finalizado")
            {
                if (bntAtualizar.Text == "Atualizar")
                {
                    carregaCBO();

                    bntAtualizar.Text = "Salvar";
                    bntLimpar.Text = "Cancelar";
                    bntExcluir.Enabled = false;
                    bntNovo.Enabled = false;
                    menuStrip1.Enabled = false;
                    groupBoxRegistro.Enabled = true;
                    cboAtendente.Enabled = false;
                    txtNomeClien.Enabled = false;
                    cboCliente.Enabled = false;
                    txtEndereco.Enabled = false;
                    cboEndereco.Enabled = false;
                    txtValor.Enabled = false;
                }
                else
                {


                    AtualizarDados();

                    bntAtualizar.Text = "Atualizar";
                    bntLimpar.Text = "Limpar";
                    bntExcluir.Enabled = true;
                    bntNovo.Enabled = true;
                    menuStrip1.Enabled = true;
                    groupBoxRegistro.Enabled = false;
                    cboAtendente.Enabled = true;
                    txtNomeClien.Enabled = true;
                    cboCliente.Enabled = true;
                    txtEndereco.Enabled = true;
                    cboEndereco.Enabled = true;
                    txtValor.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Não é possível atualizar registro finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisplayData();
                return;
            }


        }

        private void ChkReceber_CheckedChanged(object sender, EventArgs e)
        {
            if (txtStatus.Text == "Finalizado")
            {
                MessageBox.Show("Não é possível retornar registro finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ChkReceber.Checked = false;
                DisplayData();
            }
        }

        private void ChkPago_CheckedChanged(object sender, EventArgs e)
        {
            if (txtStatus.Text == "Finalizado")
            {
                MessageBox.Show("Não é possível retornar registro finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ChkPago.Checked = false;
                DisplayData();
            }
        }
        private void AtualizarDados()
        {
            if (dataGridView.Rows.Count > 0)
            {
                ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                try
                {
                    if (ID > 0)
                    {
                        if (MessageBox.Show("Confirma Atualização do registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            string sqlQuery = "UPDATE dbo.TbNumOs SET data_saida = @data_saida, hora_saida = @hora_saida, " +
                            "servico_desc = @servico_desc, valor = @valor, contato_client = @contato_client, veiculo = @veiculo, " +
                            "placa_v = @placa_v, anotacao = @anotacao, status_os = @status_os WHERE ID=@id";

                            conn.Open();
                            cmd = new SqlCommand(sqlQuery, conn);
                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@data_saida", mskDtSaida.Text);
                            cmd.Parameters.AddWithValue("@hora_saida", mskHrSaida.Text);
                            cmd.Parameters.AddWithValue("@servico_desc", cboServico.Text);
                            cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                            cmd.Parameters.AddWithValue("@contato_client", mskContato.Text);
                            cmd.Parameters.AddWithValue("@veiculo", txtVeiculo.Text);
                            cmd.Parameters.AddWithValue("@placa_v", mskPlaca.Text);
                            cmd.Parameters.AddWithValue("@anotacao", txtAnotacao.Text);
                            cmd.Parameters.AddWithValue("@status_os", chkStatus);

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
                }
                finally
                {
                    groupBoxRegistro.Enabled = false;
                    dt.Rows.Clear();
                    dataGridView.Refresh();
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Não tem registro para Atualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Configura Status chkbox
        public void RecStatus()
        {
            if (cboAtendente.Text != "" && txtNomeClien.Text != "" && mskContato.Text != "" && mskPlaca.Text != "" && cboServico.Text != "" && txtValor.Text != "")
            {

                //A receber
                if (ChkReceber.Checked == true)
                {
                    ChkPago.Checked = false;
                    ChkFinalizado.Checked = false;
                    chkStatus = "Receber";
                    txtStatus.Text = "Receber";
                    mskDtEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    mskHrEntrada.Text = DateTime.Now.ToString("HH:mm");
                }
                else if (ChkPago.Checked == true)
                {
                    ChkReceber.Checked = false;
                    ChkFinalizado.Checked = false;
                    chkStatus = "Pago";
                    txtStatus.Text = "Pago";
                    mskDtEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    mskHrEntrada.Text = DateTime.Now.ToString("HH:mm");
                }
                else if (ChkFinalizado.Checked == true)
                {
                    if (MessageBox.Show("Deseja finalizar registro não será mais possível alterações!?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (mskDtEntrada.Text == string.Empty)
                        {
                            mskDtEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
                            mskHrEntrada.Text = DateTime.Now.ToString("HH:mm");
                        }

                        ChkFinalizado.Checked = true;
                        ChkReceber.Checked = false;
                        ChkPago.Checked = false;
                        chkStatus = "Finalizado";
                        txtStatus.Text = "Finalizado";
                        mskDtSaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        mskHrSaida.Text = DateTime.Now.ToString("HH:mm");

                        //Finalizar registro em atualização de dados
                        if (bntAtualizar.Text == "Salvar")
                        {
                            bntAtualizar.Text = "Atualizar";
                            bntLimpar.Text = "Limpar";
                            bntExcluir.Enabled = true;
                            bntNovo.Enabled = true;
                            menuStrip1.Enabled = true;
                            groupBoxRegistro.Enabled = false;
                            cboAtendente.Enabled = true;
                            txtNomeClien.Enabled = true;
                            cboCliente.Enabled = true;
                            txtEndereco.Enabled = true;
                            cboEndereco.Enabled = true;
                            txtValor.Enabled = true;

                            AtualizarDados();
                            dataGridView.Refresh();
                            DisplayData();
                        }
                    }
                    else
                    {
                        ChkFinalizado.Checked = false;
                        ChkReceber.Checked = false;
                        ChkPago.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencher todos dados antes seleciona opção !", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ChkFinalizado.Checked = false;
                ChkReceber.Checked = false;
                ChkPago.Checked = false;
            }
        }

        //Realizar Insert registros
        public void SalvarRegistro()
        {

            if (cboAtendente.Text != "" && txtNomeClien.Text != "" && mskContato.Text != "" && mskPlaca.Text != "" && cboServico.Text != "" && txtValor.Text != "")
            {
                try
                {

                    string sqlQuery = "INSERT INTO dbo.TbNumOs(num_os, nom_atend, data_entrada, hora_entrada, data_saida, hora_saida, servico_desc, valor, nome_client, contato_client, endereco, veiculo, placa_v, anotacao, status_os)VALUES(@num_os, @nom_atend, @data_entrada, @hora_entrada, @data_saida, @hora_saida, @servico_desc, @valor, @nome_client, @contato_client, @endereco, @veiculo, @placa_v, @anotacao, @status_os)";

                    conn.Open();
                    cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@num_os", lblVRegistro.Text);
                    cmd.Parameters.AddWithValue("@nom_atend", cboAtendente.Text);
                    cmd.Parameters.AddWithValue("@data_entrada", mskDtEntrada.Text);
                    cmd.Parameters.AddWithValue("@hora_entrada", mskHrEntrada.Text);
                    cmd.Parameters.AddWithValue("@data_saida", mskDtSaida.Text);
                    cmd.Parameters.AddWithValue("@hora_saida", mskHrSaida.Text);
                    cmd.Parameters.AddWithValue("@servico_desc", cboServico.Text);
                    cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@nome_client", txtNomeClien.Text);
                    cmd.Parameters.AddWithValue("@contato_client", mskContato.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@veiculo", txtVeiculo.Text);
                    cmd.Parameters.AddWithValue("@placa_v", mskPlaca.Text);
                    cmd.Parameters.AddWithValue("@anotacao", txtAnotacao.Text);
                    cmd.Parameters.AddWithValue("@status_os", chkStatus);

                    cmd.CommandText = sqlQuery;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro serviço realizado com sucesso!");
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                }
                finally
                {
                    ChkFinalizado.Checked = false;
                    ChkReceber.Checked = false;
                    ChkPago.Checked = false;
                    dt.Rows.Clear();
                    dataGridView.Refresh();
                    DisplayData();
                }
            }
        }

        private void ChkReceber_Click(object sender, EventArgs e)
        {
            RecStatus();
        }

        private void ChkPago_Click(object sender, EventArgs e)
        {
            RecStatus();
        }

        private void ChkFinalizado_Click(object sender, EventArgs e)
        {
            RecStatus();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];

                lblVRegistro.Text = row.Cells[1].Value.ToString();
                cboAtendente.Text = row.Cells[2].Value.ToString();
                mskDtEntrada.Text = row.Cells[3].Value.ToString();
                mskHrEntrada.Text = row.Cells[4].Value.ToString();
                mskDtSaida.Text = row.Cells[5].Value.ToString();
                mskHrSaida.Text = row.Cells[6].Value.ToString();
                cboServico.Text = row.Cells[7].Value.ToString();
                txtValor.Text = row.Cells[8].Value.ToString();
                txtNomeClien.Text = row.Cells[9].Value.ToString();
                cboCliente.Text = row.Cells[9].Value.ToString();
                mskPlaca.Text = row.Cells[13].Value.ToString();
                txtVeiculo.Text = row.Cells[12].Value.ToString();
                mskContato.Text = row.Cells[10].Value.ToString();
                txtEndereco.Text = row.Cells[11].Value.ToString();
                txtAnotacao.Text = row.Cells[14].Value.ToString();
                txtStatus.Text = row.Cells[15].Value.ToString();

            }
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            statusStrip1.Width = this.Width / 2;
        }

        private void atendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Adminlogin == true)
            {
                FrmCadAtendente frmCadAtendente = new FrmCadAtendente();
                frmCadAtendente.ShowDialog();
                int i = 0;

                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "FrmCadAtendente")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmCadAtendente frmCad = new FrmCadAtendente();
                    frmCadAtendente.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Adminlogin == true)
            {
                FrmCadServico frmCadServico = new FrmCadServico();
                frmCadServico.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "FrmCadServico")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmCadServico frmCad = new FrmCadServico();
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void administradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Adminlogin == true)
            {
                FrmAdmin frmCadAdm = new FrmAdmin();
                frmCadAdm.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "FrmAdmin")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmAdmin frmCad = new FrmAdmin();
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente frmCadCliente = new FrmCadCliente();
            frmCadCliente.ShowDialog();

            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FrmCadCliente")
                {
                    i = -1;
                    break;
                }
            }

            if (i != 0)
            {
                FrmCadCliente frmCad = new FrmCadCliente();
                frmCad.ShowDialog();
                frmCadCliente.Close();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();

            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmSobre")
                {
                    i = -1;
                    break;
                }
            }

            if (i != 0)
            {
                FrmSobre frmCad = new FrmSobre();
                frmCad.ShowDialog();
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Adminlogin == true)
            {

                FrmBackup frmBackup = new FrmBackup();
                frmBackup.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmBackup")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmBackup frmCad = new FrmBackup();
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void salvarFotosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Adminlogin == true)
            {
                FrmManutencao frmManutencao = new FrmManutencao(this);
                frmManutencao.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmManutencao")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmManutencao frmCad = new FrmManutencao(this);
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }

        }

        private void relatorioDeOrdemServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoRelatorio = 1;

            if (Adminlogin == true)
            {
                FrmRelatorio frmRelatorio = new FrmRelatorio(this);
                frmRelatorio.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmRelatorio")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmRelatorio frmCad = new FrmRelatorio(this);
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void relatorioDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoRelatorio = 2;

            if (Adminlogin == true)
            {
                FrmRelatorio frmRelatorio = new FrmRelatorio(this);
                frmRelatorio.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmRelatorio")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmRelatorio frmCad = new FrmRelatorio(this);
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void relatorioDeFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoRelatorio = 3;

            if (Adminlogin == true)
            {
                FrmRelatorio frmRelatorio = new FrmRelatorio(this);
                frmRelatorio.ShowDialog();

                int i = 0;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmRelatorio")
                    {
                        i = -1;
                        break;
                    }
                }

                if (i != 0)
                {
                    FrmRelatorio frmCad = new FrmRelatorio(this);
                    frmCad.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Acesso restrito ao administrador! Deseja fazer login?", "Restrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin(this);
                    frmLogin.Show();
                }
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();

            int i = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmLogin")
                {
                    i = -1;
                    break;
                }
            }

            if (i != 0)
            {
                FrmLogin frmCad = new FrmLogin(this);
                frmCad.ShowDialog();
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn.Dispose();
            Application.Exit();
        }

        private void groupBoxRegistro_EnabledChanged(object sender, EventArgs e)
        {
            if (groupBoxRegistro.Enabled == true)
            {
                cboCliente.Visible = true;
                cboPlaca.Visible = true;
                cboVeiculo.Visible = true;
                cboContato.Visible = true;
                cboEndereco.Visible = true;
            }
            else
            {
                cboCliente.Visible = false;
                cboPlaca.Visible = false;
                cboVeiculo.Visible = false;
                cboContato.Visible = false;
                cboEndereco.Visible = false;
            }
        }
    }
}
