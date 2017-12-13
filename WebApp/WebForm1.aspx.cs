using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Common;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void allow_Click(object sender, EventArgs e)
        {
            //    if ((labuser.Text == "") || (labpwd.Text == ""))
            //    {
            //        Label3.Text = "用户名与密码不能为空!";


            //    }
            //    else
            //    {
            //        SqlConnection con = DB.CreateConnection();
            //        con.Open();
            //        string strSql = "select * from user where username='" + labuser.Text + "'";
            //        SqlCommand cmd = new SqlCommand(strSql, con);
            //        DataSet ds = new DataSet();
            //        SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            //        da.Fill(ds);
            //        try
            //        {
            //            if (labpwd.Text == ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim())
            //            {
            //                string curuser = labuser.Text;
            //                Label3.Text = "登录成功,欢迎你!";
            //            }
            //            else
            //            {
            //                Label3.Text = "用户名或者密码错误!";
            //            }
            //        }
            //        catch
            //        {
            //            Label3.Text = "Sorry!你输入的用户名不存在!";

            //        }
            //        con.Close();
            //    }
        }

        protected void abov_Click(object sender, EventArgs e)
        {
            if ((labuser.Text == "") || (labpwd.Text == ""))
            {
                Label3.Text = "用户名为或密码不能为空";
            }
            else
            {
                try
                {
                    UserBLL userbll = new UserBLL();
                    User user = new User(labuser.Text,labpwd.Text);
                    if(userbll.AddUser(user))
                    {
                        Label3.Text = "成功";
                    }
                    //SqlConnection con = DB.CreateConnection();
                    //con.Open();
                    //string strsql = "insert  into user(username,password) values('" + labuser.Text + "','" + labpwd.Text + "')";
                    //SqlCommand cmd = new SqlCommand(strsql, con);
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                    //labuser.Text = "";
                    //labpwd.Text = "";
                    //Label3.Text = "注册成功!欢迎登录!";
                }
                catch
                {
                    Label3.Text = "用户名已存在!";
                }
            }
        }
    }
}