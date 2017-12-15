using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class UserDB
    {
        User user = new User();
        public bool add(User user)
        {//数据库连接类（连接字符串）
            string setting = "Data Source=.;Initial Catalog=Day01;User ID=sa;Password=root";

            SqlConnection myconn = new SqlConnection(setting);
            //打开数据库
            myconn.Open();
            //查询语句
            SqlCommand cmd = new SqlCommand("insert into dbo.[user]([username],[password]) values(@name,@password)", myconn);

            cmd.Parameters.AddWithValue("@name", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            //执行查询语句
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
        public bool seek(User user)
        {
            bool result=false;
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Day01;User ID=sa;Password=root");
            SqlCommand cmd = conn.CreateCommand();
                      cmd.CommandText = "SELECT   [user].* FROM[user] where (username = '"+user.Username+"') AND (password = '"+user.Password+"')";
            conn.Open();
               SqlDataReader dr = cmd.ExecuteReader();
            //每次执行一次这个方法，指针就 向下走一行，读取下面一行的数据，如果下面没有数据，那么就会返回false
            //while (dr.Read())
            //{
            //    user.Username = dr["username"].ToString();
            //    user.Password = dr["password"].ToString();
            //    list.Add(user);
            //}

            if(dr.HasRows)
            {
                result=true;
                       }
            conn.Close();//数据库连接关闭
            return result;
        }
    }
}
