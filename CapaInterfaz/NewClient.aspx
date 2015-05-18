<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="NewClient.aspx.cs" Inherits="CapaInterfaz.NewClient"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <form runat="server">
    <div class="cajaPrincipal1" style="min-height:750px;">
        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Cliente </span>
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> NIF </legend>
                <input name="nif" type="text" id="Nif" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Usuario </legend>
                <input name="usuario" type="text" id="Usuario" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Contraseña </legend>
                <input name="contra" type="password" id="Contraseña" class="inputDatos" />
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
                <legend class="etiquetaCajon"> Ciudad </legend>
                <input name="nif" type="text" id="Ciudad" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Codigo Postal </legend>
                <input name="codp" type="text" id="Codp" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Provincia </legend>
                <input name="prov" type="text" id="Provincia" class="inputDatos" />
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
                <asp:ImageButton runat="server" ID="insertar" ImageUrl="../Styles/images/insertar.png" OnClick="registrar_Click" />
            </div>
        </div>
    </div>
    </form>
</asp:Content>
