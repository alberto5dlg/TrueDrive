<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="CapaInterfaz.Pages.Productos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
    
    <div style="margin-top:50px;">
         <div style="float: left; padding-left: 13%; padding-bottom: 30px;margin-left:0px;" class=" buttonGreat buttonMedium hibrido">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Hybrid.aspx" >Híbridos</asp:HyperLink>
        </div>

        <div style="float: left; padding-left: 60px; padding-bottom: 30px;margin-left:0px;" class=" buttonGreat buttonMedium electrico">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Electrics.aspx">Eléctricos</asp:HyperLink>
        </div>
    </div>
       

</asp:Content>
