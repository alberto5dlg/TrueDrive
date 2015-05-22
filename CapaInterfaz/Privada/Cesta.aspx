<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Cesta.aspx.cs" Inherits="CapaInterfaz.Cesta" enableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/Cesta.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id="form1">
    <div >
        <h3><asp:Label ID="precio" class ="InfoPrecio" runat="server"></asp:Label></h3>
    </div>

    <ul class="lProducts">
                        <asp:ListView ID="ListProducts" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="productContainer">
                                        <div class="productImage">
                                            <img src="../Styles/images/products/<%#Eval("imagen")%>" />
                                        
                                            <div >
                                                <asp:ImageButton ID="borrar" runat="server" ImageUrl="../Styles/images/deleteButton.png" CommandArgument='<%#Eval("Matricula")%>' OnClick="Delete_Click"/>
                                            </div>
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
    </form>
</asp:Content>
