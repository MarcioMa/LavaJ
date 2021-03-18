
namespace LavaJ
{
    partial class FrmManutencao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxOS = new System.Windows.Forms.CheckBox();
            this.checkBoxFoto = new System.Windows.Forms.CheckBox();
            this.checkBoxServico = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.checkBoxAtendente = new System.Windows.Forms.CheckBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.buttonReoganizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxOS);
            this.groupBox1.Controls.Add(this.checkBoxFoto);
            this.groupBox1.Controls.Add(this.checkBoxServico);
            this.groupBox1.Controls.Add(this.checkBoxCliente);
            this.groupBox1.Controls.Add(this.checkBoxAtendente);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(273, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabelas do Sistema";
            // 
            // checkBoxOS
            // 
            this.checkBoxOS.AutoSize = true;
            this.checkBoxOS.Location = new System.Drawing.Point(19, 38);
            this.checkBoxOS.Name = "checkBoxOS";
            this.checkBoxOS.Size = new System.Drawing.Size(223, 24);
            this.checkBoxOS.TabIndex = 1;
            this.checkBoxOS.Text = "Cadastro de Ordem Serviço";
            this.checkBoxOS.UseVisualStyleBackColor = true;
            this.checkBoxOS.CheckedChanged += new System.EventHandler(this.checkBoxOS_CheckedChanged);
            // 
            // checkBoxFoto
            // 
            this.checkBoxFoto.AutoSize = true;
            this.checkBoxFoto.Location = new System.Drawing.Point(19, 158);
            this.checkBoxFoto.Name = "checkBoxFoto";
            this.checkBoxFoto.Size = new System.Drawing.Size(160, 24);
            this.checkBoxFoto.TabIndex = 5;
            this.checkBoxFoto.Text = "Cadastro de Fotos";
            this.checkBoxFoto.UseVisualStyleBackColor = true;
            this.checkBoxFoto.CheckedChanged += new System.EventHandler(this.checkBoxFoto_CheckedChanged);
            // 
            // checkBoxServico
            // 
            this.checkBoxServico.AutoSize = true;
            this.checkBoxServico.Location = new System.Drawing.Point(19, 128);
            this.checkBoxServico.Name = "checkBoxServico";
            this.checkBoxServico.Size = new System.Drawing.Size(179, 24);
            this.checkBoxServico.TabIndex = 4;
            this.checkBoxServico.Text = "Cadastro de Serviços";
            this.checkBoxServico.UseVisualStyleBackColor = true;
            this.checkBoxServico.CheckedChanged += new System.EventHandler(this.checkBoxServico_CheckedChanged);
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Location = new System.Drawing.Point(19, 98);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(176, 24);
            this.checkBoxCliente.TabIndex = 3;
            this.checkBoxCliente.Text = "Cadastro de Clientes";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            this.checkBoxCliente.CheckedChanged += new System.EventHandler(this.checkBoxCliente_CheckedChanged);
            // 
            // checkBoxAtendente
            // 
            this.checkBoxAtendente.AutoSize = true;
            this.checkBoxAtendente.Location = new System.Drawing.Point(19, 68);
            this.checkBoxAtendente.Name = "checkBoxAtendente";
            this.checkBoxAtendente.Size = new System.Drawing.Size(194, 24);
            this.checkBoxAtendente.TabIndex = 2;
            this.checkBoxAtendente.Text = "Cadastro de Atendente";
            this.checkBoxAtendente.UseVisualStyleBackColor = true;
            this.checkBoxAtendente.CheckedChanged += new System.EventHandler(this.checkBoxAtendente_CheckedChanged);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(300, 152);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(119, 53);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Enabled = false;
            this.buttonReiniciar.Location = new System.Drawing.Point(300, 88);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(119, 53);
            this.buttonReiniciar.TabIndex = 7;
            this.buttonReiniciar.Text = "Limpar Registros";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // buttonReoganizar
            // 
            this.buttonReoganizar.Enabled = false;
            this.buttonReoganizar.Location = new System.Drawing.Point(300, 22);
            this.buttonReoganizar.Name = "buttonReoganizar";
            this.buttonReoganizar.Size = new System.Drawing.Size(119, 53);
            this.buttonReoganizar.TabIndex = 6;
            this.buttonReoganizar.Text = "Reorganizar IDs";
            this.buttonReoganizar.UseVisualStyleBackColor = true;
            this.buttonReoganizar.Click += new System.EventHandler(this.buttonReoganizar_Click);
            // 
            // FrmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 223);
            this.Controls.Add(this.buttonReoganizar);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManutencao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Tabelas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFoto;
        private System.Windows.Forms.CheckBox checkBoxServico;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.CheckBox checkBoxAtendente;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.Button buttonReoganizar;
        private System.Windows.Forms.CheckBox checkBoxOS;
    }
}