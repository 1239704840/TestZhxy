<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body bgcolor="#3399ff">
  <form id="form1" runat="server">
    <div  align="center">
        <h1>用户注册页面</h1> 
    <asp:Label ID="Label1" runat="server" Text="注册名" placeholder="4到9个字符" Width="100px" Font-Size="Medium"></asp:Label>
       <asp:TextBox ID="labuser" runat="server"></asp:TextBox><br/>  
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="labuser" ErrorMessage="注册名是必须的" Font-Size="Small"></asp:RegularExpressionValidator>
       <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>  
       <asp:TextBox ID="labpwd" runat="server" TextMode="Password" AutoCompleteType="BusinessZipCode" Width="100px" Font-Size="Medium"></asp:TextBox><br />  
       <asp:Button ID="abov" runat="server" Text="注册" OnClick="abov_Click" />
         <input type="reset" name="button" id="button" value="重置" /> 
        <asp:Label ID="Label3" runat="server"></asp:Label>
       <br />  
    </div>
    </form>
</body>
</html>
