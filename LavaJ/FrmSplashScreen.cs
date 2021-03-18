using System;
using System.Windows.Forms;

namespace LavaJ
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 20;
            }
            if (progressBar1.Value == 100)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
