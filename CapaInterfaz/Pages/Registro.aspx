<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CapaInterfaz.Pages.Registro" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
    <form runat="server" id="form1">
    <!-- caja de campo de datos-->
     <div style="padding-top:20px;" class ="contentWrapper" runat="server">
        <h1  class="headerWrap">Introduce tus datos</h1>
        <!--Primera caja de campo de datos-->
        
         <div style="float:left; padding-left:100px;width:42%;padding-top:30px;" class =" contentInside" runat="server">
             <ul style="list-style:none;" id="listaregistro1" runat="server">
                  <li runat="server" id="usurio">
                     <label class="registerLabel">Usuario</label>
                        <asp:TextBox runat="server" id="Usuario" CssClass="textBoxUserAccount" />
                 </li>
                  <li id="Contrasenya">
                     <label class="registerLabel">Contraseña</label>
                        <asp:TextBox runat="server" TextMode="Password" id="contrasenya"  CssClass="textBoxUserAccount" />
                 </li>
                 <li id="Nombre">
                     <label class="registerLabel">Nombre</label>
                        <asp:TextBox runat="server" id="nombre"  CssClass="textBoxUserAccount" />
                 </li>
                   <li id="Apellidos">
                     <label class="registerLabel">Apellidos</label>
                        <asp:TextBox runat="server" id="apellidos"  CssClass="textBoxUserAccount" />
                 </li>
                 <li id="nif">
                     <label class="registerLabel">Dni</label>
                        <asp:TextBox runat="server" id="dni" CssClass="textBoxUserAccount" />
                 </li>
                  <li id="E-mail">
                     <label class="registerLabel">E-mail</label>
                        <asp:TextBox runat="server" id="email" CssClass="textBoxUserAccount" />
                 </li>
                 <li id="FechaNac">
                     <label class="registerLabel">Fecha de Nacimiento</label>
                        <asp:TextBox runat="server" id="fecnac"  CssClass="textBoxUserAccount" />
                 </li>
             </ul>
        </div>

        <!--Segunda caja de campo de datos-->
        <div style="float:left;width:42%;padding-top:30px;" class="contentInside">
            <ul id="listaregistro2">
                  <li id="dir">
                     <label class="registerLabel">Dirección</label>
                        <asp:TextBox runat="server" id="direccion"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="ciud">
                     <label class="registerLabel">Ciudad</label>
                        <asp:TextBox runat="server" id="Ciudad"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="cp">
                     <label class="registerLabel">Cod. Postal</label>
                        <asp:TextBox runat="server" id="codp"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="prov">
                     <label class="registerLabel">Provincia</label>
                        <asp:TextBox runat="server" id="Provincia"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="pais">
                     <label class="registerLabel">Pais</label>
                        <asp:TextBox runat="server" id="Pais"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="Tlfo">
                     <label class="registerLabel">Teléfono</label>
                        <asp:TextBox runat="server" id="telefono"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="Interesado">
                     <label class="registerLabel">Interesado en</label>
                        <asp:TextBox runat="server" id="interesado"  CssClass="textBoxUserAccount" />
                 </li>
            </ul>
        </div>
         <div style="float:left; padding-left:100px;padding-top:10px;" class="contentInside">
             <input type="checkbox" name="your-group" value="unit-in-group" /> He leido y acepto los términos y condiciones.
         </div>
        <div  style="float:left; padding-left:100px;padding-bottom:30px;" class="contentInside buttonGreat buttonMedium">
            <asp:Button ID="registrar"  Text="Registrar" runat="server" CssClass="buttonMedium buttonGreat" OnClick="registrar_Click" />
        </div>
     
   </div>
    </form> 
</asp:Content>
