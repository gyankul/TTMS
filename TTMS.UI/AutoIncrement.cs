using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTMS.UI
{
    class AutoIncrement
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlDataReader dr;

        public AutoIncrement()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";
            con.Open();
            cmd.Connection = con;
        }

        public void increment(string query)
        {
            con.Close();
            con.Open();
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
        }
    }
}
