using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void allow_Click(object sender, EventArgs e)
        {
            User user = new User(labuser.Text, labpwd.Text);
            UserBLL userbll = new UserBLL();
            if (userbll.SelectUser(user))
            {
                Label3.Text = "登陆成功";
                Session["UserName"] = labuser.Text;
                Response.Redirect(@"index.aspx");
            }
            else
            {
                Label3.Text = "登陆失败";
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            int a = 0;
        }
    }
}