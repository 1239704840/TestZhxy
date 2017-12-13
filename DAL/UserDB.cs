using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserDB
    {
        public bool add(Common.User user)
        {
            string setting = "Data Source=.;Initial Catalog=Day01;User ID=sa;Password=root";

            SqlConnection myconn = new SqlConnection(setting);

            myconn.Open();

            SqlCommand cmd = new SqlCommand("insert into dbo.[user]([username],[password]) values(@name,@password)", myconn);

            cmd.Parameters.AddWithValue("@name", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)

                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                string error = e.Message + "\n\r" + e.Source + "\n\r" + e.StackTrace;
                return false;
            }
        }
    }
}
