<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="CapaInterfaz.Staff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    
    <div class="cajaPrincipal1">
        <asp:ListView ID="ListProducts" runat="server">
            <itemtemplate>
                

        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Empleado </span>
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> NIF </legend>
                <input name="nif" type="text" id="Nif" value="<%#Eval("dni")%>" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes"">
                <legend class="etiquetaCajon"> Usuario </legend>
                <input name="usuario" type="text" id="Usuario" value="<%#Eval("usuario")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Contraseña </legend>
                <input name="contraseña" type="text" id="contraseña" value="<%#Eval("pass")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Email </legend>
                <input name="email" type="text" id="Email" value="<%#Eval("email")%>" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Telefono </legend>
                <input name="telefono" type="text" id="Telefono" value="<%#Eval("numContacto")%>" class="inputDatos"/>
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
    
            </itemtemplate>
        </asp:ListView>
</asp:Content>

