<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Hybrid.aspx.cs" Inherits="CapaInterfaz.Hybrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/Products.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <ul class="lProducts">
                        <asp:ListView ID="ListProducts" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="productContainer">
                                        <div class="productImage">
                                            <img src="../Styles/images/products/<%#Eval("imagen")%>" />
                                            <div class="shopButton">
                                                <img src="../Styles/images/shopButton.png" />
                                            </div>
                                        </div>
                                        <div class="productData">
                                            <p><label>Modelo: <%#Eval("modelo")%></label></p>
                                            <p><label>Marca: <%#Eval("marca")%></label></p>
                                            <p><label>Tipo: <%#Eval("tipo")%></label></p>
                                            <p><label>Puertas: <%#Eval("puertas")%></label></p>
                                            <p><label>Cambio: <%#Eval("cambio")%></label></p>
                                            <p><label>Color: <%#Eval("color")%></label></p>
                                            <p><label>Precio: <%#Eval("precio")%> €</label></p>
                                        </div>
                                        
                                        
                                    </div>

                                </li>
                            </ItemTemplate>
                        </asp:ListView>
    </ul>
</asp:Content>
