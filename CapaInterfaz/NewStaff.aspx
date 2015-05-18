<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="NewStaff.aspx.cs" Inherits="CapaInterfaz.NewStaff" %>
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
                    <asp:TextBox ID="Nif" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server"
                        ControlToValidate="Nif"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Nombre </legend>
                    <asp:TextBox ID="Nombre" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="Nombre"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Apellidos </legend>
                    <asp:TextBox ID="Apellidos" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                        ControlToValidate="Apellidos"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes"">
                    <legend class="etiquetaCajon"> Usuario </legend>
                    <asp:TextBox ID="Usuario" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                        ControlToValidate="Usuario"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Contraseña </legend>
                    <asp:TextBox ID="Contrasenya"  CssClass="inputDatos" TextMode="Password" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                        ControlToValidate="Contrasenya"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Email </legend>
                    <asp:TextBox ID="Email" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                        ControlToValidate="Email"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Número de contacto </legend>
                    <asp:TextBox ID="NumContacto" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                        ControlToValidate="NumContacto"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
                <fieldset class="cajonesFlotantes">
                    <legend class="etiquetaCajon"> Dirección </legend>
                    <asp:TextBox ID="Direccion" CssClass="inputDatos" TextMode="SingleLine" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                        ControlToValidate="Direccion"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </fieldset>
            </div>
        </div>
        <div class="cajaPrincipal2">
            <div style="background:#444242;color:white;padding:10px;text-align:center;">
                <span style="font-size:25px;color:white;"> Acciones </span>
            </div>
            <div style="padding:50px;">
                <div class="botonInsertar">
                     <asp:ImageButton runat="server" ID="insertar" ImageUrl="../Styles/images/insertar.png" OnClick="insertStaff_click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
