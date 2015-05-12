<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="NewStaff.aspx.cs"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <form id="form1" runat="server">
        <div class="cajaPrincipal1">
            <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
                <span style="font-size:25px;color:white;"> Ficha Empleado </span>
            </div>
            <div style="padding:50px;">
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> NIF </legend>
                    <asp:TextBox id="Nif" CssClass="nif" TextMode="SingleLine" Columns="30" runat="server" />
                </fieldset>
                <fieldset class="cajonesFlotantes"">
                    <legend class="etiquetaCajon"> Usuario </legend>
                    <input name="usuario" type="text" id="Usuario" class="inputDatos"/>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Contraseña </legend>
                    <input name="contraseña" type="text" id="contraseña" class="inputDatos"/>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Email </legend>
                    <input name="email" type="text" id="Email" class="inputDatos"/>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Telefono </legend>
                    <input name="telefono" type="text" id="Telefono" class="inputDatos"/>
                </fieldset>
            </div>
        </div>
        <div class="cajaPrincipal2">
            <div style="background:#444242;color:white;padding:10px;text-align:center;">
                <span style="font-size:25px;color:white;"> Acciones </span>
            </div>
            <<div style="padding:50px;">
                <div class="botonInsertar">
                    <asp:Button ID="BotonEnviar" Text="Enviar" runat="server" OnClick="insertStaff_click" />
                    <img src="../Styles/images/insertar.png" style="width: 100%;" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
