namespace LavaJ
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarFotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeFotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeOrdemServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet = new LavaJ.DataSet();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNumOsTableAdapter = new LavaJ.DataSetTableAdapters.TbNumOsTableAdapter();
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.cboEndereco = new System.Windows.Forms.ComboBox();
            this.cboContato = new System.Windows.Forms.ComboBox();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.cboPlaca = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboAtendente = new System.Windows.Forms.ComboBox();
            this.cboValor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.mskHrSaida = new System.Windows.Forms.MaskedTextBox();
            this.mskContato = new System.Windows.Forms.MaskedTextBox();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.mskHrEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mskDtSaida = new System.Windows.Forms.MaskedTextBox();
            this.mskDtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblVRegistro = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtAnotacao = new System.Windows.Forms.TextBox();
            this.lblAnotacao = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNomeClien = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblAtendente = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.ChkPago = new System.Windows.Forms.CheckBox();
            this.ChkReceber = new System.Windows.Forms.CheckBox();
            this.ChkFinalizado = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntAtualizar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomatendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicodescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.dataSetServico = new LavaJ.DataSetServico();
            this.dataSetServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbServicoTableAdapter = new LavaJ.DataSetServicoTableAdapters.TbServicoTableAdapter();
            this.tbServicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupBoxRegistro.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1360, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(890, 25);
            this.toolStripStatusLabel1.Text = "SYSLJ V1.1.0 ®MMA Desenvolvimento 12/2020 ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(112, 25);
            this.toolStripStatusLabel2.Text = "DD/MM/AAAA";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(63, 25);
            this.toolStripStatusLabel3.Text = "00:00 ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Image = global::LavaJ.Properties.Resources.loginuser;
            this.toolStripStatusLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(139, 25);
            this.toolStripStatusLabel4.Text = "Usuario Logado:";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(45, 25);
            this.toolStripStatusLabel5.Text = "login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1360, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradoToolStripMenuItem,
            this.atendenteToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.salvarFotosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Image = global::LavaJ.Properties.Resources.cadastros;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(171, 27);
            this.cadastroToolStripMenuItem.Text = "Cadastros Sistema";
            // 
            // administradoToolStripMenuItem
            // 
            this.administradoToolStripMenuItem.Image = global::LavaJ.Properties.Resources.loginuser;
            this.administradoToolStripMenuItem.Name = "administradoToolStripMenuItem";
            this.administradoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.administradoToolStripMenuItem.Text = "Administrado";
            this.administradoToolStripMenuItem.Click += new System.EventHandler(this.administradoToolStripMenuItem_Click);
            // 
            // atendenteToolStripMenuItem
            // 
            this.atendenteToolStripMenuItem.Image = global::LavaJ.Properties.Resources.Func;
            this.atendenteToolStripMenuItem.Name = "atendenteToolStripMenuItem";
            this.atendenteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.atendenteToolStripMenuItem.Text = "Atendente";
            this.atendenteToolStripMenuItem.Click += new System.EventHandler(this.atendenteToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::LavaJ.Properties.Resources.Cliente;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Image = global::LavaJ.Properties.Resources.icon_maquina_cartao_1;
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // salvarFotosToolStripMenuItem
            // 
            this.salvarFotosToolStripMenuItem.Image = global::LavaJ.Properties.Resources.jpg;
            this.salvarFotosToolStripMenuItem.Name = "salvarFotosToolStripMenuItem";
            this.salvarFotosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.salvarFotosToolStripMenuItem.Text = "Salvar Fotos...";
            this.salvarFotosToolStripMenuItem.Click += new System.EventHandler(this.salvarFotosToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.sistemaToolStripMenuItem.Image = global::LavaJ.Properties.Resources.suport;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(198, 27);
            this.sistemaToolStripMenuItem.Text = "Ferramentas Database";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Image = global::LavaJ.Properties.Resources.save;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.databaseToolStripMenuItem.Text = "Backup\\Restore";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Image = global::LavaJ.Properties.Resources._1419612094_advancedsettings;
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.manutençãoToolStripMenuItem.Text = "Manutenção\\Reiniciar ";
            this.manutençãoToolStripMenuItem.Click += new System.EventHandler(this.manutençãoToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeFotosToolStripMenuItem,
            this.relatorioDeClienteToolStripMenuItem,
            this.relatorioDeOrdemServiçoToolStripMenuItem});
            this.relatórioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatórioToolStripMenuItem.Image = global::LavaJ.Properties.Resources.relatorio;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.relatórioToolStripMenuItem.Text = "Relatorios";
            // 
            // relatorioDeFotosToolStripMenuItem
            // 
            this.relatorioDeFotosToolStripMenuItem.Name = "relatorioDeFotosToolStripMenuItem";
            this.relatorioDeFotosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.relatorioDeFotosToolStripMenuItem.Text = "Fotos";
            this.relatorioDeFotosToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeFotosToolStripMenuItem_Click);
            // 
            // relatorioDeClienteToolStripMenuItem
            // 
            this.relatorioDeClienteToolStripMenuItem.Name = "relatorioDeClienteToolStripMenuItem";
            this.relatorioDeClienteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.relatorioDeClienteToolStripMenuItem.Text = "Cliente";
            this.relatorioDeClienteToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeClienteToolStripMenuItem_Click);
            // 
            // relatorioDeOrdemServiçoToolStripMenuItem
            // 
            this.relatorioDeOrdemServiçoToolStripMenuItem.Name = "relatorioDeOrdemServiçoToolStripMenuItem";
            this.relatorioDeOrdemServiçoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.relatorioDeOrdemServiçoToolStripMenuItem.Text = "Ordem Serviço";
            this.relatorioDeOrdemServiçoToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeOrdemServiçoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::LavaJ.Properties.Resources.Information;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Image = global::LavaJ.Properties.Resources.desligar;
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "TbNumOs";
            this.bindingSource.DataSource = this.dataSet;
            // 
            // tbNumOsTableAdapter
            // 
            this.tbNumOsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRegistro.Controls.Add(this.cboEndereco);
            this.groupBoxRegistro.Controls.Add(this.cboContato);
            this.groupBoxRegistro.Controls.Add(this.cboVeiculo);
            this.groupBoxRegistro.Controls.Add(this.cboPlaca);
            this.groupBoxRegistro.Controls.Add(this.cboCliente);
            this.groupBoxRegistro.Controls.Add(this.cboAtendente);
            this.groupBoxRegistro.Controls.Add(this.cboValor);
            this.groupBoxRegistro.Controls.Add(this.label1);
            this.groupBoxRegistro.Controls.Add(this.txtStatus);
            this.groupBoxRegistro.Controls.Add(this.cboServico);
            this.groupBoxRegistro.Controls.Add(this.mskHrSaida);
            this.groupBoxRegistro.Controls.Add(this.mskContato);
            this.groupBoxRegistro.Controls.Add(this.mskPlaca);
            this.groupBoxRegistro.Controls.Add(this.mskHrEntrada);
            this.groupBoxRegistro.Controls.Add(this.mskDtSaida);
            this.groupBoxRegistro.Controls.Add(this.mskDtEntrada);
            this.groupBoxRegistro.Controls.Add(this.lblSaida);
            this.groupBoxRegistro.Controls.Add(this.lblPlaca);
            this.groupBoxRegistro.Controls.Add(this.txtVeiculo);
            this.groupBoxRegistro.Controls.Add(this.lblVeiculo);
            this.groupBoxRegistro.Controls.Add(this.lblContato);
            this.groupBoxRegistro.Controls.Add(this.lblServico);
            this.groupBoxRegistro.Controls.Add(this.lblVRegistro);
            this.groupBoxRegistro.Controls.Add(this.lblRegistro);
            this.groupBoxRegistro.Controls.Add(this.lblValor);
            this.groupBoxRegistro.Controls.Add(this.txtAnotacao);
            this.groupBoxRegistro.Controls.Add(this.lblAnotacao);
            this.groupBoxRegistro.Controls.Add(this.txtEndereco);
            this.groupBoxRegistro.Controls.Add(this.lblEndereco);
            this.groupBoxRegistro.Controls.Add(this.txtNomeClien);
            this.groupBoxRegistro.Controls.Add(this.lblCliente);
            this.groupBoxRegistro.Controls.Add(this.lblEntrada);
            this.groupBoxRegistro.Controls.Add(this.lblAtendente);
            this.groupBoxRegistro.Controls.Add(this.groupBoxStatus);
            this.groupBoxRegistro.Controls.Add(this.txtValor);
            this.groupBoxRegistro.Enabled = false;
            this.groupBoxRegistro.ForeColor = System.Drawing.Color.White;
            this.groupBoxRegistro.Location = new System.Drawing.Point(3, 27);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(309, 550);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.EnabledChanged += new System.EventHandler(this.groupBoxRegistro_EnabledChanged);
            // 
            // cboEndereco
            // 
            this.cboEndereco.FormattingEnabled = true;
            this.cboEndereco.Location = new System.Drawing.Point(16, 355);
            this.cboEndereco.Name = "cboEndereco";
            this.cboEndereco.Size = new System.Drawing.Size(277, 28);
            this.cboEndereco.TabIndex = 21;
            this.cboEndereco.Visible = false;
            // 
            // cboContato
            // 
            this.cboContato.FormattingEnabled = true;
            this.cboContato.Location = new System.Drawing.Point(15, 306);
            this.cboContato.Name = "cboContato";
            this.cboContato.Size = new System.Drawing.Size(278, 28);
            this.cboContato.TabIndex = 21;
            this.cboContato.Visible = false;
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(110, 258);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(183, 28);
            this.cboVeiculo.TabIndex = 21;
            this.cboVeiculo.Visible = false;
            // 
            // cboPlaca
            // 
            this.cboPlaca.FormattingEnabled = true;
            this.cboPlaca.Location = new System.Drawing.Point(15, 258);
            this.cboPlaca.Name = "cboPlaca";
            this.cboPlaca.Size = new System.Drawing.Size(89, 28);
            this.cboPlaca.TabIndex = 21;
            this.cboPlaca.Visible = false;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(15, 204);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(278, 28);
            this.cboCliente.TabIndex = 20;
            this.cboCliente.Visible = false;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // cboAtendente
            // 
            this.cboAtendente.FormattingEnabled = true;
            this.cboAtendente.Location = new System.Drawing.Point(14, 57);
            this.cboAtendente.Name = "cboAtendente";
            this.cboAtendente.Size = new System.Drawing.Size(279, 28);
            this.cboAtendente.TabIndex = 19;
            // 
            // cboValor
            // 
            this.cboValor.FormattingEnabled = true;
            this.cboValor.Location = new System.Drawing.Point(167, 156);
            this.cboValor.Name = "cboValor";
            this.cboValor.Size = new System.Drawing.Size(124, 28);
            this.cboValor.TabIndex = 18;
            this.cboValor.SelectedIndexChanged += new System.EventHandler(this.cboValor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(110, 468);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(181, 26);
            this.txtStatus.TabIndex = 15;
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(170, 106);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(123, 28);
            this.cboServico.TabIndex = 4;
            // 
            // mskHrSaida
            // 
            this.mskHrSaida.Location = new System.Drawing.Point(110, 157);
            this.mskHrSaida.Mask = "00:00";
            this.mskHrSaida.Name = "mskHrSaida";
            this.mskHrSaida.ReadOnly = true;
            this.mskHrSaida.Size = new System.Drawing.Size(53, 26);
            this.mskHrSaida.TabIndex = 6;
            this.mskHrSaida.ValidatingType = typeof(System.DateTime);
            // 
            // mskContato
            // 
            this.mskContato.Location = new System.Drawing.Point(15, 306);
            this.mskContato.Mask = "(99) 00000-0000";
            this.mskContato.Name = "mskContato";
            this.mskContato.Size = new System.Drawing.Size(276, 26);
            this.mskContato.TabIndex = 11;
            // 
            // mskPlaca
            // 
            this.mskPlaca.Location = new System.Drawing.Point(15, 258);
            this.mskPlaca.Mask = "AAA-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(74, 26);
            this.mskPlaca.TabIndex = 9;
            this.mskPlaca.ValidatingType = typeof(int);
            // 
            // mskHrEntrada
            // 
            this.mskHrEntrada.Location = new System.Drawing.Point(110, 107);
            this.mskHrEntrada.Mask = "00:00";
            this.mskHrEntrada.Name = "mskHrEntrada";
            this.mskHrEntrada.ReadOnly = true;
            this.mskHrEntrada.Size = new System.Drawing.Size(53, 26);
            this.mskHrEntrada.TabIndex = 3;
            this.mskHrEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // mskDtSaida
            // 
            this.mskDtSaida.Location = new System.Drawing.Point(15, 157);
            this.mskDtSaida.Mask = "00/00/0000";
            this.mskDtSaida.Name = "mskDtSaida";
            this.mskDtSaida.ReadOnly = true;
            this.mskDtSaida.Size = new System.Drawing.Size(89, 26);
            this.mskDtSaida.TabIndex = 5;
            this.mskDtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // mskDtEntrada
            // 
            this.mskDtEntrada.Location = new System.Drawing.Point(15, 107);
            this.mskDtEntrada.Mask = "00/00/0000";
            this.mskDtEntrada.Name = "mskDtEntrada";
            this.mskDtEntrada.ReadOnly = true;
            this.mskDtEntrada.Size = new System.Drawing.Size(89, 26);
            this.mskDtEntrada.TabIndex = 2;
            this.mskDtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(11, 134);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(136, 20);
            this.lblSaida.TabIndex = 0;
            this.lblSaida.Text = "Data \\ Hora Saída";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(11, 231);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(110, 258);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(183, 26);
            this.txtVeiculo.TabIndex = 10;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(106, 235);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(125, 20);
            this.lblVeiculo.TabIndex = 0;
            this.lblVeiculo.Text = "Veículo \\ Modelo";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(11, 287);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(151, 20);
            this.lblContato.TabIndex = 0;
            this.lblContato.Text = "Contato \\ Whatsapp";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(180, 84);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(61, 20);
            this.lblServico.TabIndex = 0;
            this.lblServico.Text = "Serviço";
            // 
            // lblVRegistro
            // 
            this.lblVRegistro.BackColor = System.Drawing.Color.White;
            this.lblVRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblVRegistro.Location = new System.Drawing.Point(169, 20);
            this.lblVRegistro.Name = "lblVRegistro";
            this.lblVRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVRegistro.Size = new System.Drawing.Size(122, 26);
            this.lblVRegistro.TabIndex = 0;
            this.lblVRegistro.Text = "00";
            this.lblVRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(115, 24);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(53, 20);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Nº OS";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(180, 134);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor(R$) ";
            // 
            // txtAnotacao
            // 
            this.txtAnotacao.Location = new System.Drawing.Point(15, 403);
            this.txtAnotacao.Multiline = true;
            this.txtAnotacao.Name = "txtAnotacao";
            this.txtAnotacao.Size = new System.Drawing.Size(276, 59);
            this.txtAnotacao.TabIndex = 14;
            // 
            // lblAnotacao
            // 
            this.lblAnotacao.AutoSize = true;
            this.lblAnotacao.Location = new System.Drawing.Point(11, 380);
            this.lblAnotacao.Name = "lblAnotacao";
            this.lblAnotacao.Size = new System.Drawing.Size(86, 20);
            this.lblAnotacao.TabIndex = 0;
            this.lblAnotacao.Text = "Anotações";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(15, 355);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(278, 26);
            this.txtEndereco.TabIndex = 13;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(11, 332);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtNomeClien
            // 
            this.txtNomeClien.Location = new System.Drawing.Point(15, 206);
            this.txtNomeClien.Name = "txtNomeClien";
            this.txtNomeClien.Size = new System.Drawing.Size(278, 26);
            this.txtNomeClien.TabIndex = 8;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(11, 183);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(104, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nome Cliente";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(11, 84);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(152, 20);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Data \\ Hora Entrada";
            // 
            // lblAtendente
            // 
            this.lblAtendente.AutoSize = true;
            this.lblAtendente.Location = new System.Drawing.Point(11, 39);
            this.lblAtendente.Name = "lblAtendente";
            this.lblAtendente.Size = new System.Drawing.Size(84, 20);
            this.lblAtendente.TabIndex = 0;
            this.lblAtendente.Text = "Atendente";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.ChkPago);
            this.groupBoxStatus.Controls.Add(this.ChkReceber);
            this.groupBoxStatus.Controls.Add(this.ChkFinalizado);
            this.groupBoxStatus.Location = new System.Drawing.Point(15, 493);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(278, 45);
            this.groupBoxStatus.TabIndex = 16;
            this.groupBoxStatus.TabStop = false;
            // 
            // ChkPago
            // 
            this.ChkPago.AutoSize = true;
            this.ChkPago.Location = new System.Drawing.Point(100, 16);
            this.ChkPago.Name = "ChkPago";
            this.ChkPago.Size = new System.Drawing.Size(65, 24);
            this.ChkPago.TabIndex = 5;
            this.ChkPago.Text = "Pago";
            this.ChkPago.UseVisualStyleBackColor = true;
            this.ChkPago.CheckedChanged += new System.EventHandler(this.ChkPago_CheckedChanged);
            this.ChkPago.Click += new System.EventHandler(this.ChkPago_Click);
            // 
            // ChkReceber
            // 
            this.ChkReceber.AutoSize = true;
            this.ChkReceber.Location = new System.Drawing.Point(8, 15);
            this.ChkReceber.Name = "ChkReceber";
            this.ChkReceber.Size = new System.Drawing.Size(89, 24);
            this.ChkReceber.TabIndex = 6;
            this.ChkReceber.Text = "Receber";
            this.ChkReceber.UseVisualStyleBackColor = true;
            this.ChkReceber.CheckedChanged += new System.EventHandler(this.ChkReceber_CheckedChanged);
            this.ChkReceber.Click += new System.EventHandler(this.ChkReceber_Click);
            // 
            // ChkFinalizado
            // 
            this.ChkFinalizado.AutoSize = true;
            this.ChkFinalizado.BackColor = System.Drawing.Color.Transparent;
            this.ChkFinalizado.Location = new System.Drawing.Point(173, 16);
            this.ChkFinalizado.Name = "ChkFinalizado";
            this.ChkFinalizado.Size = new System.Drawing.Size(100, 24);
            this.ChkFinalizado.TabIndex = 7;
            this.ChkFinalizado.Text = "Finalizado";
            this.ChkFinalizado.UseVisualStyleBackColor = false;
            this.ChkFinalizado.Click += new System.EventHandler(this.ChkFinalizado_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(167, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(124, 26);
            this.txtValor.TabIndex = 7;
            // 
            // bntNovo
            // 
            this.bntNovo.ForeColor = System.Drawing.Color.Black;
            this.bntNovo.Location = new System.Drawing.Point(166, 578);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(77, 47);
            this.bntNovo.TabIndex = 15;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.ForeColor = System.Drawing.Color.Black;
            this.bntAtualizar.Location = new System.Drawing.Point(81, 578);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(86, 47);
            this.bntAtualizar.TabIndex = 16;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.UseVisualStyleBackColor = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.ForeColor = System.Drawing.Color.Black;
            this.bntLimpar.Location = new System.Drawing.Point(2, 578);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(80, 47);
            this.bntLimpar.TabIndex = 17;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numosDataGridViewTextBoxColumn,
            this.nomatendDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn,
            this.horaentradaDataGridViewTextBoxColumn,
            this.datasaidaDataGridViewTextBoxColumn,
            this.horasaidaDataGridViewTextBoxColumn,
            this.servicodescDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.nomeclientDataGridViewTextBoxColumn,
            this.contatoclientDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.placavDataGridViewTextBoxColumn,
            this.anotacaoDataGridViewTextBoxColumn,
            this.statusosDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(318, 35);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1043, 588);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numosDataGridViewTextBoxColumn
            // 
            this.numosDataGridViewTextBoxColumn.DataPropertyName = "num_os";
            this.numosDataGridViewTextBoxColumn.HeaderText = "OS";
            this.numosDataGridViewTextBoxColumn.Name = "numosDataGridViewTextBoxColumn";
            this.numosDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomatendDataGridViewTextBoxColumn
            // 
            this.nomatendDataGridViewTextBoxColumn.DataPropertyName = "nom_atend";
            this.nomatendDataGridViewTextBoxColumn.HeaderText = "Atendente";
            this.nomatendDataGridViewTextBoxColumn.Name = "nomatendDataGridViewTextBoxColumn";
            this.nomatendDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "data_entrada";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataentradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            // 
            // horaentradaDataGridViewTextBoxColumn
            // 
            this.horaentradaDataGridViewTextBoxColumn.DataPropertyName = "hora_entrada";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.horaentradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.horaentradaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.horaentradaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaentradaDataGridViewTextBoxColumn.Name = "horaentradaDataGridViewTextBoxColumn";
            // 
            // datasaidaDataGridViewTextBoxColumn
            // 
            this.datasaidaDataGridViewTextBoxColumn.DataPropertyName = "data_saida";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.datasaidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.datasaidaDataGridViewTextBoxColumn.HeaderText = "Saida";
            this.datasaidaDataGridViewTextBoxColumn.Name = "datasaidaDataGridViewTextBoxColumn";
            // 
            // horasaidaDataGridViewTextBoxColumn
            // 
            this.horasaidaDataGridViewTextBoxColumn.DataPropertyName = "hora_saida";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.horasaidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.horasaidaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.horasaidaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horasaidaDataGridViewTextBoxColumn.Name = "horasaidaDataGridViewTextBoxColumn";
            // 
            // servicodescDataGridViewTextBoxColumn
            // 
            this.servicodescDataGridViewTextBoxColumn.DataPropertyName = "servico_desc";
            this.servicodescDataGridViewTextBoxColumn.HeaderText = "Serviço";
            this.servicodescDataGridViewTextBoxColumn.Name = "servicodescDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorDataGridViewTextBoxColumn.HeaderText = "R$";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // nomeclientDataGridViewTextBoxColumn
            // 
            this.nomeclientDataGridViewTextBoxColumn.DataPropertyName = "nome_client";
            this.nomeclientDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeclientDataGridViewTextBoxColumn.Name = "nomeclientDataGridViewTextBoxColumn";
            // 
            // contatoclientDataGridViewTextBoxColumn
            // 
            this.contatoclientDataGridViewTextBoxColumn.DataPropertyName = "contato_client";
            this.contatoclientDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoclientDataGridViewTextBoxColumn.Name = "contatoclientDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            // 
            // placavDataGridViewTextBoxColumn
            // 
            this.placavDataGridViewTextBoxColumn.DataPropertyName = "placa_v";
            this.placavDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placavDataGridViewTextBoxColumn.Name = "placavDataGridViewTextBoxColumn";
            // 
            // anotacaoDataGridViewTextBoxColumn
            // 
            this.anotacaoDataGridViewTextBoxColumn.DataPropertyName = "anotacao";
            this.anotacaoDataGridViewTextBoxColumn.HeaderText = "Anotação";
            this.anotacaoDataGridViewTextBoxColumn.Name = "anotacaoDataGridViewTextBoxColumn";
            this.anotacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusosDataGridViewTextBoxColumn
            // 
            this.statusosDataGridViewTextBoxColumn.DataPropertyName = "status_os";
            this.statusosDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusosDataGridViewTextBoxColumn.Name = "statusosDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.bntLimpar);
            this.panel1.Controls.Add(this.bntAtualizar);
            this.panel1.Controls.Add(this.bntExcluir);
            this.panel1.Controls.Add(this.bntNovo);
            this.panel1.Controls.Add(this.groupBoxRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 656);
            this.panel1.TabIndex = 0;
            // 
            // bntExcluir
            // 
            this.bntExcluir.ForeColor = System.Drawing.Color.Black;
            this.bntExcluir.Location = new System.Drawing.Point(242, 578);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(73, 47);
            this.bntExcluir.TabIndex = 15;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // dataSetServico
            // 
            this.dataSetServico.DataSetName = "DataSetServico";
            this.dataSetServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetServicoBindingSource
            // 
            this.dataSetServicoBindingSource.DataSource = this.dataSetServico;
            this.dataSetServicoBindingSource.Position = 0;
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "TbServico";
            this.tbServicoBindingSource.DataSource = this.dataSetServicoBindingSource;
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tbServicoBindingSource1
            // 
            this.tbServicoBindingSource1.DataMember = "TbServico";
            this.tbServicoBindingSource1.DataSource = this.dataSetServicoBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirCompletoToolStripMenuItem,
            this.exibirNormalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // exibirCompletoToolStripMenuItem
            // 
            this.exibirCompletoToolStripMenuItem.Name = "exibirCompletoToolStripMenuItem";
            this.exibirCompletoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exibirCompletoToolStripMenuItem.Text = "Exibir Completo";
            // 
            // exibirNormalToolStripMenuItem
            // 
            this.exibirNormalToolStripMenuItem.Name = "exibirNormalToolStripMenuItem";
            this.exibirNormalToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exibirNormalToolStripMenuItem.Text = "Exibir Normal";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSLAVA JATO V1.0 ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.BindingSource bindingSource;
        private DataSet dataSet;
        private DataSetTableAdapters.TbNumOsTableAdapter tbNumOsTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.MaskedTextBox mskHrSaida;
        private System.Windows.Forms.MaskedTextBox mskContato;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.MaskedTextBox mskHrEntrada;
        private System.Windows.Forms.MaskedTextBox mskDtSaida;
        private System.Windows.Forms.MaskedTextBox mskDtEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblVRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtAnotacao;
        private System.Windows.Forms.Label lblAnotacao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNomeClien;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblAtendente;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntAtualizar;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.CheckBox ChkPago;
        private System.Windows.Forms.CheckBox ChkReceber;
        private System.Windows.Forms.CheckBox ChkFinalizado;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.BindingSource dataSetServicoBindingSource;
        private DataSetServico dataSetServico;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
        private DataSetServicoTableAdapters.TbServicoTableAdapter tbServicoTableAdapter;
        private System.Windows.Forms.BindingSource tbServicoBindingSource1;
        private System.Windows.Forms.ComboBox cboValor;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomatendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicodescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusosDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboAtendente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirNormalToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboEndereco;
        private System.Windows.Forms.ComboBox cboContato;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.ComboBox cboPlaca;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem salvarFotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeFotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeOrdemServiçoToolStripMenuItem;
    }
}

