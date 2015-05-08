<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="Bonuses.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <div class="cajaPrincipal1">
        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Bonificación </span>
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Descripción </legend>
                <input name="descripcion" type="text" id="Descripcion" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes"">
                <legend class="etiquetaCajon"> Precio </legend>
                <input name="precio" type="text" id="Precio" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Franja </legend>
                <input name="franja" type="text" id="Franja" class="inputDatos"/>
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

    
