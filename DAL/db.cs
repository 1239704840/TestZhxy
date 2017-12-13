using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DB
    {
        public DB()
        {
            //构造函数
        }
        public static SqlConnection CreateConnection()
        {
                 SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-MNLIV1N;database=Day01;Trusted_Connection=SSPI";//windows身份验证
        //     public static string ConnString = @"Server=DESKTOP-MNLIV1N;Database=Day01;User ID=sa; Password=root"; SQL server身份验证
            return con;
            //  con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "select * from User";
            //SqlDataReader sdr = cmd.ExecuteReader();
            //this.datagridview1.datasource = sdr;
            //this.datagridview1.databind();
            //sdr.close();
            //con.close();
        }
    }
}
