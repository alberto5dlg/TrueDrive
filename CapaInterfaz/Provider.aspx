<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="Provider.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <fieldset class="cajaPrincipal">
    <legend style="font-size:22px;"> FICHA PROVEEDOR </legend>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> CIF </legend>
        <input name="cif" type="text" id="Cif" class="inputDatos" />
    </fieldset>
    <fieldset class="cajonesFlotantes"">
        <legend class="etiquetaCajon"> Empresa </legend>
        <input name="empresa" type="text" id="Empresa" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> Ciudad </legend>
        <input name="Ciudad" type="text" id="Ciudad" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> C.P. </legend>
        <input name="codP" type="text" id="CP" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> Direccion </legend>
        <input name="direccion" type="text" id="Text1" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> Pais </legend>
            <input name="pais" type="text" id="Text2" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> Teléfono </legend>
        <input name="telefono" type="text" id="Text3" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> Fax</legend>
        <input type="text" name="fax" id="Fax" class="inputDatos"/>
    </fieldset>
    <fieldset class="cajonesFlotantes">
        <legend class="etiquetaCajon"> Email</legend>
        <input name="email" type="text" id="Email" class="inputDatos"/>
    </fieldset>
</fieldset>

<div class="cajaTresBotones">
    <div class="botonInsertar">
        <a href="/Paginas/insertarCliente.aspx?idCliente=$id">
            <img src="../Styles/images/insertar.png" style="width:30%;">  </img>
        </a>
        Insertar
    </div>
    <div class="botonModificar">
        <a href="/Paginas/modificarCliente.aspx?idCliente=$id">
            <img src="../Styles/images/modificar.png" style="width: 30%;"></img>
        </a>
        Modificar
    </div>
    <div class="botonBorrar">
        <a href="/Paginas/borrarCliente.aspx?idCliente=$id">
            <img src="../Styles/images/borrar.png" style="width:30%;"></img>
        </a>
        Borrar
    </div>
</div>
</asp:Content>
