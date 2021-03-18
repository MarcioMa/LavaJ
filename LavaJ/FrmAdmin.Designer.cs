namespace LavaJ
{
    partial class FrmAdmin
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BntFechar = new System.Windows.Forms.Button();
            this.BntReiniciar = new System.Windows.Forms.Button();
            this.bntNovo = new System.Windows.Forms.Button();
            this.BntSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDAdmin = new System.Windows.Forms.TextBox();
            this.dataSetAdmin = new LavaJ.DataSetAdmin();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkViewUser = new System.Windows.Forms.CheckBox();
            this.chkViewAdmin = new System.Windows.Forms.CheckBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAdminTableAdapter = new LavaJ.DataSetAdminTableAdapters.TbAdminTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAdmin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BntFechar);
            this.groupBox2.Controls.Add(this.BntReiniciar);
            this.groupBox2.Controls.Add(this.bntNovo);
            this.groupBox2.Controls.Add(this.BntSalva);
            this.groupBox2.Location = new System.Drawing.Point(471, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(148, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BntFechar
            // 
            this.BntFechar.Location = new System.Drawing.Point(12, 184);
            this.BntFechar.Name = "BntFechar";
            this.BntFechar.Size = new System.Drawing.Size(121, 50);
            this.BntFechar.TabIndex = 10;
            this.BntFechar.Text = "Fechar";
            this.BntFechar.UseVisualStyleBackColor = true;
            this.BntFechar.Click += new System.EventHandler(this.BntFechar_Click);
            // 
            // BntReiniciar
            // 
            this.BntReiniciar.Location = new System.Drawing.Point(12, 128);
            this.BntReiniciar.Name = "BntReiniciar";
            this.BntReiniciar.Size = new System.Drawing.Size(121, 50);
            this.BntReiniciar.TabIndex = 9;
            this.BntReiniciar.Text = "Reiniciar";
            this.BntReiniciar.UseVisualStyleBackColor = true;
            this.BntReiniciar.Click += new System.EventHandler(this.BntReiniciar_Click);
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(12, 21);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(121, 48);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // BntSalva
            // 
            this.BntSalva.Enabled = false;
            this.BntSalva.Location = new System.Drawing.Point(12, 75);
            this.BntSalva.Name = "BntSalva";
            this.BntSalva.Size = new System.Drawing.Size(121, 48);
            this.BntSalva.TabIndex = 8;
            this.BntSalva.Text = "Salvar";
            this.BntSalva.UseVisualStyleBackColor = true;
            this.BntSalva.Click += new System.EventHandler(this.BntSalva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtIDAdmin
            // 
            this.txtIDAdmin.BackColor = System.Drawing.Color.White;
            this.txtIDAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetAdmin, "TbAdmin.Id", true));
            this.txtIDAdmin.Location = new System.Drawing.Point(13, 32);
            this.txtIDAdmin.Name = "txtIDAdmin";
            this.txtIDAdmin.ReadOnly = true;
            this.txtIDAdmin.Size = new System.Drawing.Size(65, 26);
            this.txtIDAdmin.TabIndex = 1;
            // 
            // dataSetAdmin
            // 
            this.dataSetAdmin.DataSetName = "DataSetAdmin";
            this.dataSetAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrador";
            // 
            // txtAdmin
            // 
            this.txtAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetAdmin, "TbAdmin.admin", true));
            this.txtAdmin.Location = new System.Drawing.Point(13, 85);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(195, 26);
            this.txtAdmin.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkViewUser);
            this.groupBox1.Controls.Add(this.chkViewAdmin);
            this.groupBox1.Controls.Add(this.txtSenhaUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSenhaAdmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAdmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDAdmin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(451, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // chkViewUser
            // 
            this.chkViewUser.AutoSize = true;
            this.chkViewUser.Location = new System.Drawing.Point(227, 174);
            this.chkViewUser.Name = "chkViewUser";
            this.chkViewUser.Size = new System.Drawing.Size(125, 24);
            this.chkViewUser.TabIndex = 7;
            this.chkViewUser.Text = "Mostra senha";
            this.chkViewUser.UseVisualStyleBackColor = true;
            this.chkViewUser.CheckedChanged += new System.EventHandler(this.chkViewUser_CheckedChanged);
            // 
            // chkViewAdmin
            // 
            this.chkViewAdmin.AutoSize = true;
            this.chkViewAdmin.Location = new System.Drawing.Point(13, 174);
            this.chkViewAdmin.Name = "chkViewAdmin";
            this.chkViewAdmin.Size = new System.Drawing.Size(125, 24);
            this.chkViewAdmin.TabIndex = 4;
            this.chkViewAdmin.Text = "Mostra senha";
            this.chkViewAdmin.UseVisualStyleBackColor = true;
            this.chkViewAdmin.CheckedChanged += new System.EventHandler(this.chkViewAdmin_CheckedChanged);
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetAdmin, "TbAdmin.senhaOp", true));
            this.txtSenhaUser.Location = new System.Drawing.Point(227, 142);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.PasswordChar = '*';
            this.txtSenhaUser.Size = new System.Drawing.Size(195, 26);
            this.txtSenhaUser.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha Operador";
            // 
            // txtSenhaAdmin
            // 
            this.txtSenhaAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetAdmin, "TbAdmin.senhaAd", true));
            this.txtSenhaAdmin.Location = new System.Drawing.Point(13, 142);
            this.txtSenhaAdmin.Name = "txtSenhaAdmin";
            this.txtSenhaAdmin.PasswordChar = '*';
            this.txtSenhaAdmin.Size = new System.Drawing.Size(195, 26);
            this.txtSenhaAdmin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha Administrador";
            // 
            // txtUser
            // 
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetAdmin, "TbAdmin.Operador", true));
            this.txtUser.Location = new System.Drawing.Point(227, 85);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(195, 26);
            this.txtUser.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Operador";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "TbAdmin";
            this.bindingSource.DataSource = this.dataSetAdmin;
            // 
            // tbAdminTableAdapter
            // 
            this.tbAdminTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAdmin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BntFechar;
        private System.Windows.Forms.Button BntReiniciar;
        private System.Windows.Forms.Button BntSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkViewUser;
        private System.Windows.Forms.CheckBox chkViewAdmin;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntNovo;
        private DataSetAdmin dataSetAdmin;
        private System.Windows.Forms.BindingSource bindingSource;
        private DataSetAdminTableAdapters.TbAdminTableAdapter tbAdminTableAdapter;
    }
}