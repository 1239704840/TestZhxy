<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        * {
            margin: 0px;
            padding: 0px;
            border: 0px;
        }

        #container {
            width: 80%;
            height: 768px;
            margin: 0px auto;
        }

        #banner {
            width: 100%;
            height: 20%;
            background-color: red;
        }

        #body {
            width: 100%;
            height: 80%;
        }

        #left {
            width: 20%;
            height: 100%;
            float: left;
            background-color: blue;
        }

        #middle {
            width: 60%;
            height: 100%;
            float: left;
            background-color: yellow;
        }

        #right {
            width: 20%;
            height: 100%;
            float: left;
            background-color: pink;
        }
    </style>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body  bgcolor="#3399ff">
    <div id="container">
        <div id="banner"></div>
        <div id="body">
            <div id="left"></div>
            <div id="middle">

                <form id="form1" runat="server">
                    <div align="center">
                        <h1>用户登录页面</h1>
                        <asp:Label ID="Label1" runat="server" Text="用户" Font-Names="黑体"></asp:Label>
                        <asp:TextBox ID="labuser" runat="server"></asp:TextBox><br />
                        <asp:Label ID="Label2" runat="server" Text="密码" Font-Bold="False" Font-Names="黑体"></asp:Label>
                        <asp:TextBox ID="labpwd" runat="server" TextMode="Password" AutoCompleteType="BusinessZipCode" Width="145px"></asp:TextBox><br />
                        <asp:Button ID="abov" runat="server" Text="登陆" OnClick="allow_Click" Style="height: 21px" />
                        <input type="reset" name="button" id="button" value="重置" />
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                        <br />
                        <br />
                    </div>
                </form>

            </div>
            <div id="right"></div>
        </div>

    </div>

</body>
</html>
