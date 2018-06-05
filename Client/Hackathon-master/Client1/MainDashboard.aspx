<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainDashboard.aspx.cs" Inherits="Client1.MainDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 560px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Trip Details" />
        </div>
        <table class="auto-style1">
            <tr>
                <td><center>
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel></center>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
