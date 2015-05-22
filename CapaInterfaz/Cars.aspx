<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs"  Inherits="CapaInterfaz.Cars"%>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">

     <div class="cajaPrincipal1">
        <asp:ListView ID="ListProducts" runat="server">
            <itemtemplate>

        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Coche </span>
        </div>
        <div class="productImage" style="min-height: 150px; width: 300px; padding-left: 20px; margin-right: 20px;margin-left:32%;margin-top:20px;">
            <img src="../Styles/images/products/<%#Eval("imagen")%>" style="height: 143px;" />
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Matricula </legend>
                <input name="matricula" type="text" id="Matricula" value="<%#Eval("matricula")%>" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes"">
                <legend class="etiquetaCajon"> Marca </legend>
                <input name="marca" type="text" id="Marca" value="<%#Eval("marca")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Modelo </legend>
                <input name="modelo" type="text" id="Modelo" value="<%#Eval("modelo")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Precio* </legend>
                <input name="precio" type="text" id="Precio" value="<%#Eval("precio")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Nº Puertas </legend>
                <input name="puertas" type="text" id="Puertas" value="<%#Eval("puertas")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Motor </legend>
                 <input name="motor" type="text" id="Motor" value="<%#Eval("motor")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Km&#39;s </legend>
                <input name="kms" type="text" id="Kms" value="<%#Eval("km")%>" class="inputDatos"/>
            </fieldset>
             <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Plazas</legend>
                <input name="plazas" type="text" id="Plazas" value="<%#Eval("plazas")%>" class="inputDatos"/>
            </fieldset>
             <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Cambio</legend>
                <input name="cambio" type="text" id="Cambio" value="<%#Eval("cambio")%>" class="inputDatos"/>
            </fieldset>
             <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Color</legend>
                <input name="color" type="color" id="Color" value="<%#Eval("color")%>" class="inputDatos"/>
            </fieldset>
              <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Año</legend>
                <input type="date" name="anyo" id="Anyo" value="<%#Eval("anyo")%>" class="inputDatos"/>
            </fieldset>
        </div>
        <span class ="anotacionespiepag">*El precio introducido es sin IVA, luego se aplicará</span>
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

                
            </itemtemplate>
        </asp:ListView>
</asp:Content>