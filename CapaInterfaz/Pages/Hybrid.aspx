<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Hybrid.aspx.cs" Inherits="CapaInterfaz.Hybrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server">
    <asp:GridView ID="GridHibrido" runat="server" ViewStateMode="Enabled" AllowPaging="true">
        <EmptyDataTemplate><h2> No hay coches hibridos </h2></EmptyDataTemplate>
       
    </asp:GridView>
        
        </form>
</asp:Content>
