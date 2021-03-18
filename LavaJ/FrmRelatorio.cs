using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LavaJ
{
    public partial class FrmRelatorio : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\dbLavaJato\\DBLavaJato.mdf;Integrated Security=True;Connect Timeout=30");

        FrmMain frmMain { get; set; }
        public FrmRelatorio(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            VTipoRelatorio();
            if (reportViewer1.Visible == true)
            {
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.reportViewer1.RefreshReport();
            }
            else if (reportViewer2.Visible == true)
            {
                reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.reportViewer2.RefreshReport();
            }
            else
            {
                reportViewer3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer3.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.reportViewer3.RefreshReport();
            }

        }

        private void VTipoRelatorio() 
        { 
            if (frmMain.TipoRelatorio == 1)
	        {
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer1.Dock = DockStyle.Fill;
                this.TbNumOsTableAdapter.Fill(this.DataSet.TbNumOs);
            }
            else if (frmMain.TipoRelatorio == 2)
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = true;
                reportViewer3.Visible = false;
                reportViewer2.Dock = DockStyle.Fill;
                this.TbClienteTableAdapter.Fill(this.DataSetCliente.TbCliente);
                this.reportViewer2.RefreshReport();
            }
            else
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = true;
                reportViewer3.Dock = DockStyle.Fill;
                this.tbFotoTableAdapter.Fill(this.dataSetFoto.TbFoto);
                this.reportViewer3.RefreshReport();
            }
        }
    }
}
