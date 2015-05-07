<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/Registro.css" type="text/css" rel="stylesheet"/>
    <fieldset style="border:0px">
        <legend class="cabecera">Introduce tus datos</legend>
        
        <p><label class="labelCampo">Usuario</label></p>
            <p> <input class="cajaText" id="usuario" name="Usuario" type="text" /></p>

        <p> <label class="labelCampo">Nombre</label></p>
             <p><input class="cajaText" id="nombre" name="Nombre" type="text" /></p>

         <p><label class="labelCampo">Apellidos</label></p>
             <p><input class="cajaText" id="apellidos" name="Apellidos" type="text" /></p>

         <p><label class="labelCampo">Email</label></p>
            <p> <input class="cajaText" id="email" name="Email" type="text" /></p>

         <p><label class="labelCampo">DNI</label></p>
            <p> <input class="cajaText" id="dni" name="DNI" type="text" /></p>

         <p><label class="labelCampo">Direccion</label></p>
            <p> <input class="cajaText" id="direccion" name="Direccion" type="text" /></p>

        <p> <label class="labelCampo">Ciudad</label></p>
            <p> <input class="cajaText" id="ciudad" name="Ciudad" type="text" /></p>

        <p> <label class="labelCampo">Pais</label></p>
            <p> <input class="cajaText" id="pais" name="Pais" type="text" /></p>

        <p> <label class="labelCampo">Telefono</label></p>
            <p> <input class="cajaText" id="telefon" name="Telefono" type="text" /></p>

       <p> <label class="labelCampo">Interesado</label></p>
             <p><input class="cajaText" id="interesado" name="Interesado" type="text" /></p>

       <p> <label class="labelCampo">Fecha Nacimiento</label></p>
            <p> <input class="cajaText" id="fecha" name="Fecha" type="date" /></p>
    </fieldset>
</asp:Content>
