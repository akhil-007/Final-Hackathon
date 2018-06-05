<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="Client1.Transaction1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        
    <div>
        <pre>
         <asp:Label ID="Label1" runat="server" Text="Trip Id"></asp:Label>               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="Vehicle No"></asp:Label>            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label3" runat="server" Text="Address_Start"></asp:Label>         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label4" runat="server" Text="Address_End"></asp:Label>           <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label5" runat="server" Text="Gps_Start"></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="Gps_End"></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="Ride_Type"></asp:Label>             <input type="radio" name="RideType" value="Outstation" id="test1" checked="checked" />Outstation <input type="radio" name="RideType" value="City" />City<br />
        <asp:Label ID="Label8" runat="server" Text="Fuel_Cost_Litre"></asp:Label>       <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label9" runat="server" Text="Distance"></asp:Label>              <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label10" runat="server" Text="Start_Date"></asp:Label>           <asp:Calendar ID="Calendar1" runat="server"  SelectionMode="DayWeekMonth" onselectionchanged="Calendar1_SelectionChanged" Width="132px" Height="59px"></asp:Calendar>
        
        <asp:Label ID="Label11" runat="server" Text="End_Date"></asp:Label>             <asp:Calendar ID="Calendar2" runat="server"  SelectionMode="DayWeekMonth" onselectionchanged="Calendar2_SelectionChanged" Width="132px" Height="59px"></asp:Calendar>
        <asp:Label ID="Label12" runat="server" Text="Ac"></asp:Label>                   <input type="radio" name="AC" value="Yes" id="test2" checked="checked" />Yes <input type="radio" name="AC" value="No" id="test3" />No<br />
                                                                          <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="110px" />
            </pre>
        
    </div>
    </form>
</body>
</html>
