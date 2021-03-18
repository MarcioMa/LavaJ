
namespace LavaJ
{
    partial class FrmFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFoto));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.buttonAbrirTodo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAbrirPlaca = new System.Windows.Forms.Button();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa do veículo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.comboBoxPlaca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAbrirTodo);
            this.groupBox1.Controls.Add(this.buttonAbrirPlaca);
            this.groupBox1.Location = new System.Drawing.Point(386, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta ";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(227, 11);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(77, 29);
            this.textBoxCodigo.TabIndex = 8;
            this.textBoxCodigo.Visible = false;
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Items.AddRange(new object[] {
            "Selecione..."});
            this.comboBoxPlaca.Location = new System.Drawing.Point(11, 42);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(293, 32);
            this.comboBoxPlaca.TabIndex = 4;
            // 
            // buttonAbrirTodo
            // 
            this.buttonAbrirTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirTodo.ImageIndex = 3;
            this.buttonAbrirTodo.ImageList = this.imageList1;
            this.buttonAbrirTodo.Location = new System.Drawing.Point(11, 79);
            this.buttonAbrirTodo.Name = "buttonAbrirTodo";
            this.buttonAbrirTodo.Size = new System.Drawing.Size(134, 35);
            this.buttonAbrirTodo.TabIndex = 7;
            this.buttonAbrirTodo.Text = "Abrir Todos";
            this.buttonAbrirTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrirTodo.UseVisualStyleBackColor = true;
            this.buttonAbrirTodo.Click += new System.EventHandler(this.buttonAbrirTodo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save_file_disk_open_searsh_loading_clipboard_1513.png");
            this.imageList1.Images.SetKeyName(1, "save.png");
            this.imageList1.Images.SetKeyName(2, "folder_new.png");
            this.imageList1.Images.SetKeyName(3, "saveall.png");
            this.imageList1.Images.SetKeyName(4, "fotocarro.png");
            this.imageList1.Images.SetKeyName(5, "Trash Empty.png");
            // 
            // buttonAbrirPlaca
            // 
            this.buttonAbrirPlaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirPlaca.ImageIndex = 0;
            this.buttonAbrirPlaca.ImageList = this.imageList1;
            this.buttonAbrirPlaca.Location = new System.Drawing.Point(151, 80);
            this.buttonAbrirPlaca.Name = "buttonAbrirPlaca";
            this.buttonAbrirPlaca.Size = new System.Drawing.Size(153, 35);
            this.buttonAbrirPlaca.TabIndex = 7;
            this.buttonAbrirPlaca.Text = "Abrir por Placa";
            this.buttonAbrirPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbrirPlaca.UseVisualStyleBackColor = true;
            this.buttonAbrirPlaca.Click += new System.EventHandler(this.buttonAbrirPlaca_Click);
            // 
            // buttonCarregar
            // 
            this.buttonCarregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCarregar.ImageIndex = 4;
            this.buttonCarregar.ImageList = this.imageList1;
            this.buttonCarregar.Location = new System.Drawing.Point(10, 142);
            this.buttonCarregar.Name = "buttonCarregar";
            this.buttonCarregar.Size = new System.Drawing.Size(139, 53);
            this.buttonCarregar.TabIndex = 7;
            this.buttonCarregar.Text = "Mostrar Foto ";
            this.buttonCarregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCarregar.UseVisualStyleBackColor = true;
            this.buttonCarregar.Click += new System.EventHandler(this.buttonCarregar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(7, 9);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(370, 321);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxDescricao);
            this.groupBox2.Controls.Add(this.buttonSalvar);
            this.groupBox2.Controls.Add(this.buttonAbrir);
            this.groupBox2.Controls.Add(this.buttonExcluir);
            this.groupBox2.Controls.Add(this.buttonCarregar);
            this.groupBox2.Location = new System.Drawing.Point(387, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 201);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nova Foto ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(10, 45);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.ReadOnly = true;
            this.textBoxDescricao.Size = new System.Drawing.Size(293, 29);
            this.textBoxDescricao.TabIndex = 8;
            this.textBoxDescricao.TextChanged += new System.EventHandler(this.textBoxDescricao_TextChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvar.ImageIndex = 1;
            this.buttonSalvar.ImageList = this.imageList1;
            this.buttonSalvar.Location = new System.Drawing.Point(165, 80);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(138, 53);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAbrir.ImageIndex = 2;
            this.buttonAbrir.ImageList = this.imageList1;
            this.buttonAbrir.Location = new System.Drawing.Point(10, 80);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(139, 53);
            this.buttonAbrir.TabIndex = 7;
            this.buttonAbrir.Text = "Carregar...";
            this.buttonAbrir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluir.ImageIndex = 5;
            this.buttonExcluir.ImageList = this.imageList1;
            this.buttonExcluir.Location = new System.Drawing.Point(165, 142);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(138, 53);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.Text = "Excluir Foto ";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 338);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(706, 219);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.FileName = "Images";
            this.openFileDialog1.Filter = "Images (*.JPG;*.JPEG,*.PNG,*.TIFF)|*.JPG;*.JPEG;*.PNG;*.TIFF|\" + \"All files (*.*)" +
    "|*.*";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FrmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 557);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFoto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto Arquivo";
            this.Load += new System.EventHandler(this.FrmFoto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.Button buttonCarregar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button buttonAbrirPlaca;
        private System.Windows.Forms.Button buttonAbrirTodo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonExcluir;
    }
}