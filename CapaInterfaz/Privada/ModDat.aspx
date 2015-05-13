<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="ModDat.aspx.cs" Inherits="CapaInterfaz.Privada.ModDat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
    <form runat="server" id="form1">
    <!-- caja de campo de datos-->
     <div id="Div1" style="padding-top:20px;" class ="contentWrapper" runat="server">
        <h1  class="headerWrap">Modifica tus datos</h1>
        <!--Primera caja de campo de datos-->
         <div id="Div2" style="float:left; padding-left:100px;width:42%;padding-top:30px;" class =" contentInside" runat="server">
             <ul style="list-style:none;" id="listaregistro1" runat="server">
                  <li runat="server" id="usurio">
                     <label class="registerLabel">Usuario</label>
                        <asp:TextBox runat="server" id="Usuario" CssClass="textBoxUserAccount" />
                 </li>
                  <li id="Pass">
                     <label class="registerLabel">Contraseña</label>
                        <asp:TextBox runat="server" TextMode="Password" id="Contrasenya"  CssClass="textBoxUserAccount" />
                 </li>
                 <li id="nombree">
                     <label class="registerLabel">Nombre</label>
                        <asp:TextBox runat="server" id="Nombre"  CssClass="textBoxUserAccount" />
                 </li>
                   <li id="apell">
                     <label class="registerLabel">Apellidos</label>
                        <asp:TextBox runat="server" id="Apellidos"  CssClass="textBoxUserAccount" />
                 </li>
                 <li id="nif">
                     <label class="registerLabel">Dni</label>
                        <asp:TextBox runat="server" id="Dni" CssClass="textBoxUserAccount" />
                 </li>
                  <li id="E-mail">
                     <label class="registerLabel">E-mail</label>
                        <asp:TextBox runat="server" id="Email" CssClass="textBoxUserAccount" />
                 </li>
                 <li id="FechaNac">
                     <label class="registerLabel">Fecha de Nacimiento</label>
                        <asp:TextBox runat="server" TextMode="Date" id="Fecnac"  CssClass="textBoxUserAccount" />
                 </li>
             </ul>
        </div>

        <!--Segunda caja de campo de datos-->
        <div style="float:left;width:42%;padding-top:30px;" class="contentInside">
            <ul id="listaregistro2">
                  <li id="dir">
                     <label class="registerLabel">Dirección</label>
                        <asp:TextBox runat="server" id="Direccion"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="ciud">
                     <label class="registerLabel">Ciudad</label>
                        <asp:TextBox runat="server" id="Ciudad"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="cp">
                     <label class="registerLabel">Cod. Postal</label>
                        <asp:TextBox runat="server" id="Codp"  CssClass="textBoxUserAccount" />
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
                        <asp:TextBox runat="server" id="Telefono"  CssClass="textBoxUserAccount" />
                 </li>
                <li id="interst">
                     <label class="registerLabel">Interesado en</label>
                        <asp:TextBox runat="server" id="Interesado"  CssClass="textBoxUserAccount" />
                 </li>
            </ul>
        </div>
        <div  style="float:left; padding-left:100px;padding-bottom:30px;" class="contentInside buttonGreat buttonMedium">
            <asp:Button ID="Modificar"  Text="Modificar" runat="server" OnClick="Button_Click"/>  
        </div>
   </div>
    </form> 
</asp:Content>
