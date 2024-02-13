<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadCookie.aspx.cs" Inherits="Esercizio_BE_D2_S3.ReadCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="DatiUtente" runat="server"></p>
            <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="logout_Click" />
        </div>
    </form>
    
</body>
</html>
