<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="CapaInterfaz.StaffList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
    <link href="Styles/Products.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <ul class="lProducts">
        <asp:ListView ID="ListProducts" runat="server">
            <ItemTemplate>
                <li>
                    <div class="productContainer">
                        <div class="productImage">
                            <div class="shopButton">
                                <img src="Styles/images/shopButton.png" />
                            </div>
                        </div>
                        <div class="productData">
                            <p><label>Dni: <%#Eval("dni")%></label></p>
                            <p><label>Nombre: <%#Eval("nombre")%></label></p>
                            <p><label>Apellidos: <%#Eval("apellidos")%></label></p>
                            <p><label>Direccion: <%#Eval("direccion")%></label></p>
                            <p><label>numContaco: <%#Eval("numContacto")%></label></p>
                            <p><label>Email: <%#Eval("email")%></label></p>
                            <p><label>Usuario: <%#Eval("usuario")%></label></p>
                            <p><label>pASS: <%#Eval("pass")%></label></p>
                        </div>
                    </div>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </ul>
</asp:Content>
