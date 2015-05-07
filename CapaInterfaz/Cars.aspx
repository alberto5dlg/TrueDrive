<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <fieldset class="cajaPrincipal">
        <legend style="font-size:22px;"> FICHA COCHE </legend>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Matricula </legend>
            <input name="matricula" type="text" id="Matricula" class="inputDatos" />
        </fieldset>
        <fieldset class="cajonesFlotantes"">
            <legend class="etiquetaCajon"> Marca </legend>
            <input name="marca" type="text" id="Marca" class="inputDatos"/>
        </fieldset>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Modelo </legend>
            <input name="modelo" type="text" id="Modelo" class="inputDatos"/>
        </fieldset>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Precio* </legend>
            <input name="precio" type="text" id="Precio" class="inputDatos"/>
        </fieldset>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Nº Puertas </legend>
            <input name="puertas" type="text" id="Puertas" class="inputDatos"/>
        </fieldset>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Motor </legend>
             <input name="motor" type="text" id="Motor" class="inputDatos"/>
        </fieldset>
        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Km&#39;s </legend>
            <input name="kms" type="text" id="Text3" class="inputDatos"/>
        </fieldset>

        <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Combustible</legend>
            <input name="combustible" type="text" id="Combustible" class="inputDatos"/>
        </fieldset>
         <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Plazas</legend>
            <input name="plazas" type="text" id="Plazas" class="inputDatos"/>
        </fieldset>
         <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Cambio</legend>
            <input name="cambio" type="text" id="Cambio" class="inputDatos"/>
        </fieldset>
         <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Color</legend>
            <input name="color" type="color" id="Color" class="inputDatos"/>
        </fieldset>
          <fieldset class="cajonesFlotantes">
            <legend class="etiquetaCajon"> Año</legend>
            <input type="date" name="anyo" id="Anyo" class="inputDatos"/>
        </fieldset>
              
    </fieldset>
    <span class ="anotacionespiepag">*El precio introducido es sin IVA, luego se aplicará</span>
    <div class="cajaTresBotones">
        <div class="botonInsertar">
            <a href="/Paginas/insertarCliente.aspx?idCliente=$id">
                <img src="../Styles/images/insertar.png" style="width:30%;"/>
            </a>
            Insertar
        </div>
        <div class="botonModificar">
            <a href="/Paginas/modificarCliente.aspx?idCliente=$id">
                <img src="../Styles/images/modificar.png" style="width: 30%;"/>
            </a>
            Modificar
        </div>
        <div class="botonBorrar">
            <a href="/Paginas/borrarCliente.aspx?idCliente=$id">
                <img src="../Styles/images/borrar.png" style="width:30%;"/>
            </a>
            Borrar
        </div>
    </div>
</asp:Content>