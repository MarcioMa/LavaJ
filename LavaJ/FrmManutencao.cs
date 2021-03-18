using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LavaJ
{
    public partial class FrmManutencao : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        DataSet DS;
        FrmMain frmMain { get; set; }

        public FrmManutencao(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void OrganizarOS()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * into #temp From TbNumOs set identity_insert TbNumOs ON truncate table TbNumOs alter table #temp drop column Id set identity_insert TbNumOs OFF insert into TbNumOs select * from #temp", conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tabela Ordem Serviço reoganizado com sucesso", "Aviso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void OrganizarFunc()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * into #temp From TbFunc set identity_insert TbFunc ON truncate table TbFunc alter table #temp drop column Id set identity_insert TbFunc OFF insert into TbFunc select * from #temp", conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tabela Funcionario reoganizado com sucesso", "Aviso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void OrganizarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * into #temp From TbCliente set identity_insert TbCliente ON truncate table TbCliente alter table #temp drop column Id set identity_insert TbCliente OFF insert into TbCliente select * from #temp", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tabela Cliente reoganizado com sucesso", "Aviso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void OrganizarServico()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * into #temp From TbServico set identity_insert TbFunc ON truncate table TbServico alter table #temp drop column Id set identity_insert TbServico OFF insert into TbServico select * from #temp", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tabela Serviço reoganizado com sucesso", "Aviso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void OrganizarFoto()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * into #temp From TbFoto set identity_insert TbFoto ON truncate table TbFoto alter table #temp drop column Id set identity_insert TbFoto OFF insert into TbFoto select * from #temp", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Tabela Serviço reoganizado com sucesso", "Aviso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ChkboxAtivo()
        {
            if (checkBoxOS.CheckState == CheckState.Checked)
            {
                buttonReiniciar.Enabled = true;
                buttonReoganizar.Enabled = true;
            }
            else if (checkBoxAtendente.CheckState == CheckState.Checked)
            {
                buttonReiniciar.Enabled = true;
                buttonReoganizar.Enabled = true;
            }
            else if (checkBoxCliente.CheckState == CheckState.Checked)
            {
                buttonReiniciar.Enabled = true;
                buttonReoganizar.Enabled = true;
            }
            else if (checkBoxServico.CheckState == CheckState.Checked)
            {
                buttonReiniciar.Enabled = true;
                buttonReoganizar.Enabled = true;
            }
            else if (checkBoxFoto.CheckState == CheckState.Checked)
            {
                buttonReiniciar.Enabled = true;
                buttonReoganizar.Enabled = true;
            }
            else
            {
                buttonReiniciar.Enabled = false;
                buttonReoganizar.Enabled = false;
            }
        }

        private void checkBoxOS_CheckedChanged(object sender, EventArgs e)
        {
            ChkboxAtivo();
        }

        private void checkBoxAtendente_CheckedChanged(object sender, EventArgs e)
        {
            ChkboxAtivo();
        }

        private void checkBoxCliente_CheckedChanged(object sender, EventArgs e)
        {
            ChkboxAtivo();
        }

        private void checkBoxServico_CheckedChanged(object sender, EventArgs e)
        {
            ChkboxAtivo();
        }

        private void checkBoxFoto_CheckedChanged(object sender, EventArgs e)
        {
            ChkboxAtivo();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReoganizar_Click(object sender, EventArgs e)
        {
            if (checkBoxOS.CheckState == CheckState.Checked)
            {
                OrganizarOS();
                frmMain.DisplayData();
            }

            if (checkBoxAtendente.CheckState == CheckState.Checked)
            {
                OrganizarFunc();
            }

            if (checkBoxCliente.CheckState == CheckState.Checked)
            {
                OrganizarCliente();
            }

            if (checkBoxServico.CheckState == CheckState.Checked)
            {
                OrganizarServico();
            }

            if (checkBoxFoto.CheckState == CheckState.Checked)
            {
                OrganizarFoto();
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Aviso! Ao confirmar operação não será possível recuperar os dados da tabela", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (checkBoxOS.CheckState == CheckState.Checked)
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE TbNumOs", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        frmMain.DisplayData();
                        MessageBox.Show("Limpezar da Tabela [Ordem  Serviço] realizado com sucesso!", "Aviso");
                    }

                    if (checkBoxAtendente.CheckState == CheckState.Checked)
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE TbFunc", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Limpezar da Tabela [Atendente] realizado com sucesso!", "Aviso");
                    }

                    if (checkBoxCliente.CheckState == CheckState.Checked)
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE TbCliente", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Limpezar da Tabela [Cliente] realizado com sucesso!", "Aviso");
                    }

                    if (checkBoxServico.CheckState == CheckState.Checked)
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE TbServico", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Limpezar da Tabela [Serviço] realizado com sucesso!", "Aviso");
                    }

                    if (checkBoxFoto.CheckState == CheckState.Checked)
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE TbFoto", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Limpezar da Tabela [Foto] realizado com sucesso!", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
