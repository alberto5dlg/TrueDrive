<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="ClientMenu.aspx.cs" Inherits="CapaInterfaz.Formulario_web114" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
    <div style="padding-top:20px;" class ="contentWrapper">
         <h1  class="headerWrap">Mi Cuenta</h1>
         <div style="float:left; padding-left:100px;width:42%;padding-top:30px;padding-bottom:30px;" class =" contentInside">
            <ul style="list-style:none;">
                 <li>
                     <a class="registerLabel"; href="../Privada/SellCar.aspx" rel="external"><font size ="3"> Vendenos tu coche</font></a>
                </li>
                <li>
                     <a class="registerLabel"; href="../Privada/ModDat.aspx" rel="external"><font size ="3"> Modifica tus datos</font></a>
                </li>
                <li>
                     <a class="registerLabel"; href="../Pages/Home.aspx" rel="external"><font size ="3"> Mi Cesta</font></a>
                </li>
                <li>
                     <a class="registerLabel"; href="../Pages/Home.aspx" rel="external"><font size ="3"> Mi lista de favoritos</font></a>
                </li>
                <li>
                     <a class="registerLabel"; href="../Pages/Home.aspx" rel="external"><font size ="3"> Cerrar Sesión</font></a>
                </li>
            </ul>
         </div>
    </div>
   
</asp:Content>
