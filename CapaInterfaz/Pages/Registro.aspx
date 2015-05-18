<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CapaInterfaz.Pages.Registro" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
    <form runat="server" id="form1">
    <!-- caja de campo de datos-->
     <div style="padding-top:20px;" class ="contentWrapper" runat="server">
        <h1  class="headerWrap">Introduce tus datos</h1>
        <!--Primera caja de campo de datos-->
        
         <div style="float:left; padding-left:100px;width:42%;padding-top:30px;" class =" contentInside" runat="server">
             <ul style="list-style:none;" id="listaregistro1" runat="server">
                  <li runat="server" id="usurio">
                      <label class="registerLabel">Usuario</label>
                      <asp:TextBox  runat="server" ID="Usuario" CssClass="textBoxUserAccount" />
                      <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator" runat="server"
                          ControlToValidate="Usuario"
                          ErrorMessage="Campo requerido"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                 </li>
                  <li id="Contrasenya">
                      <label class="registerLabel">Contraseña</label>
                      <asp:TextBox runat="server" TextMode="Password" ID="contrasenya" CssClass="textBoxUserAccount" />
                      <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator1" runat="server"
                          ControlToValidate="contrasenya"
                          ErrorMessage="Campo requerido"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                  </li>
                 <li id="Nombre">
                     <label class="registerLabel">Nombre</label>
                     <asp:TextBox runat="server" ID="nombre" CssClass="textBoxUserAccount" />
                     <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator2" runat="server"
                         ControlToValidate="nombre"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
                   <li id="Apellidos">
                       <label class="registerLabel">Apellidos</label>
                       <asp:TextBox runat="server" ID="apellidos" CssClass="textBoxUserAccount" />
                       <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator3" runat="server"
                           ControlToValidate="apellidos"
                           ErrorMessage="Campo requerido"
                           ForeColor="Red">
                       </asp:RequiredFieldValidator>
                 </li>
                 <li id="nif">
                     <label class="registerLabel">Dni</label>
                     <asp:TextBox runat="server" ID="dni" CssClass="textBoxUserAccount" />
                     <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator4" runat="server"
                         ControlToValidate="dni"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
                  <li id="E-mail">
                      <label class="registerLabel">E-mail</label>
                      <asp:TextBox runat="server" ID="email" CssClass="textBoxUserAccount" />
                      <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator5" runat="server"
                          ControlToValidate="email"
                          ErrorMessage="Campo requerido"
                          ForeColor="Red">
                      </asp:RequiredFieldValidator>
                 </li>
                 <li id="FechaNac">
                     <label class="registerLabel">Fecha de Nacimiento</label>
                     <asp:TextBox runat="server" TextMode="Date" ID="fecnac" CssClass="textBoxUserAccount" />
                     <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator6" runat="server"
                         ControlToValidate="fecnac"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
             </ul>
        </div>

        <!--Segunda caja de campo de datos-->
        <div style="float:left;width:42%;padding-top:30px;" class="contentInside">
            <ul id="listaregistro2">
                  <li id="dir">
                      <label class="registerLabel">Dirección</label>
                      <asp:TextBox runat="server" ID="direccion" CssClass="textBoxUserAccount" />
                      <asp:RequiredFieldValidator CssClass="registerLabel"  ID="RequiredFieldValidator7" runat="server"
                         ControlToValidate="direccion"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
                <li id="ciud">
                    <label class="registerLabel">Ciudad</label>
                    <asp:TextBox runat="server" ID="Ciudad" CssClass="textBoxUserAccount" />
                    <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator8" runat="server"
                         ControlToValidate="Ciudad"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
                <li id="cp">
                    <label class="registerLabel">Cod. Postal</label>
                    <asp:TextBox runat="server" id="codp"  CssClass="textBoxUserAccount" />
                    <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator9" runat="server"
                        ControlToValidate="codp"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                 </li>
                <li id="prov">
                    <label class="registerLabel">Provincia</label>
                    <asp:TextBox runat="server" ID="Provincia" CssClass="textBoxUserAccount" />
                    <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator10" runat="server"
                         ControlToValidate="Provincia"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
                <li id="pais">
                    <label class="registerLabel">Pais</label>
                    <asp:TextBox runat="server" id="Pais"  CssClass="textBoxUserAccount" />
                    <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator11" runat="server"
                        ControlToValidate="Pais"
                        ErrorMessage="Campo requerido"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                 </li>
                <li id="Tlfo">
                    <label class="registerLabel">Teléfono</label>
                    <asp:TextBox runat="server" ID="telefono" CssClass="textBoxUserAccount" />
                    <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator12" runat="server"
                         ControlToValidate="telefono"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
                <li id="Interesado">
                    <label class="registerLabel">Interesado en</label>
                    <asp:TextBox runat="server" ID="interesado" CssClass="textBoxUserAccount" />
                    <asp:RequiredFieldValidator CssClass="registerLabel" ID="RequiredFieldValidator13" runat="server"
                         ControlToValidate="interesado"
                         ErrorMessage="Campo requerido"
                         ForeColor="Red">
                     </asp:RequiredFieldValidator>
                 </li>
            </ul>
        </div>
         <div style="float:left; padding-left:100px;padding-top:10px;" class="contentInside">
             <asp:CheckBox ID="CheckBox1" Checked="False" runat="server" /> He leido y acepto los términos y condiciones.
             <asp:Label ID="lab1" CssClass="registerLabel" BackColor="Red" runat="server" ></asp:Label>
         </div>
        <div  style="float:left; padding-left:100px;padding-bottom:30px;" class="contentInside buttonGreat buttonMedium">
            <asp:ImageButton ID="registrar" runat="server" OnClick="registrar_Click" ImageUrl="../Recursos/Registro.JPG" />  
        </div>
     
   </div>
    </form> 

</asp:Content>
