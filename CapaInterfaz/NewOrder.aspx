<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="NewOrder.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <div class="cajaPrincipal1">
        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Pedido </span>
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Fecha de envío </legend>
                <input name="fechaEnvio" type="text" id="FechaEnvio" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes"">
                <legend class="etiquetaCajon"> Fecha de entrega </legend>
                <input name="fechaEntrega" type="text" id="FechaEntrega" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Proveedor </legend>
                <input name="proveedor" type="text" id="Proveedor" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Producto </legend>
                <input name="producto" type="text" id="Producto" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Cantidad </legend>
                <input name="cantidad" type="text" id="Cantidad" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Dirección de envio </legend>
                <input name="direccionEnvio" type="text" id="DireccionEnvio" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Dirección de entrega </legend>
                <input name="direccionEntrega" type="text" id="DireccionEntrega" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Email </legend>
                <input name="email" type="text" id="Email" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Precio </legend>
                <input name="precio" type="text" id="Precio" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes" style="width:90%;">
                <legend class="etiquetaCajon"> Información adicional </legend>
                <input name="infoAdicional" type="text" id="InfoAdicional" class="inputDatos"/>
            </fieldset>
        </div>
    </div>
    <div class="cajaPrincipal2">
        <div style="background:#444242;color:white;padding:10px;text-align:center;">
            <span style="font-size:25px;color:white;"> Acciones </span>
        </div>
        <div style="padding:50px;">
            <div class="botonInsertar">
                <a href="/Paginas/insertarPedido.aspx?idPedido=$id">
                    <img src="../Styles/images/insertar.png" style="width: 100%;"></img>
                </a>
            </div>
        </div>
    </div>
</asp:Content>
