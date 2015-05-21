<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaInterfaz.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <form runat="server" id="form2">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
     <div style="padding-top:20px;" class ="contentWrapper">
        <h1  class="headerWrap">Accede con tus datos</h1>
        <div style="float:left; padding-left:35%;width:42%;padding-top:15px;padding-bottom:5px;" class =" contentInside">
            <ul style="list-style:none;" id="listaregistro1">
                  <li id="Usuarios">
                     <label class="registerLabel">Usuario</label>
                        <asp:TextBox runat="server" id="Usuario" CssClass="textBoxUserAccount" />
                      <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="Pass"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                          </asp:RequiredFieldValidator>
                  </li>
                  <li id="Contrasenya">
                     <label class="registerLabel">Contraseña</label>
                        <asp:TextBox runat="server" TextMode="Password" id="Pass"  CssClass="textBoxUserAccount" />
                      <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator" runat="server"
                        ControlToValidate="Pass"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                  </li>
                </ul>
        </div>
         <div style="float:left; padding-left:30%;width:42%;padding-bottom:15px;" class =" contentInside">
             
             <asp:ImageButton ID="acceder" runat="server" OnClick="Login_Click" CssClass="buttonGreat buttonMedium" ImageUrl="../Recursos/Acceder.JPG" />            
         </div>
    </div>
       </form>
</asp:Content>
