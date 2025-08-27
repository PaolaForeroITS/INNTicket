<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/mspDefault.Master" CodeBehind="frmReportMain.aspx.vb" Inherits="SESTicketReport.frmReportMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphhead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">

 <asp:Image ID="imgPageHeader" runat="server" ImageUrl="~/Image/header.JPG" Style ="position: absolute; left: 0px; top: 113px; height: 40px; width:1400px;"/>
        <asp:Panel ID="pnlHeader" runat="server" Style ="position:absolute; top: 118px; left: 20px;" >
        <asp:Label ID="lblPageHeader" runat="server" Text ="REPORTS" CssClass="SupLabelBold" Style ="position: absolute; left: 20px; top: 3px; color: white; font-size: 14px; "/>
    </asp:Panel>

    <asp:Panel ID="pnlReport" runat="server"
        CssClass="form-control"  Style="position:relative; top: 40px; left: 100px; height: 290px; width: 701px; margin-top:15px" 
        BorderStyle="None" BorderWidth="2px" Visible="true" >
    
        <asp:GridView ID="dgvReport" runat="server" 
            CssClass="table table-bordered table-condensed"
            Style ="position:absolute; 
                    top: 10px;
                    left: 8px;
                    width: 680px;" 
            AutoGenerateColumns="False" 
            DataSourceID="DEPds"
            AllowSorting="True" 
            AllowPaging="True"
            Font-Size="11px"
            PageSize="10"  
            OnRowCommand="dgvReport_RowCommand"
            >
             <HeaderStyle BackColor="#1E3561" Font-Bold="True" ForeColor="White" />
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
             <Columns>
                 <%-- Index 0 --%>
                 <asp:BoundField DataField="REPORTID" HeaderText="" ReadOnly="True" Visible="true" ItemStyle-CssClass="SupHiddenCol" HeaderStyle-CssClass="SupHiddenCol">
                    </asp:BoundField>
                 <%-- Index 1 --%>
                 <asp:BoundField DataField="REPGROUP" HeaderText="" ReadOnly="True" Visible="true" ItemStyle-CssClass="SupHiddenCol" HeaderStyle-CssClass="SupHiddenCol">
                    </asp:BoundField>
                 <%-- Index 2 --%>  
                 <asp:BoundField DataField="REPNAME" HeaderText="Report Name" SortExpression="REPNAME"  HeaderStyle-Width="200px"  ItemStyle-Width="200px" >
                    </asp:BoundField>
                 <%-- Index 3 --%>  
                 <asp:BoundField DataField="RESUME" HeaderText="Objective" SortExpression="RESUME" >
                    </asp:BoundField>
                 <%-- Index 4 --%>
                 <asp:TemplateField ShowHeader="False" HeaderStyle-Width="10px" ItemStyle-Width="10px">
                      <ItemTemplate>
                          <asp:Button ID="btnOpen" runat="server"
                                      CommandName="BaseData"
                                      CommandArgument="<%# CType(Container, GridViewRow).RowIndex %>"
                                      Text="Open" />
                          </ItemTemplate>
                       </asp:TemplateField>
             </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="DEPds" runat="server" ConnectionString="<%$ ConnectionStrings:SESTicketReportConnStr %>" 
            SelectCommand ="EXECUTE [sp_ReportList] null " >
        </asp:SqlDataSource>

    </asp:Panel>
      
    <asp:Panel ID="pnlRepAdic" runat="server"
        CssClass="form-control"  Style="position:relative; top: 40px; left: 100px; height: 290px; width: 701px; margin-top:15px" 
        BorderStyle="None" BorderWidth="2px" Visible="true" >
    
        <asp:GridView ID="dgvReportAdic" runat="server" 
            CssClass="table table-bordered table-condensed"
            Style ="position:absolute; 
                    top: 10px;
                    left: 8px;
                    width: 680px;" 
            AutoGenerateColumns="False" 
            DataSourceID="REPAdicDs"
            AllowSorting="True" 
            AllowPaging="True"
            Font-Size="11px"
            PageSize="10"  
            OnRowCommand="dgvReportAdic_RowCommand"
            >
             <HeaderStyle BackColor="#1E3561" Font-Bold="True" ForeColor="White" />
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
             <Columns>
                 <%-- Index 0 --%>
                 <asp:BoundField DataField="REPORTID" HeaderText="" ReadOnly="True" Visible="true" ItemStyle-CssClass="SupHiddenCol" HeaderStyle-CssClass="SupHiddenCol">
                    </asp:BoundField>
                 <%-- Index 1 --%>
                 <asp:BoundField DataField="REPGROUP" HeaderText="" ReadOnly="True" Visible="true" ItemStyle-CssClass="SupHiddenCol" HeaderStyle-CssClass="SupHiddenCol">
                    </asp:BoundField>
                 <%-- Index 2 --%>  
                 <asp:BoundField DataField="REPNAME" HeaderText="Report Name" SortExpression="REPNAME"  HeaderStyle-Width="200px"  ItemStyle-Width="200px" >
                    </asp:BoundField>
                 <%-- Index 3 --%>  
                 <asp:BoundField DataField="RESUME" HeaderText="Objective" SortExpression="RESUME" >
                    </asp:BoundField>
                 <%-- Index 4 --%>
                 <asp:TemplateField ShowHeader="False" HeaderStyle-Width="10px" ItemStyle-Width="10px">
                      <ItemTemplate>
                          <asp:Button ID="btnOpen" runat="server"
                                      CommandName="BaseData"
                                      CommandArgument="<%# CType(Container, GridViewRow).RowIndex %>"
                                      Text="Open" />
                          </ItemTemplate>
                       </asp:TemplateField>
             </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="REPAdicDs" runat="server" ConnectionString="<%$ ConnectionStrings:SESTicketReportConnStr %>" 
            SelectCommand ="EXECUTE [sp_ReportList] 'Adic' " >
        </asp:SqlDataSource>

    </asp:Panel>



</asp:Content>
