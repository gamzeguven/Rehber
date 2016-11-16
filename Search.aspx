<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Rehber.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 

     <br />
     <br />
     <br />
 

     <asp:TextBox ID="txtSearch" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:button id="button1" runat="server" text="search"/>
<hr />
     <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=SMEntities" DefaultContainerName="SMEntities" EnableFlattening="False" EntitySetName="PERSONNELCATALOGs" Select="it.[Name], it.[Surname], it.[RegisterID]">
</asp:EntityDataSource>
<asp:GridView ID="SearchGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="EntityDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="SearchGridView_SelectedIndexChanged">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
        <asp:BoundField DataField="Surname" HeaderText="Surname" ReadOnly="True" SortExpression="Surname" />
        <asp:BoundField DataField="RegisterID" HeaderText="RegisterID" ReadOnly="True" SortExpression="RegisterID" />
    </Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
<br />

</asp:Content>
