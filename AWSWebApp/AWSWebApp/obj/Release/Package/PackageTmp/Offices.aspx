<%@ Page Title="Offices" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Offices.aspx.cs" Inherits="AWSWebApp.Offices" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Office Details page.</h2>
    </hgroup>

     <div>
        <h1>Office Details</h1>
    </div>
    <div>
        <asp:GridView ID="OfficeGrid" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="400">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>
    </div>  
    
</asp:Content>