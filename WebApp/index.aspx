<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="/resource/css/myMain.css" type="text/css" />
    <script type="text/javascript" src="/resource/js/myMain.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>主页</title>
</head>

<body bgcolor="#3399ff">
    <form id="form1" runat="server">
        <div id="container">
            <div id="banner">
                <a href="javascript:loginOrRegister()" class="logIn">登陆/注册：<asp:Image ImageUrl="/resource/img/in.png" runat="server" />
                </a>
                <br />
                <a href="register.aspx" class="logOut">登出：<asp:Image ImageUrl="/resource/img/out.png" runat="server" /></a>
                <%
                    if (Session["UserName"] != null)
                    {

                        Label3.Text = "欢迎回来，" + Session["UserName"].ToString();
                    }
                    else
                    {
                        Label3.Text = "您还未登陆，请先登陆！";
                    }

                %>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </div>
            <div id="body">
                <div id="left">
                </div>
                <div id="middle">
                </div>
                <div id="right"></div>
            </div>
        </div>
    </form>
</body>
</html>
