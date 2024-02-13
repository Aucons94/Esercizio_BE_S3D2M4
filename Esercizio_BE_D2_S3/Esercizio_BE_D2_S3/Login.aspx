<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Esercizio_BE_D2_S3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
         <asp:Label ID="Label2" runat="server" Text="Inserisci i tuoi dati:"></asp:Label>
         <asp:Label ID="Label1" runat="server" Text="Login effettuato con successo"></asp:Label>
         <br />
         <asp:TextBox ID="Username" runat="server"></asp:TextBox>
         <br />
         <asp:TextBox ID="Password" runat="server"></asp:TextBox>
         <br />
         <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_page" />
    </form>
</body>
</html>
