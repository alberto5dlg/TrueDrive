<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="NewClient.aspx.cs"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <div class="cajaPrincipal1">
        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Cliente </span>
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> NIF </legend>
                <input name="nif" type="text" id="Nif" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes"">
                <legend class="etiquetaCajon"> Nombre </legend>
                <input name="nombre" type="text" id="Nombre" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Apellidos </legend>
                <input name="apellidos" type="text" id="Apellidos" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Email </legend>
                <input name="email" type="text" id="Email" class="inputDatos"/>
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
                <legend class="etiquetaCajon"> Interesado en </legend>
                <input type="text" name="interesadoEn" id="InteresadoEn" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Fecha de nacimiento </legend>
                <input name="fechaNac" type="date" id="FechaNac" class="inputDatos"/>
            </fieldset>
        </div>
    </div>
    <div class="cajaPrincipal2">
        <div style="background:#444242;color:white;padding:10px;text-align:center;">
            <span style="font-size:25px;color:white;"> Acciones </span>
        </div>
        <div style="padding:50px;">
            <div class="botonInsertar">
                <a href="/Paginas/insertarCliente.aspx?idCliente=$id">
                    <img src="../Styles/images/insertar.png" style="width: 100%;"></img>
                </a>
            </div>
        </div>
    </div>
</asp:Content>
