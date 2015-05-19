<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Cesta.aspx.cs" Inherits="CapaInterfaz.Cesta" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/Products.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label ID="precio" runat="server"></asp:Label>
    </div>

    <ul class="lProducts">
                        <asp:ListView ID="ListProducts" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="productContainer">
                                        <div class="productImage">
                                            <img src="../Styles/images/products/<%#Eval("imagen")%>" />
                                        </div>

                                        <div class="productData">
                                            <p><label>Modelo: <%#Eval("modelo")%></label></p>
                                            <p><label>Marca: <%#Eval("marca")%></label></p>
                                            <p><label>Precio: <%#Eval("precio")%> €</label></p>
                                        </div>

                                    </div>

                                </li>
                            </ItemTemplate>
                        </asp:ListView>
    </ul>
    
</asp:Content>
