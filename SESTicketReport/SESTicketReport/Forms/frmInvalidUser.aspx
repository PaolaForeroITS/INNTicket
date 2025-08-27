<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInvalidUser.aspx.vb" Inherits="SESTicketReport.frmInvalidUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%-- ====== IE Compatibility =========--%>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title></title>

    <%-- ====== CSS =========--%>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="../Ccs/SESMenu.css" />
    <link type="text/css" rel="stylesheet" href="../Ccs/SESObject.css" />
</head>
<body>
<div class="row" style="margin-top:5px; height: 55px;">
        <h1><asp:Image ID="Image1" runat="server" style="position: absolute; top: 2px; width: 170px; height: 59px; left: 7px;" ImageUrl="../Image/spn-logo-2016.png" /></h1>
    </div>
    
    <div class="Title" style="position: absolute; 
                              top: 17px; 
                              left: 199px;
                              color: #1E3561;
                              font-family: Arial, Helvetica, sans-serif;
                              font-size: 18px;">
        SESTicket - Report
    </div>

    <form id="mspDefault" runat="server">
    <div>

        <div class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                </div>
            </div>
        </div>

       <asp:Label ID="lblUser" runat="server" 
            Text="User: Administrator" 
            Style ="position: absolute; 
                    top: 24px; 
                    left: 691px; 
                    width: 299px;
                    text-align: right;
                    color: #53585a;
                    font-family: Arial, Helvetica, sans-serif;
                    font-size: 12px;"  />

        <asp:Label ID="Label1" runat="server" Text="THE ACCESS IS DENIED."
            style="position: absolute; 
                              top: 302px; 
                              left: 506px;
                              color: black;
                              font-family: Arial, Helvetica, sans-serif;
                              font-size: 18px;"

            ></asp:Label>
        <img src="../Image/accessdenied.PNG"  style="position: absolute; 
                              top: 208px; 
                              left: 579px;"/>

        <asp:Label ID="Label2" runat="server" Text="Please contact your system administrator for more information."
            style="position: absolute; 
                              top: 328px; 
                              left: 364px;
                              color: gray;
                              font-family: Arial, Helvetica, sans-serif;
                              font-size: 18px; width: 509px;"

            ></asp:Label>



    </div>
    </form>

    <%-- ====== Script Area =========--%>
    <script src="../Scripts/jquery-3.2.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
