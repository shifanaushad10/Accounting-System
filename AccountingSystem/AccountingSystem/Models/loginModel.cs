using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace AccountingSystem.Models
{
    public class loginModel
    {

        public DataTable UserLogin(string name, string passw)
        {
            DataTable dt = new DataTable();

            string strConString = @"Data Source=LAPTOP-9A7OI3UK;Initial Catalog=accountingSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Admin where Username='" + name + "' and PasswordHash ='" + passw + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }
}