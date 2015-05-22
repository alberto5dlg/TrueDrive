<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="CarsList.aspx.cs" Inherits="CapaInterfaz.CarsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
    <link href="Styles/Products.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <ul class="lProducts" style="margin-left:20px;">
        <asp:ListView ID="ListProducts" runat="server">
            <ItemTemplate>
                <li style="float: left;list-style:none;width:20%;margin-right: 60px;">
                    <div class="productImage" style="min-height:150px;width: 300px;padding-left: 20px;margin-right: 20px;">
                        <img src="../Styles/images/products/<%#Eval("imagen")%>" style="height:143px;"/>
                    </div>
                    <div class="productData" style="text-align:center;margin-right:20px;padding:10px;">
                        <p><label>Matricula: <%#Eval("Matricula")%></label></p>
                        <p><label>Marca: <%#Eval("Marca")%></label></p>
                        <p><label>Modelo: <%#Eval("Modelo")%></label></p>
                        <p><label>Puertas: <%#Eval("Puertas")%></label></p>
                        <p><label>Motor: <%#Eval("Motor")%></label></p>
                        <p><label>Km: <%#Eval("Km")%></label></p>
                        <p><label>Anyo: <%#Eval("Anyo")%></label></p>
                        <p><label>Tipo: <%#Eval("Tipo")%></label></p>
                        <p><label>Plazas: <%#Eval("Plazas")%></label></p>
                        <p><label>Cambio: <%#Eval("Cambio")%></label></p>
                        <p><label>Color: <%#Eval("Color")%></label></p>

                        <div style="background: white;width: 100%;text-align: center;padding: 10px;width:90%;">
                            <asp:HyperLink ID="HyperLink" runat="server"
                                NavigateUrl='<%# String.Format("~/Cars.aspx?matricula={0}", Eval("Matricula")) %>' Text="Refuse">
                                    VER FICHA
                            </asp:HyperLink>
                        </div>
                    </div>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </ul>
</asp:Content>
