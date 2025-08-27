<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/mspDefault.Master" CodeBehind="frmRepInvoiceDocumentList.aspx.vb" Inherits="SESTicketReport.rptInvoiceDocumentList" %>
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
            $("[id$=txtInvoiceDateBegin]").datepicker({
                dateFormat: 'dd/mm/yy'
            }); 
        });
    </script>
    <script type="text/javascript">
        $(function () {
            $("[id$=txtInvoiceDateEnd]").datepicker({
                dateFormat: 'dd/mm/yy'
            }); 
        });
    </script>

    <asp:Button ID="btnBack" Text="Back" runat="server" CssClass ="btn btn-default btn-xs" Style ="position: absolute; top: 75px; left: 15px; width: 70px;" OnClientClick="JavaScript: window.location.assign('../Forms/frmReportMain.aspx'); return false;" />

    <%-- Filter Area --%>
    <asp:Panel ID="pnlFilter" runat="server" Visible="true" Style ="position:relative; top: 2px; left: 25px; height: 82px; width: 975px;" BorderStyle="Ridge" BorderWidth="1px" BorderColor="#eeeeee"   >

        <asp:Label ID="lblInvoiceDataBegin" runat="server" Text="Invoice Date (Begin):" CssClass="SupLabelRedBold" Style="position: absolute; top: 10px; left: 4px; width: 129px; height: 25px; text-align: right; margin-top: 4px;"/>
        <asp:TextBox ID="txtInvoiceDateBegin" runat="server" CssClass="form-control" Style="position: absolute; top: 12px; left: 140px; width: 129px; height: 25px;" ReadOnly="true"></asp:TextBox>
        
        <asp:Label ID="lblInvoiceDataEnd" runat="server" Text="Invoice Date (End):" CssClass="SupLabelRedBold" Style="position: absolute; top: 40px; left: 5px; width: 118px; height: 25px; text-align: right;"/>
        <asp:TextBox ID="txtInvoiceDateEnd" runat="server" CssClass="form-control" Style="position: absolute; top: 42px; left: 140px; width: 129px; height: 25px;" ReadOnly="true"></asp:TextBox>
        
        <asp:Button ID="btnGenReport" runat="server" Text="Ok" CssClass="btn btn-primary btn-sm"  Style="position: absolute; top: 10px; left: 300px; width: 70px;" OnClick="btnGeneReport_Click" />

   </asp:Panel>

   <%-- Report View Area --%>
   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <rsweb:ReportViewer ID="ReportViewer1" runat="server" Style ="position:relative; top: 15px; left: 20px; width:1200px" AsyncRendering="False" InteractivityPostBackMode="AlwaysSynchronous"></rsweb:ReportViewer>
    
</asp:Content>
