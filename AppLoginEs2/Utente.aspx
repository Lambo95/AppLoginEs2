﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Utente.aspx.cs" Inherits="AppLoginEs2.Utente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtUtente" runat="server" Text=""></asp:Label>
            <asp:Button ID="Logout" runat="server" Text="Login" OnClick="Logout_Click" />

        </div>
    </form>
</body>
</html>
