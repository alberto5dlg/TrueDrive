<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Electrics.aspx.cs" Inherits="CapaInterfaz.Electrics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <asp:GridView ID="GridElectrico" runat="server" ViewStateMode="Enabled" AllowPaging="true">
        <EmptyDataTemplate><h2> No hay coches electricos </h2></EmptyDataTemplate>
       
    </asp:GridView>
        
        </form>
</asp:Content>
