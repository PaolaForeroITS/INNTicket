<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/mspDefault.Master" CodeBehind="frmRepTicketInvConsolidated.aspx.vb" Inherits="SESTicketReport.frmRepTicketInvConsolidated" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphhead" runat="server"> </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">

	<%-- Its necessary include ClientIDMode="Static" in the Textbox--%>
    <link href="../../Scripts/datepicker/ccs/normalize.css" rel="stylesheet" />
    <link href="../../Scripts/datepicker/ccs/datepicker.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.2.1.min.js"></script>
    <script src="../../Scripts/jquery-ui-1.12.1.min.js"></script>

    <script type="text/javascript">
        $(function () {
            $("[id$=txtServiceDateBegin]").datepicker({
                dateFormat: 'dd/mm/yy'
            }); 
        });
    </script>
    <script type="text/javascript">
        $(function () {
            $("[id$=txtServiceDateEnd]").datepicker({
                dateFormat: 'dd/mm/yy'
            }); 
        });
    </script>
        
    <asp:Button ID="btnBack" Text="Back" runat="server" CssClass ="btn btn-default btn-xs" Style ="position: absolute; top: 75px; left: 15px; width: 70px;" OnClientClick="JavaScript: window.location.assign('../Forms/frmReportMain.aspx'); return false;" />

    <%-- Filter Area --%>
    <asp:Panel ID="pnlFilter" runat="server" Visible="true" Style ="position:relative; top: 2px; left: 25px; height: 82px; width: 1042px;" BorderStyle="Ridge" BorderWidth="1px" BorderColor="#eeeeee"   >

        <asp:Label ID="lblServiceDataBegin" runat="server" Text="Service Date (Begin):" CssClass="SupLabelRedBold" Style="position: absolute; top: 10px; left: 4px; width: 129px; height: 25px; text-align: right; margin-top: 4px;"/>
        <asp:TextBox ID="txtServiceDateBegin" runat="server" CssClass="form-control" Style="position: absolute; top: 12px; left: 140px; width: 129px; height: 25px;" ReadOnly="true"></asp:TextBox>
        
        <asp:Label ID="lblServiceDataEnd" runat="server" Text="Service Date (End):" CssClass="SupLabelRedBold" Style="position: absolute; top: 40px; left: 5px; width: 118px; height: 25px; text-align: right;"/>
        <asp:TextBox ID="txtServiceDateEnd" runat="server" CssClass="form-control" Style="position: absolute; top: 42px; left: 140px; width: 129px; height: 25px;" ReadOnly="true"></asp:TextBox>
        
        <asp:Label ID="lblTicketID" runat="server" Text="Ticket ID:" CssClass="SupLabelBlueBold" Style="position: absolute; top: 10px; left: 250px; width: 103px; height: 25px; text-align: right; margin-top: 4px;"/>
        <asp:TextBox ID="txtTicketID" runat="server" CssClass="form-control" Style="position: absolute; top: 12px; left: 360px; width: 129px; height: 25px;"></asp:TextBox>

        <asp:Label ID="lblCreatedBy" runat="server" Text="Created By:" CssClass="SupLabelBlueBold" Style="position: absolute; top: 40px; left: 250px; width: 103px; height: 25px; text-align: right; margin-top: 4px;"/>
        <asp:TextBox ID="txtCreatedBy" runat="server" CssClass="form-control" Style="position: absolute; top: 42px; left: 360px; width: 129px; height: 25px;"></asp:TextBox>

        <asp:Panel ID="pnlTicketStatus" runat="server" Style="position: absolute; top: 10px; left: 520px; width: 129px; height: 25px; " >
            
            <asp:Label ID="lblTicketStatus" runat="server" Text="Ticket Status:" CssClass="SupLabelRedBold" Style="position: absolute; top: 0px; left: 5px; width: 129px; height: 25px; text-align: left; margin-top: 4px;"/>
        
            <asp:CheckBox ID="chkOpen" runat="server"  Style="position: absolute; top: 2px; left: 100px; width: 22px; height: 20px; " Checked="True"/> 
            <asp:Label ID="lblTicketStatusOpen" runat="server" Text="Open" CssClass="SupLabelBlueBold" Style="position: absolute; top: 0px; left: 120px; width: 51px; height: 25px; text-align: left; margin-top: 4px;"/>

            <asp:CheckBox ID="chkClosed" runat="server"  Style="position: absolute; top: 2px; left: 160px; width: 22px; height: 20px; " Checked="True"/> 
            <asp:Label ID="lblClosed" runat="server" Text="Closed" CssClass="SupLabelBlueBold" Style="position: absolute; top: 0px; left: 180px; width: 51px; height: 25px; text-align: left; margin-top: 4px;"/>

            <asp:CheckBox ID="chkCanceled" runat="server"  Style="position: absolute; top: 2px; left: 230px; width: 22px; height: 20px; "/> 
            <asp:Label ID="lblCanceled" runat="server" Text="Canceled" CssClass="SupLabelBlueBold" Style="position: absolute; top: 0px; left: 250px; width: 51px; height: 25px; text-align: left; margin-top: 4px;"/>
                        
        </asp:Panel>

        <asp:Button ID="btnGenReport" runat="server" Text="Ok" CssClass="btn btn-primary btn-sm"  Style="position: absolute; top: 10px; left: 860px; width: 70px;" OnClick="btnGeneReport_Click" />

   </asp:Panel>

   <%-- Report View Area --%>
   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <rsweb:ReportViewer ID="ReportViewer1" runat="server" Style ="position:relative; top: 15px; left: 20px; width:1200px" AsyncRendering="False" InteractivityPostBackMode="AlwaysSynchronous"></rsweb:ReportViewer>
    
</asp:Content>