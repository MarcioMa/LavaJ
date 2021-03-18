
namespace LavaJ
{
    partial class FrmBackup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.bntConectar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBackup = new System.Windows.Forms.GroupBox();
            this.textBoxBackup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSelecionarBk = new System.Windows.Forms.Button();
            this.bntBackup = new System.Windows.Forms.Button();
            this.groupRestore = new System.Windows.Forms.GroupBox();
            this.textBoxRestore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntSelecionarRest = new System.Windows.Forms.Button();
            this.bntRestore = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBackup.SuspendLayout();
            this.groupRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxDatabase);
            this.groupBox1.Controls.Add(this.textBoxServerName);
            this.groupBox1.Controls.Add(this.bntConectar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database:";
            // 
            // ComboBoxDatabase
            // 
            this.ComboBoxDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDatabase.Enabled = false;
            this.ComboBoxDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDatabase.FormattingEnabled = true;
            this.ComboBoxDatabase.Items.AddRange(new object[] {
            "Selecione..."});
            this.ComboBoxDatabase.Location = new System.Drawing.Point(10, 130);
            this.ComboBoxDatabase.Name = "ComboBoxDatabase";
            this.ComboBoxDatabase.Size = new System.Drawing.Size(447, 28);
            this.ComboBoxDatabase.TabIndex = 6;
            this.ComboBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDatabase_SelectedIndexChanged);
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(10, 68);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.ReadOnly = true;
            this.textBoxServerName.Size = new System.Drawing.Size(447, 26);
            this.textBoxServerName.TabIndex = 11;
            // 
            // bntConectar
            // 
            this.bntConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConectar.Location = new System.Drawing.Point(478, 66);
            this.bntConectar.Name = "bntConectar";
            this.bntConectar.Size = new System.Drawing.Size(109, 28);
            this.bntConectar.TabIndex = 9;
            this.bntConectar.Text = "Conectar";
            this.bntConectar.UseVisualStyleBackColor = true;
            this.bntConectar.Click += new System.EventHandler(this.bntConectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server Name";
            // 
            // groupBackup
            // 
            this.groupBackup.Controls.Add(this.textBoxBackup);
            this.groupBackup.Controls.Add(this.label2);
            this.groupBackup.Controls.Add(this.bntSelecionarBk);
            this.groupBackup.Controls.Add(this.bntBackup);
            this.groupBackup.Enabled = false;
            this.groupBackup.Location = new System.Drawing.Point(20, 197);
            this.groupBackup.Name = "groupBackup";
            this.groupBackup.Size = new System.Drawing.Size(613, 126);
            this.groupBackup.TabIndex = 0;
            this.groupBackup.TabStop = false;
            this.groupBackup.Text = "Database Backup";
            // 
            // textBoxBackup
            // 
            this.textBoxBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBackup.Location = new System.Drawing.Point(10, 45);
            this.textBoxBackup.Name = "textBoxBackup";
            this.textBoxBackup.Size = new System.Drawing.Size(447, 29);
            this.textBoxBackup.TabIndex = 15;
            this.textBoxBackup.TextChanged += new System.EventHandler(this.textBoxBackup_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Local:";
            // 
            // bntSelecionarBk
            // 
            this.bntSelecionarBk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSelecionarBk.Location = new System.Drawing.Point(478, 45);
            this.bntSelecionarBk.Name = "bntSelecionarBk";
            this.bntSelecionarBk.Size = new System.Drawing.Size(109, 29);
            this.bntSelecionarBk.TabIndex = 14;
            this.bntSelecionarBk.Text = "Selecionar...";
            this.bntSelecionarBk.UseVisualStyleBackColor = true;
            this.bntSelecionarBk.Click += new System.EventHandler(this.bntSelecionarBk_Click);
            // 
            // bntBackup
            // 
            this.bntBackup.Enabled = false;
            this.bntBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBackup.Location = new System.Drawing.Point(478, 80);
            this.bntBackup.Name = "bntBackup";
            this.bntBackup.Size = new System.Drawing.Size(109, 29);
            this.bntBackup.TabIndex = 14;
            this.bntBackup.Text = "Backup";
            this.bntBackup.UseVisualStyleBackColor = true;
            this.bntBackup.Click += new System.EventHandler(this.bntBackup_Click);
            // 
            // groupRestore
            // 
            this.groupRestore.Controls.Add(this.textBoxRestore);
            this.groupRestore.Controls.Add(this.label3);
            this.groupRestore.Controls.Add(this.bntSelecionarRest);
            this.groupRestore.Controls.Add(this.bntRestore);
            this.groupRestore.Enabled = false;
            this.groupRestore.Location = new System.Drawing.Point(20, 326);
            this.groupRestore.Name = "groupRestore";
            this.groupRestore.Size = new System.Drawing.Size(613, 127);
            this.groupRestore.TabIndex = 0;
            this.groupRestore.TabStop = false;
            this.groupRestore.Text = "Database Restore";
            // 
            // textBoxRestore
            // 
            this.textBoxRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestore.Location = new System.Drawing.Point(10, 45);
            this.textBoxRestore.Name = "textBoxRestore";
            this.textBoxRestore.Size = new System.Drawing.Size(447, 29);
            this.textBoxRestore.TabIndex = 15;
            this.textBoxRestore.TextChanged += new System.EventHandler(this.textBoxRestore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Local:";
            // 
            // bntSelecionarRest
            // 
            this.bntSelecionarRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSelecionarRest.Location = new System.Drawing.Point(478, 45);
            this.bntSelecionarRest.Name = "bntSelecionarRest";
            this.bntSelecionarRest.Size = new System.Drawing.Size(109, 29);
            this.bntSelecionarRest.TabIndex = 14;
            this.bntSelecionarRest.Text = "Selecionar...";
            this.bntSelecionarRest.UseVisualStyleBackColor = true;
            this.bntSelecionarRest.Click += new System.EventHandler(this.bntSelecionarRest_Click);
            // 
            // bntRestore
            // 
            this.bntRestore.Enabled = false;
            this.bntRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRestore.Location = new System.Drawing.Point(478, 80);
            this.bntRestore.Name = "bntRestore";
            this.bntRestore.Size = new System.Drawing.Size(109, 29);
            this.bntRestore.TabIndex = 14;
            this.bntRestore.Text = "Restore";
            this.bntRestore.UseVisualStyleBackColor = true;
            this.bntRestore.Click += new System.EventHandler(this.bntRestore_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"SQL file (.bak)| Todos( *.*)\"";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.InitialDirectory = "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 463);
            this.Controls.Add(this.groupRestore);
            this.Controls.Add(this.groupBackup);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta DB";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBackup.ResumeLayout(false);
            this.groupBackup.PerformLayout();
            this.groupRestore.ResumeLayout(false);
            this.groupRestore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxDatabase;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntConectar;
        private System.Windows.Forms.GroupBox groupBackup;
        private System.Windows.Forms.TextBox textBoxBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntBackup;
        private System.Windows.Forms.Button bntSelecionarBk;
        private System.Windows.Forms.GroupBox groupRestore;
        private System.Windows.Forms.TextBox textBoxRestore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntSelecionarRest;
        private System.Windows.Forms.Button bntRestore;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}