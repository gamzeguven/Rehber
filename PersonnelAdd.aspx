<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonnelAdd.aspx.cs" Inherits="Rehber.PersonnelAdd" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Yeni Personel Bilgisi Ekleyin</h2>
   
   <asp:DetailsView ID="PersonnelDetailsView" runat="server" 
        DataSourceID="EntityDataSource1" AutoGenerateRows="False"
        DefaultMode="Insert" DataKeyNames="RegisterID" AllowPaging="True" OnPageIndexChanging="PersonnelDetailsView_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="RegisterID" HeaderText="RegisterID" 
                SortExpression="RegisterID" ReadOnly="True" />
            <asp:BoundField DataField="DepartmentID" HeaderText="DepartmentID" 
                SortExpression="DepartmentID" />
            <asp:BoundField DataField="TitleID" HeaderText="TitleID" 
                SortExpression="TitleID" />
             <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            <asp:CommandField ShowInsertButton="true" />
       </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>

    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=SMEntities" DefaultContainerName="SMEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="PERSONNELCATALOGs">
    </asp:EntityDataSource>

</asp:Content>