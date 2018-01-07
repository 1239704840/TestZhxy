using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                    User user = new User(labuser.Text, labpwd.Text);
                    if (userbll.AddUser(user))
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