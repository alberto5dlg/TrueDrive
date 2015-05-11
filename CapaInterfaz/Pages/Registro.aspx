<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" %>

<script runat="server">

    protected void register_Click(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
     <!-- caja de campo de datos-->
     <div style="padding-top:20px;" class ="contentWrapper">
        <h1  class="headerWrap">Introduce tus datos</h1>
        <!--Primera caja de campo de datos-->
         <div style="float:left; padding-left:100px;width:42%;padding-top:30px;" class =" contentInside">
             <ul style="list-style:none;" id="listaregistro1">
                  <li id="Usuario">
                     <label class="registerLabel">Usuario</label>
                        <input runat="server" id="usuario" name="Usuario" type="text" class="textBoxUserAccount"  />
                 </li>
                  <li id="Contrasenya">
                     <label class="registerLabel">Contraseña</label>
                        <input id="contrasenya" name="Contrasenya" type="password" class="textBoxUserAccount" />
                 </li>
                 <li id="Nombre">
                     <label class="registerLabel">Nombre</label>
                        <input id="nombre" name="Nombre" type="text" class="textBoxUserAccount" />
                 </li>
                   <li id="Apellidos">
                     <label class="registerLabel">Apellidos</label>
                        <input id="apellidos" name="Apellidos" type="text" class="textBoxUserAccount" />
                 </li>
                 <li id="nif">
                     <label class="registerLabel">Dni</label>
                        <input id="dni" name="Dni" type="text" class="textBoxUserAccount" />
                 </li>
                  <li id="E-mail">
                     <label class="registerLabel">E-mail</label>
                        <input id="email" name="Email" type="text" class="textBoxUserAccount" />
                 </li>
                 <li id="FechaNac">
                     <label class="registerLabel">Fecha de Nacimiento</label>
                        <input id="fecnac" name="FecNac" type="date" class="textBoxUserAccount" />
                 </li>
             </ul>
        </div>

        <!--Segunda caja de campo de datos-->
        <div style="float:left;width:42%;padding-top:30px;" class="contentInside">
            <ul id="listaregistro2">
                  <li id="dir">
                     <label class="registerLabel">Dirección</label>
                        <input id="direccion" name="Direccion" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="ciud">
                     <label class="registerLabel">Ciudad</label>
                        <input id="ciudad" name="Ciudad" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="cp">
                     <label class="registerLabel">Cod. Postal</label>
                        <input id="codp" name="codigoPostal" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="prov">
                     <label class="registerLabel">Provincia</label>
                        <input id="provincia" name="Provincia" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="pais">
                     <label class="registerLabel">Pais</label>
                        <input id="pais" name="Pais" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="Tlfo">
                     <label class="registerLabel">Teléfono</label>
                        <input id="telefono" name="telefono" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="Interesado">
                     <label class="registerLabel">Interesado en</label>
                        <input id="interesado" name="Interesado" type="text" class="textBoxUserAccount" />
                 </li>
            </ul>
        </div>
         <div style="float:left; padding-left:100px;padding-top:10px;" class="contentInside">
             <input type="checkbox" name="your-group" value="unit-in-group" /> He leido y acepto los términos y condiciones.
         </div>
        <div  style="float:left; padding-left:100px;padding-bottom:30px;" class="contentInside">
             <input runat="server" type="button" id="registrarbutton" value="Registrar" class="buttonGreat buttonMedium" onclick="register_Click" />
        </div>
         
   </div>
    
</asp:Content>
