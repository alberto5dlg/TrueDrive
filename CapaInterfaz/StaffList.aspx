<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="CapaInterfaz.StaffList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
    <link href="Styles/Products.css" type="text/css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <ul class="lProducts" style="margin-left:20px;">
        <asp:ListView ID="ListProducts" runat="server">
            <ItemTemplate>
                <li style="float: left;list-style:none;width:20%;margin-right: 60px;">
                    <div class="productData" style="text-align:center;margin-right:20px;padding:10px;">
                        <p><label>Dni: <%#Eval("dni")%></label></p>
                        <p><label>Nombre: <%#Eval("nombre")%></label></p>
                        <p><label>Apellidos: <%#Eval("apellidos")%></label></p>
                        <p><label>Direccion: <%#Eval("direccion")%></label></p>
                        <p><label>numContaco: <%#Eval("numContacto")%></label></p>
                        <p><label>Email: <%#Eval("email")%></label></p>
                        <p><label>Usuario: <%#Eval("usuario")%></label></p>
                        <p><label>pASS: <%#Eval("pass")%></label></p>

                        <div style="background: white;width: 100%;text-align: center;padding: 10px;width:90%;">
                            <asp:HyperLink ID="HyperLink" runat="server"
                                NavigateUrl='<%# String.Format("~/Staff.aspx?dni={0}", Eval("dni")) %>' Text="Refuse">
                                    VER FICHA
                            </asp:HyperLink>
                        </div>
                    </div>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </ul>
</asp:Content>
