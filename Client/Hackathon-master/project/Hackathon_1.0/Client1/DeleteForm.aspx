<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteForm.aspx.cs" Inherits="Client1.DeleteForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <pre>
            <asp:Label ID="Label1" runat="server" Text="Enter vehicle number to delete"></asp:Label>  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></br>
            
            </br>
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click"></asp:Button>
                
                </pre>
                </div>
            
    </form>
</body>
</html>
