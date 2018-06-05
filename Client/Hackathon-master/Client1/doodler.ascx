<%@ Control Language="C#" AutoEventWireup="true" CodeFile="doodler.ascx.cs" Inherits="doodler" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<style type="text/css">
    .auto-style9 {
       
        width: 100%;
        height: 212px;
        margin-bottom: 0px;
    }
    .auto-style10 {
        width: 333px;
    }
    .auto-style11 {
        width: 380px;
        height: 50px;
    }
    .auto-style12 {
        height: 50px;
    }
    .auto-style15 {
        width: 380px;
        height: 63px;
    }
    .auto-style16 {
        width: 380px;
        }
    .auto-style18 {
        width: 84px;
    }
    .auto-style19 {
        width: 100%;
    }
    </style>
<hr>
<table class="auto-style19">
    <tr>
        <td></td>
    </tr>
    <tr>
        <td></td>
    </tr>
    <hr>
    <tr>
        <td></td>
    </tr>
    </table>

<table class="auto-style9">
    <tr>
        <td class="auto-style18" rowspan="5">
            &nbsp;</td>
        <td class="auto-style10" rowspan="5">
            <asp:Image ID="Image1" runat="server" Height="170px" ImageUrl="https://cdni.autocarindia.com/Utils/ImageResizer.ashx?n=http%3a%2f%2fcdni.autocarindia.com%2fExtraImages%2f20180601041914_Jeep-Renegade-.jpg&amp;h=578&amp;w=872&amp;c=0" Width="220px" />
        </td>
        <td class="auto-style15"><b>Car Name:</b>
            <asp:Label ID="name" runat="server" Text="Polar Burner"></asp:Label>
        </td>
        <td>
            <b>Milage:</b>
            <asp:Label ID="milage" runat="server" Text="8"></asp:Label>
&nbsp;KMpL
            <asp:Label ID="low_milage" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style16"><b>Car Model</b>:
            <asp:Label ID="model" runat="server" Text="SUV"></asp:Label>
        </td>
        <td rowspan="3">
            <asp:Chart ID="Chart1" runat="server" Height="128px" OnLoad="Chart1_Load" Width="174px">
                <series>
                    <asp:Series ChartType="Doughnut" Name="Series1" ChartArea="ChartArea1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            </td>
    </tr>
    <tr>
        <td class="auto-style16"><b>Car Number:</b>
            <asp:Label ID="car_no" runat="server" Text="TN09SD0254"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style16"><b>Service Period:</b>
            <asp:Label ID="time" runat="server" Text="5"></asp:Label>
&nbsp;Years</td>
    </tr>
    <tr>
        <td class="auto-style11">
            <b>Fuel Type:</b>
            <asp:Label ID="fuel" runat="server" Text="Petrole"></asp:Label>
        </td>
        <td class="auto-style12">
            <b>Cost Per Kilometer:</b>
            <asp:Label ID="cost" runat="server" Text="9"></asp:Label>
&nbsp;RS</td>
    </tr>
</table>





