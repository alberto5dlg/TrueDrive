<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Electrics.aspx.cs" Inherits="CapaInterfaz.Electrics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="lProducts">
                        <asp:ListView ID="ListProducts" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div>
                                        <label><%#Eval("modelo")%></label>
                                        <label><%#Eval("marca")%></label>
                                        <label><%#Eval("precio")%></label>
                                        <img src="../Styles/images/products/<%#Eval("imagen")%>" />
                                    </div>

                                </li>
                            </ItemTemplate>
                        </asp:ListView>
    </ul>
        
        
</asp:Content>
