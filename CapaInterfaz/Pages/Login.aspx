<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaInterfaz.Paginas.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
     <div style="padding-top:20px;" class ="contentWrapper">
        <h1  class="headerWrap">Accede con tus datos</h1>
        <div style="float:left; padding-left:35%;width:42%;padding-top:15px;padding-bottom:5px;" class =" contentInside">
            <ul style="list-style:none;" id="listaregistro1">
                  <li id="Usuario">
                     <label class="registerLabel">Usuario</label>
                        <input id="Text1" name="Usuario" type="text" class="textBoxUserAccount" />
                 </li>
                  <li id="Contrasenya">
                     <label class="registerLabel">Contraseña</label>
                        <input id="Text2" name="Contrasenya" type="password" class="textBoxUserAccount" />
                 </li>
                </ul>
        </div>
         <div style="float:left; padding-left:30%;width:42%;padding-bottom:15px;" class =" contentInside">
             <input  type="button" id="registrarbutton" value="Acceder" class="buttonGreat buttonMedium" />
         </div>
    </div>
</asp:Content>
