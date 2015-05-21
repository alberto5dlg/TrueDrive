<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="CapaInterfaz.Pages.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
    <form runat="server">
        <div id="Div1" style=" padding-bottom:20px; padding-top:20px;" class ="contentWrapper" runat="server">
            <h1  class="headerWrap">Contatacte con nosotros</h1>
            <div style="float:left; padding-left:100px;padding-top:10px;" class =" contentInside" runat="server">
                
                 <asp:Label ID="nombrel" runat="server" CssClass="registerLabel">Nombre</asp:Label>
                 <asp:TextBox runat="server" ID="Nombre" CssClass="textBoxUserAccount" Width="400px" />
                <asp:RequiredFieldValidator Font-Size="X-Small" CssClass="registerLabel" ID="RequiredFieldValidator" runat="server"
                          ControlToValidate="Nombre"
                          ErrorMessage="Campo requerido"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                
                <asp:Label ID="apellidol" runat="server" CssClass="registerLabel">Apellidos</asp:Label>
                 <asp:TextBox runat="server" ID="Apellido" CssClass="textBoxUserAccount" Width="400px" />
                <asp:RequiredFieldValidator Font-Size="X-Small" CssClass="registerLabel" ID="RequiredFieldValidator1" runat="server"
                          ControlToValidate="Apellido"
                          ErrorMessage="Campo requerido"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                
                <asp:Label ID="emaill" runat="server" CssClass="registerLabel">Email</asp:Label>
                 <asp:TextBox runat="server" ID="Email" TextMode="Email" CssClass="textBoxUserAccount" Width="400px" />
                <asp:RequiredFieldValidator Font-Size="X-Small" CssClass="registerLabel" ID="RequiredFieldValidator2" runat="server"
                          ControlToValidate="Email"
                          ErrorMessage="Campo requerido"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>

                <asp:Label ID="Label1" runat="server" CssClass="registerLabel">Asunto</asp:Label>
                 <asp:TextBox runat="server" ID="Asunto" CssClass="textBoxUserAccount" Width="400px" />
                <asp:RequiredFieldValidator Font-Size="X-Small" CssClass="registerLabel" ID="RequiredFieldValidator3" runat="server"
                          ControlToValidate="Asunto"
                          ErrorMessage="Es necesario el tema de la consulta"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                
                <asp:Label ID="consultal" runat="server" CssClass="registerLabel">Consulta</asp:Label>
                 <asp:TextBox  runat="server" ID="Consulta" CssClass="textBoxUserAccount" Height="100px" TextMode="MultiLine"  VerticalScrollBarVisibility="Visible" />
                <asp:RequiredFieldValidator Font-Size="X-Small" CssClass="registerLabel" ID="RequiredFieldValidator4" runat="server"
                          ControlToValidate="Consulta"
                          ErrorMessage="Es importante la descripcion completa de la consulta"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                
                <div style="float:left; padding-left:250px;padding-top:15px" class="contentInside">
                    <asp:ImageButton ImageUrl="../Recursos/Enviar.JPG" ID="Enviar" runat="server" OnClick="Button_click" />
                    <asp:Label ID="Final" runat="server" CssClass="registerLabel"></asp:Label>
                </div>
                       
            </div>
       </div>
    </form>
  

</asp:Content>
