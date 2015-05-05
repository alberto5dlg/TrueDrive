<%@ Page Title="Clients" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Clients.aspx.cs"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<!-- Lo que insertemos en este bloque, se irá al head general de la master. -->

    <link href="../Estilos/PanelDeControl.css" type="text/css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
<!-- Lo que insertemos en este bloque ira al body de la página en particular que estamos desarrollando. -->

     <fieldset class="cajaPrincipal">
        <legend style="font-size:22px;"> FICHA CLIENTE </legend>
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
            <legend class="etiquetaCajon"> Interesado en </legend>
            <input type="text" name="interesadoEn" id="InteresadoEn" class="inputDatos"/>
        </fieldset>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Fecha de nacimiento </legend>
            <input name="fechaNac" type="date" id="FechaNac" class="inputDatos"/>
        </fieldset>
    </fieldset>

    <div class="cajaTresBotones">
        <div class="botonInsertar">
            <a href="/Paginas/insertarCliente.aspx?idCliente=$id">
                <img src="../Estilos/imagenes/insertar.png" style="width:30%;">  </img>
            </a>
            Insertar
        </div>
        <div class="botonModificar">
            <a href="/Paginas/modificarCliente.aspx?idCliente=$id">
                <img src="../Estilos/imagenes/modificar.png" style="width: 30%;"></img>
            </a>
            Modificar
        </div>
        <div class="botonBorrar">
            <a href="/Paginas/borrarCliente.aspx?idCliente=$id">
                <img src="../Estilos/imagenes/borrar.png" style="width:30%;"></img>
            </a>
            Borrar
        </div>
    </div>
</asp:Content>


   
