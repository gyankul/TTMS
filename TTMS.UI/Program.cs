﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI.Forms;
using TTMS.UI.Forms.Credentials;
using TTMS.UI.Forms.Tours;
using TTMS.UI.Forms.Travels;
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
            Application.Run(new frmTravelDetails());
            
        }
    }
}
