<%@ Control Language="C#" AutoEventWireup="true" CodeFile="charts.ascx.cs" Inherits="charts" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 154px;
    }
    .auto-style5 {
        width: 100%;
        height: 95px;
    }
    .auto-style6 {
        width: 482px;
        height: 32px;
    }
    .auto-style7 {
        height: 32px;
    }
    .auto-style10 {
        height: 28px;
    }
    .auto-style17 {
        height: 28px;
        width: 352px;
    }
    .auto-style18 {
        width: 352px;
    }
    .auto-style23 {
        width: 352px;
        height: 33px;
    }
    .auto-style24 {
        height: 33px;
    }
    .auto-style25 {
        height: 31px;
        width: 352px;
    }
    .auto-style26 {
        height: 31px;
    }
    .auto-style27 {
        width: 352px;
        height: 32px;
    }
</style>
<hr>
<p>
    <h3>Previous Trip Details</h3><table class="auto-style1">
        <tr>
            <td class="auto-style17">Trip ID: <asp:Label ID="id" runat="server" Text="8"></asp:Label>
            </td>
            <td class="auto-style10">Total Fuel Cost:
                <asp:Label ID="cost" runat="server" Text="800"></asp:Label>
&nbsp;RS</td>
            <td class="auto-style10">Traffic Milage Vs Highway Milage</td>
        </tr>
        <tr>
            <td class="auto-style25">Trip Type: <asp:Label ID="trip_type" runat="server" Text="Urban"></asp:Label>
            </td>
            <td class="auto-style26">Start Location:
                <asp:Label ID="s_location" runat="server" Text="banglore"></asp:Label>
            </td>
            <td rowspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23">Distence Driven:<asp:Label ID="Distence" runat="server" Text="85"></asp:Label>
&nbsp;KM</td>
            <td class="auto-style24">Start Time:
                <asp:Label ID="s_time" runat="server" Text="06:00"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style27">Fuel Used:
                <asp:Label ID="fuel" runat="server" Text="25"></asp:Label>
&nbsp;L</td>
            <td class="auto-style7">End Location:
                <asp:Label ID="e_location" runat="server" Text="chennai"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">Milage:
                <asp:Label ID="milage" runat="server" Text="8"></asp:Label>
&nbsp;KMpL</td>
            <td>End Time:
                <asp:Label ID="e_time" runat="server" Text="12:00"></asp:Label>
            </td>
        </tr>
        </table>

<table class="auto-style5">
    <tr>
        <td class="auto-style6">Milage Chart</td>
        <td class="auto-style7">Cost per Km Chart</td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
</table>


