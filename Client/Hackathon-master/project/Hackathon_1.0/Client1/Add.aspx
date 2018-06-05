<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Client1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
  <title>Bootstrap Example</title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
    

<body>
    <form id="form1" runat="server">
         
     
    
        <div class="alert alert-success alert-dismissible">
        <pre>
            <asp:Label ID="Label1" runat="server" Text="Vehicle number"></asp:Label>     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Wheel Type"></asp:Label>         <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ><asp:ListItem Value="">Please Select</asp:ListItem><asp:ListItem> 2</asp:ListItem><asp:ListItem> 4</asp:ListItem></asp:DropDownList><br />
            <asp:Label ID="Label4" runat="server" Text="Vehicle Type"></asp:Label>       <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList><br />
            <asp:Label ID="Label5" runat="server" Text="Year"></asp:Label>               <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Model"></asp:Label>              <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="Manufacturer"></asp:Label>       <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label8" runat="server" Text="Fuel Capacity"></asp:Label>      <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click"  class="close" data-dismiss="alert" aria-hidden="true"></asp:Button>
                
            
                
                <strong>Success!</strong> This alert box could indicate a successful or positive action.
            </pre>
   
    </div>
        
    </form>
</body>
</html>
