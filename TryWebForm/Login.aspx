<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AccountingNote.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder runat="server" ID="plcLogin" Visible="false">
            Account:<asp:TextBox runat="server" ID="txtAccount" /><br />
            Password:<asp:TextBox runat="server" ID="txtPWD" TextMode="Password" /><br />
            <asp:Button Text="Login" ID="btnLogin" OnClick="btnLogin_Click" runat="server" /><br />
            <asp:Literal ID="ltlMsg" Text="BANG" runat="server" />
        </asp:PlaceHolder>
    </form>
</body>
</html>
