using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void progressbar_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ttmsProgressBar.Value = startpoint;
            if(ttmsProgressBar.Value == 100)
            {
                ttmsProgressBar.Value = 0;
                progressbar.Stop();
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            progressbar.Start();
        }
    }
}
