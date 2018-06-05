<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Client1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <pre>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Update" />
            <asp:Button ID="Button3" runat="server" Text="Delete" />
            </pre>

        </div>
    </form>
</body>
</html>
