namespace LavaJ
{
    partial class FrmCadServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetServico = new LavaJ.DataSetServico();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BntFecharServ = new System.Windows.Forms.Button();
            this.BntExcluirServ = new System.Windows.Forms.Button();
            this.BntSalvaServ = new System.Windows.Forms.Button();
            this.BntNovoServ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorServ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDServ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServicoTableAdapter = new LavaJ.DataSetServicoTableAdapters.TbServicoTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.servicoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tbServicoBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 272);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(748, 186);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50.43655F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.FillWeight = 80.30145F;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor R$";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // servicoDataGridViewTextBoxColumn
            // 
            this.servicoDataGridViewTextBoxColumn.DataPropertyName = "servico";
            this.servicoDataGridViewTextBoxColumn.FillWeight = 180.6373F;
            this.servicoDataGridViewTextBoxColumn.HeaderText = "Serviços";
            this.servicoDataGridViewTextBoxColumn.Name = "servicoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.FillWeight = 219.6247F;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "TbServico";
            this.tbServicoBindingSource.DataSource = this.dataSetServico;
            // 
            // dataSetServico
            // 
            this.dataSetServico.DataSetName = "DataSetServico";
            this.dataSetServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BntFecharServ);
            this.groupBox2.Controls.Add(this.BntExcluirServ);
            this.groupBox2.Controls.Add(this.BntSalvaServ);
            this.groupBox2.Controls.Add(this.BntNovoServ);
            this.groupBox2.Location = new System.Drawing.Point(585, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(148, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BntFecharServ
            // 
            this.BntFecharServ.Location = new System.Drawing.Point(12, 185);
            this.BntFecharServ.Name = "BntFecharServ";
            this.BntFecharServ.Size = new System.Drawing.Size(121, 50);
            this.BntFecharServ.TabIndex = 7;
            this.BntFecharServ.Text = "Fechar";
            this.BntFecharServ.UseVisualStyleBackColor = true;
            this.BntFecharServ.Click += new System.EventHandler(this.BntFecharServ_Click);
            // 
            // BntExcluirServ
            // 
            this.BntExcluirServ.Location = new System.Drawing.Point(12, 129);
            this.BntExcluirServ.Name = "BntExcluirServ";
            this.BntExcluirServ.Size = new System.Drawing.Size(121, 50);
            this.BntExcluirServ.TabIndex = 6;
            this.BntExcluirServ.Text = "Excluir";
            this.BntExcluirServ.UseVisualStyleBackColor = true;
            this.BntExcluirServ.Click += new System.EventHandler(this.BntExcluirServ_Click);
            // 
            // BntSalvaServ
            // 
            this.BntSalvaServ.Enabled = false;
            this.BntSalvaServ.Location = new System.Drawing.Point(12, 75);
            this.BntSalvaServ.Name = "BntSalvaServ";
            this.BntSalvaServ.Size = new System.Drawing.Size(121, 48);
            this.BntSalvaServ.TabIndex = 5;
            this.BntSalvaServ.Text = "Salvar";
            this.BntSalvaServ.UseVisualStyleBackColor = true;
            this.BntSalvaServ.Click += new System.EventHandler(this.BntSalvaServ_Click);
            // 
            // BntNovoServ
            // 
            this.BntNovoServ.Location = new System.Drawing.Point(12, 20);
            this.BntNovoServ.Name = "BntNovoServ";
            this.BntNovoServ.Size = new System.Drawing.Size(121, 49);
            this.BntNovoServ.TabIndex = 1;
            this.BntNovoServ.Text = "Novo";
            this.BntNovoServ.UseVisualStyleBackColor = true;
            this.BntNovoServ.Click += new System.EventHandler(this.BntNovoServ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorServ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDServ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(566, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtValorServ
            // 
            this.txtValorServ.Location = new System.Drawing.Point(13, 100);
            this.txtValorServ.Name = "txtValorServ";
            this.txtValorServ.Size = new System.Drawing.Size(97, 26);
            this.txtValorServ.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor R$";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 206);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(486, 26);
            this.txtDescricao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição / Produtos";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(13, 153);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(288, 26);
            this.txtServico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serviço";
            // 
            // txtIDServ
            // 
            this.txtIDServ.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDServ.Location = new System.Drawing.Point(13, 47);
            this.txtIDServ.Name = "txtIDServ";
            this.txtIDServ.ReadOnly = true;
            this.txtIDServ.Size = new System.Drawing.Size(65, 26);
            this.txtIDServ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirCompletoToolStripMenuItem,
            this.exibirNormalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // exibirCompletoToolStripMenuItem
            // 
            this.exibirCompletoToolStripMenuItem.Name = "exibirCompletoToolStripMenuItem";
            this.exibirCompletoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirCompletoToolStripMenuItem.Text = "Exibir Completo";
            this.exibirCompletoToolStripMenuItem.Click += new System.EventHandler(this.exibirCompletoToolStripMenuItem_Click_1);
            // 
            // exibirNormalToolStripMenuItem
            // 
            this.exibirNormalToolStripMenuItem.Name = "exibirNormalToolStripMenuItem";
            this.exibirNormalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirNormalToolStripMenuItem.Text = "Exibir Normal";
            this.exibirNormalToolStripMenuItem.Click += new System.EventHandler(this.exibirNormalToolStripMenuItem_Click);
            // 
            // FrmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 458);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Serviço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadServico_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BntFecharServ;
        private System.Windows.Forms.Button BntExcluirServ;
        private System.Windows.Forms.Button BntSalvaServ;
        private System.Windows.Forms.Button BntNovoServ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorServ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDServ;
        private System.Windows.Forms.Label label1;
        private DataSetServico dataSetServico;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
        private DataSetServicoTableAdapters.TbServicoTableAdapter tbServicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirNormalToolStripMenuItem;
    }
}