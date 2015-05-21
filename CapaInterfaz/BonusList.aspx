<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="BonusList.aspx.cs" Inherits="CapaInterfaz.BonusList" %>
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
                            <p><label>Id: <%#Eval("idBonificacion")%></label></p>
                            <p><label>Descripción: <%#Eval("descripcion")%></label></p>
                            <p><label>Cantidad Bonificada: <%#Eval("cantidadBonificacion")%></label></p>
                            <p><label>Franja: <%#Eval("franja")%></label></p>
                        </div>
                    </div>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </ul>
</asp:Content>
