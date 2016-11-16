<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentForm.aspx.cs" Inherits="Rehber.DepartmentForm" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Departman Listesi</h2>
    <asp:EntityDataSource ID="DepartmentsEntityDataSource" runat="server" ConnectionString="name=SMEntities" DefaultContainerName="SMEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="DEPARTMENTs"></asp:EntityDataSource>
    <br />
    Bir departman Seciniz:<br />
    <br />
<asp:DropDownList ID="DepartmentsDropDownList" runat="server" DataSourceID="DepartmentsEntityDataSource" DataTextField="DepartmentName" DataValueField="DepartmentID"></asp:DropDownList>
   
  
</asp:Content>
