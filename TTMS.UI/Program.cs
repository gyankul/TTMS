using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI.Forms;
using TTMS.UI.Forms.Credentials;
using TTMS.UI.Forms.Driver___Vehicle;
using TTMS.UI.Forms.Payments;
using TTMS.UI.Forms.Tours;
using TTMS.UI.Forms.Travels;
using TTMS.UI.Forms.Vehicle___Driver;
using TTMS.UI.Tours;

namespace TTMS.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTourPackages());
            
        }
    }
}
