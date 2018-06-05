<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Client1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <style type="text/css">
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
  background:LightPink;
  background: -webkit-linear-gradient(top left, #50a3a2 0%, #53e3a6 100%);
  background: linear-gradient(to bottom right, #50a3a2 0%, #53e3a6 100%);
  position: absolute;
  top: 10%;
  left: 30%;
  width: 350px;
  margin-left: auto;
    margin-right: auto;
  margin:auto;
  padding:20px;
  display:inline-block;
  float:center;
  height: 350px;
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
          width: 287px;
      }
.container h1 {
  font-size: 40px;
  -webkit-transition-duration: 1s;
          transition-duration: 1s;
  -webkit-transition-timing-function: ease-in-put;
          transition-timing-function: ease-in-put;
  font-weight: 200;
  font
}
form {
  padding: 20px 0;
  position: relative;
  z-index: 2;
          top: -82px;
          left: 1px;
      }
form input {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  outline: 0;
  border: 1px solid rgba(255, 255, 255, 0.4);
  background-color: Gray;
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
form input:hover {
  background-color: Aqua;
}
form input:focus {
  background-color:Gray;
  width: 300px;
  color:black;
}
form button {
  -webkit-appearance: none;
     /*-moz-appearance: none;*/
          appearance: none;
  outline: 0;
  background-color:Blue;
  border: 0;
  padding: 10px 15px;
  color:DarkGoldenRod;
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
  -webkit-animation-delay: 0s;
          animation-delay: 0s;
  -webkit-animation-duration: 7s;
          animation-duration: 7s;
}
.bg-bubbles li:nth-child(3) {
  left: 25%;
  -webkit-animation-delay: 1s;
          animation-delay: 1s;
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

    
    <div class="wrapper" >
	<div class="container">






    <form id="form1" class="form"  runat="server">
  
 <center>
        <table class="auto-style2">
            <tr>
                <td><h3 style="color:white;text-align:left" ><b>Analyse Vehicle Details</b></h3></></td>
            </tr>
            <tr>
                <td><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/MainDashboard.aspx" style="color:white;text-align:match-parent" >Dashboard </asp:HyperLink>&nbsp;</td>
            </tr>
            <tr>
                <td><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="http://localhost:5601/app/kibana#/dashboard/c7fc1df0-67f4-11e8-8489-1159427ae8f8?_g=(refreshInterval:(display:Off,pause:!f,value:0),time:(from:'2018-06-04T12:11:25.965Z',mode:absolute,to:'2018-06-04T12:26:25.966Z'))&_a=(description:'',filters:!(),fullScreenMode:!f,options:(darkTheme:!f,hidePanelTitles:!f,useMargins:!t),panels:!((embeddableConfig:(spy:!n),gridData:(h:3,i:'1',w:6,x:0,y:0),id:'21d3a600-67f4-11e8-8489-1159427ae8f8',panelIndex:'1',type:visualization,version:'6.2.2'),(gridData:(h:3,i:'2',w:6,x:6,y:0),id:ffc83ea0-67f2-11e8-8489-1159427ae8f8,panelIndex:'2',type:visualization,version:'6.2.2')),query:(language:lucene,query:''),timeRestore:!t,title:'Automatic%20Mileage%20Dashboard',viewMode:view)" style="color:white;text-align:match-parent" > Analysis </asp:HyperLink>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><center><h3 style="color:white;text-align:left" >Modify Vehicle Details</h3>
                    </center>
                    &nbsp;</td>
            </tr>
            <tr>
                <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Add.aspx" style="color:white;text-align:match-parent" >Add </asp:HyperLink>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;
                </td>
            </tr>
            <tr>
                <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Update.aspx" style="color:white" >Update</asp:HyperLink>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;<br />
                </td>
            </tr>
            <tr>
                <td><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DeleteForm.aspx" style="color:white">Delete</asp:HyperLink>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;<br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><center><h3 style="color:white;text-align:left" >Modify Transactions Details</h3></center>
                </td>
            </tr>
            <tr>
                <td><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Transaction.aspx" style="color:white;text-align:left" >Add </asp:HyperLink>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;<br />
                </td>
            </tr>
           
        </table>
           
            </center>
    </form>
        </div>
        
    	
</div>
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
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

        <script src="js/index.js"></script>

</body>
</html>
