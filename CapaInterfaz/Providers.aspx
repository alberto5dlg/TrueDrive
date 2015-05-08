<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="Providers.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <div class="cajaPrincipal1">
        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Proveedor </span>
        </div>
        <div style="padding:50px;">
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
                <input name="direccion" type="text" id="Direccion" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Pais </legend>
                    <input name="pais" type="text" id="Pais" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Teléfono </legend>
                <input name="telefono" type="text" id="Telefono" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Fax</legend>
                <input type="text" name="fax" id="Fax" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Email</legend>
                <input name="email" type="text" id="Email" class="inputDatos"/>
            </fieldset>
        </div>
    </div>

    <div class="cajaPrincipal2">
        <div style="background:#444242;color:white;padding:10px;text-align:center;">
            <span style="font-size:25px;color:white;"> Acciones </span>
        </div>
        <div style="padding:50px;">
            <div class="botonModificar">
                <a href="/Paginas/modificarCliente.aspx?idCliente=$id">
                    <img src="../Styles/images/modificar.png" style="width: 100%;"></img>
                </a>
            </div>
            <div class="botonBorrar">
                <a href="/Paginas/borrarCliente.aspx?idCliente=$id">
                    <img src="../Styles/images/borrar.png" style="width:100%;"></img>
                </a>
            </div>
        </div>
    </div>
</asp:Content>
