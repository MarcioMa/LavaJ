
namespace LavaJ
{
    partial class FrmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TbNumOsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new LavaJ.DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TbNumOsTableAdapter = new LavaJ.DataSetTableAdapters.TbNumOsTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetCliente = new LavaJ.DataSetCliente();
            this.TbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TbClienteTableAdapter = new LavaJ.DataSetClienteTableAdapters.TbClienteTableAdapter();
            this.dataSetFoto = new LavaJ.DataSetFoto();
            this.tbFotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFotoTableAdapter = new LavaJ.DataSetFotoTableAdapters.TbFotoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TbNumOsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFotoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TbNumOsBindingSource
            // 
            this.TbNumOsBindingSource.DataMember = "TbNumOs";
            this.TbNumOsBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "OrdemServico";
            reportDataSource1.Value = this.TbNumOsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LavaJ.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(242, 45);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // TbNumOsTableAdapter
            // 
            this.TbNumOsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSetCliente";
            reportDataSource2.Value = this.TbClienteBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "LavaJ.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(25, 207);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSetFoto";
            reportDataSource3.Value = this.tbFotoBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "LavaJ.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(452, 207);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(396, 246);
            this.reportViewer3.TabIndex = 1;
            // 
            // DataSetCliente
            // 
            this.DataSetCliente.DataSetName = "DataSetCliente";
            this.DataSetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbClienteBindingSource
            // 
            this.TbClienteBindingSource.DataMember = "TbCliente";
            this.TbClienteBindingSource.DataSource = this.DataSetCliente;
            // 
            // TbClienteTableAdapter
            // 
            this.TbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetFoto
            // 
            this.dataSetFoto.DataSetName = "DataSetFoto";
            this.dataSetFoto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFotoTableAdapter
            // 
            this.tbFotoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 692);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatorio Serviços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbNumOsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFotoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TbNumOsBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.TbNumOsTableAdapter TbNumOsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource TbClienteBindingSource;
        private DataSetCliente DataSetCliente;
        private DataSetClienteTableAdapters.TbClienteTableAdapter TbClienteTableAdapter;
        private DataSetFoto dataSetFoto;
        private System.Windows.Forms.BindingSource tbFotoBindingSource;
        private DataSetFotoTableAdapters.TbFotoTableAdapter tbFotoTableAdapter;
    }
}