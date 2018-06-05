<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Client1.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <style type = "text/css">
           @import url(http://fonts.googleapis.com/css?family=Source+Sans+Pro:200,300);
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
  font-weight: 300;
}
body {
  font-family: 'Source Sans Pro', sans-serif;
  color: white;
  font-weight: 300;
  background-image: url("images/veh.jpg");
  background-repeat:no-repeat;
    background-attachment:fixed;
    background-size: auto;
    background-size: 100% 100%;
}
 

.wrapper {
  background: #50a3a2;
  background: -webkit-linear-gradient(top left, #50a3a2 0%, #53e3a6 100%);
  background: linear-gradient(to bottom right, #50a3a2 0%, #53e3a6 100%);
  position: absolute;
  top: 2%;
  left: 40%;
  
  width: 350px;
  margin:auto;
  padding:20px;

  height: 800px;
  margin-top: 100px;
  overflow: hidden;
}
.wrapper.form-success .container h1 {
  -webkit-transform: translateY(85px);
          transform: translateY(85px);
}
.container {
  max-width: 600px;
  margin: 0 auto;
  padding: 80px 0;
  height: 400px;
  text-align: center;
}
.container h1 {
  font-size: 40px;
  -webkit-transition-duration: 1s;
          transition-duration: 1s;
  -webkit-transition-timing-function: ease-in-put;
          transition-timing-function: ease-in-put;
  font-weight: 200;
}
form {
  padding: 0 0;
  position: relative;
  z-index: 2;
}
form input {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  outline: 0;
  border: 1px solid rgba(255, 255, 255, 0.4);
  background-color: rgba(255, 255, 255, 0.2);
  width: 250px;
  border-radius: 3px;
  padding: 10px 15px;
  margin: 0 auto 10px auto;
  display: block;
  text-align: center;
  font-size: 18px;
  color: white;
  -webkit-transition-duration: 0.25s;
          transition-duration: 0.25s;
  font-weight: 300;
}
.hai {
  border: 1px solid rgba(255, 255, 255, 0.4);
  background-color: rgba(255, 255, 255, 0.2);
  width:250px;
  border-radius:3px;
  margin: 0 auto 10px auto;
  padding: 10px 15px;
  text-align: center;
  font-size: 18px;
  color: white;
  font-weight: 300;
}
form input:hover {
  background-color: rgba(255, 255, 255, 0.4);
}
form input:focus {
  background-color: white;
  width: 300px;
  color: #53e3a6;
}
form button {
  -webkit-appearance: none;
     /*-moz-appearance: none;*/
          appearance: none;
  outline: 0;
  background-color: white;
  border: 0;
  padding: 10px 15px;
  color: #53e3a6;
  border-radius: 3px;
  width: 250px;
  cursor: pointer;
  font-size: 18px;
  -webkit-transition-duration: 0.25s;
          transition-duration: 0.25s;
}
form button:hover {
  background-color: #f5f7f9;
}
.bg-bubbles {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: 1;
}
.bg-bubbles li {
  position: absolute;
  list-style: none;
  display: block;
  width: 40px;
  height: 40px;
  background-color: rgba(255, 255, 255, 0.15);
  bottom: -160px;
  -webkit-animation: square 25s infinite;
  animation: square 25s infinite;
  -webkit-transition-timing-function: linear;
  transition-timing-function: linear;
}
.bg-bubbles li:nth-child(1) {
  left: 10%;
}
.bg-bubbles li:nth-child(2) {
  left: 20%;
  width: 80px;
  height: 80px;
  -webkit-animation-delay: 2s;
          animation-delay: 2s;
  -webkit-animation-duration: 17s;
          animation-duration: 17s;
}
.bg-bubbles li:nth-child(3) {
  left: 25%;
  -webkit-animation-delay: 4s;
          animation-delay: 4s;
}
.bg-bubbles li:nth-child(4) {
  left: 40%;
  width: 60px;
  height: 60px;
  -webkit-animation-duration: 22s;
          animation-duration: 22s;
  background-color: rgba(255, 255, 255, 0.25);
}
.bg-bubbles li:nth-child(5) {
  left: 70%;
}
.bg-bubbles li:nth-child(6) {
  left: 80%;
  width: 120px;
  height: 120px;
  -webkit-animation-delay: 3s;
          animation-delay: 3s;
  background-color: rgba(255, 255, 255, 0.2);
}
.bg-bubbles li:nth-child(7) {
  left: 32%;
  width: 160px;
  height: 160px;
  -webkit-animation-delay: 7s;
          animation-delay: 7s;
}
.bg-bubbles li:nth-child(8) {
  left: 55%;
  width: 20px;
  height: 20px;
  -webkit-animation-delay: 15s;
          animation-delay: 15s;
  -webkit-animation-duration: 40s;
          animation-duration: 40s;
}
.bg-bubbles li:nth-child(9) {
  left: 25%;
  width: 10px;
  height: 10px;
  -webkit-animation-delay: 2s;
          animation-delay: 2s;
  -webkit-animation-duration: 40s;
          animation-duration: 40s;
  background-color: rgba(255, 255, 255, 0.3);
}
.bg-bubbles li:nth-child(10) {
  left: 90%;
  width: 160px;
  height: 160px;
  -webkit-animation-delay: 11s;
          animation-delay: 11s;
}
@-webkit-keyframes square {
  0% {
    -webkit-transform: translateY(0);
            transform: translateY(0);
  }
  100% {
    -webkit-transform: translateY(-700px) rotate(600deg);
            transform: translateY(-700px) rotate(600deg);
  }
 }

           @keyframes square {
               0% {
                   -webkit-transform: translateY(0);
                   transform: translateY(0);
               }

               100% {
                   -webkit-transform: translateY(-700px) rotate(600deg);
                   transform: translateY(-700px) rotate(600deg);
               }
           }
</style>

</head>
<body>
    <h1 style="background-color:#50a3a2;border:20px;padding:20px;text-align:center">AUTOMATIC VEHICLE MILEAGE TRACKER </h1>
    <div class="wrapper">
    <form id="form1" runat="server" >
        
                <asp:Label ID="Label1" runat="server" Text="Vehicle Number"></asp:Label>       <asp:TextBox ID="vehicle_number" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Get Details" OnClick="Button1_Click" style="height: 26px"></asp:Button>

                 

                 <asp:Panel ID="Panel1" runat="server" Height="216px">
                    <asp:Label ID="Label2" runat="server" Text="Wheel Type"></asp:Label>  
                     <div class="hai">
                     <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                         <asp:ListItem>2</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                     </asp:DropDownList>
                         </div>
                     <br />
                     <asp:Label ID="Label3" runat="server" Text="Vehicle Type"></asp:Label>
                     <div class="hai">
                     <asp:DropDownList ID="DropDownList2" runat="server">
                     </asp:DropDownList>
                         </div>
                     <br />
                     <asp:Label ID="Label4" runat="server" Text="Year"></asp:Label>  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                     <asp:Label ID="Label5" runat="server" Text="Model"></asp:Label>  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                     <asp:Label ID="Label6" runat="server" Text="Manufacturer"></asp:Label>  <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                     <asp:Label ID="Label7" runat="server" Text="Fuel Capacity"></asp:Label>  <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />





                     <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button"></asp:Button >





                 </asp:Panel>

           
            
        
    </form>
     
        	<ul class="bg-bubbles">
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
		<li></li>
	</ul>

        </div>
     <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

        <script src="js/index.js"></script>
</body>
</html>

