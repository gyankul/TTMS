﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI
{
    public partial class formTravelBooking : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;

        DataSet ds = new DataSet();
        public formTravelBooking()
        {
            InitializeComponent();
        }

        private void TravelBooking_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";
        }


        private void cbTravels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = cbTravels.SelectedItem.ToString();
            if (SelectedItem == "Sitting")
            {
                layoutSittingbus sit = new layoutSittingbus();
                sit.TopLevel = false;
                panelVehicleLayout.Controls.Add(sit);
                sit.BringToFront();
                sit.Show();
            }
            else
            {
                layoutSleeperbus sleep = new layoutSleeperbus();
                sleep.TopLevel = false;
                panelVehicleLayout.Controls.Add(sleep);
                sleep.BringToFront();
                sleep.Show();
            }
        }
    }
}
