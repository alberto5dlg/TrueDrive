<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="SellCar.aspx.cs" Inherits="CapaInterfaz.Privada.SellCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form22" runat="server" method="post" >
     <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
     <!-- caja de campo de datos-->
     <div style="padding-top:20px;" class ="contentWrapper" runat="server" >
        <h1  class="headerWrap">Introduce los datos de tu coche</h1>
        <!--Primera caja de campo de datos-->
         <div runat="server" style="float:left; padding-left:100px;width:42%;padding-top:30px;" class =" contentInside">
             <ul style="list-style:none;" id="listaregistro1">
                  <li id="MarcaCoche">
                     <label class="registerLabel">Marca</label>
                        <input id="Marca" name="marca" type="text" class="textBoxUserAccount" />
                 </li>
                  <li id="ModeloCoche">
                     <label class="registerLabel">Modelo</label>
                        <input id="Modelo" name="Modelo" type="text" class="textBoxUserAccount" />
                 </li>
                 <li id="PrecioVenta">
                     <label class="registerLabel">Precio</label>
                        <input id="Precio" name="precio" type="text" class="textBoxUserAccount" />
                 </li>
                   <li id="Puerta">
                     <label class="registerLabel">Puertas</label>
                        <input id="Puertas" name="Puertas" type="text" class="textBoxUserAccount" />
                 </li>
                 <li id="Matriculas">
                     <label class="registerLabel">Matricula</label>
                        <input id="Matricula" name="Matricula" type="text" class="textBoxUserAccount" />
                 </li>
                  <li id="Motors">
                     <label class="registerLabel">Motor</label>
                        <input id="Motor" name="Motor" type="text" class="textBoxUserAccount" />
                 </li>
                 <li>
                     <label class="registerLabel">Imagen</label>
                     <input type="file" id="file1" runat="server" class="textBoxUserAccount" />
                     <asp:Label ID="Label1" CssClass="registerLabel" runat="server"></asp:Label>
                 </li>
             </ul>
        </div>

        <!--Segunda caja de campo de datos-->
        <div style="float:left;width:42%;padding-top:30px;" class="contentInside">
            <ul id="listaregistro2">
                  <li id="Kms">
                     <label class="registerLabel">Km's</label>
                        <input id="Km" name="Km" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="anyo">
                     <label class="registerLabel">Año</label>
                        <input id="Anyos" name="anyo" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="cambio">
                     <label class="registerLabel">Cambio</label>
                    <select name="Cambio" id="Cambio" class ="textBoxUserAccount">
                        <option value="nada"> </option>
                      <option value="Automático">Automático</option>
                      <option value="Manual">Manual</option>
                    </select>  
                        
                 </li>
                <li id="Plazas">
                     <label class="registerLabel">Plazas</label>
                        <input id="Plaza" name="plazas" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="tipo">
                     <label class="registerLabel">Tipo</label>
                    <select name="Tipo" id="Tipo" class ="textBoxUserAccount">
                        <option value="nada"> </option>
                      <option value="Hibrido">Híbrido</option>
                      <option value="Electrico">Eléctrico</option>
                    </select>                       
                 </li>
                <li id="clor">
                     <label class="registerLabel">Color</label>
                        <input id="Color" name="Color" type="color" class="textBoxUserAccount" />
                 </li>
            </ul>
        </div>
         <div style="float:left; padding-left:100px;padding-top:10px;" class="contentInside">
             <asp:CheckBox ID="CheckBox1" Checked="False" runat="server" /> He leido y acepto los términos y condiciones.
             <asp:Label ID="lab1" CssClass="registerLabel" BackColor="Red" runat="server" ></asp:Label>
         </div>
         <div  style="float:left; padding-left:100px;padding-bottom:30px;" class="contentInside buttonGreat buttonMedium">
            <asp:ImageButton ID="vender"  runat="server" OnClick="Button_click" ImageUrl="../Recursos/Vender.JPG" />  
             
        </div>
   </div>
        </form>
</asp:Content>
