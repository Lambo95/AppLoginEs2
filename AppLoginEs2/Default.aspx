<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppLoginEs2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUsername" runat="server" Text=""></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
        </div>
    </form>
    
</body>
</html>
