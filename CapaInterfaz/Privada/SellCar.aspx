<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="SellCar.aspx.cs" Inherits="CapaInterfaz.Formulario_web113" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/RegisterStyle.css" type="text/css" rel="stylesheet"/>
     <!-- caja de campo de datos-->
     <div style="padding-top:20px;" class ="contentWrapper">
        <h1  class="headerWrap">Introduce los datos de tu coche</h1>
        <!--Primera caja de campo de datos-->
         <div style="float:left; padding-left:100px;width:42%;padding-top:30px;" class =" contentInside">
             <ul style="list-style:none;" id="listaregistro1">
                  <li id="MarcaCoche">
                     <label class="registerLabel">Marca</label>
                        <input id="marca" name="marca" type="text" class="textBoxUserAccount" />
                 </li>
                  <li id="ModeloCoche">
                     <label class="registerLabel">Modelo</label>
                        <input id="modelo" name="Modelo" type="password" class="textBoxUserAccount" />
                 </li>
                 <li id="PrecioVenta">
                     <label class="registerLabel">Precio</label>
                        <input id="Precio" name="precio" type="text" class="textBoxUserAccount" />
                 </li>
                   <li id="Puertas">
                     <label class="registerLabel">Puertas</label>
                        <input id="puertas" name="Puertas" type="text" class="textBoxUserAccount" />
                 </li>
                 <li id="Matricula">
                     <label class="registerLabel">Matricula</label>
                        <input id="matricula" name="Matricula" type="text" class="textBoxUserAccount" />
                 </li>
                  <li id="Motor">
                     <label class="registerLabel">Motor</label>
                        <input id="motor" name="Motor" type="text" class="textBoxUserAccount" />
                 </li>
             </ul>
        </div>

        <!--Segunda caja de campo de datos-->
        <div style="float:left;width:42%;padding-top:30px;" class="contentInside">
            <ul id="listaregistro2">
                  <li id="Kms">
                     <label class="registerLabel">Km's</label>
                        <input id="km" name="Km" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="anyo">
                     <label class="registerLabel">Año</label>
                        <input id="Anyos" name="anyo" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="combustible">
                     <label class="registerLabel">Combustible</label>
                        <input id="Combustibles" name="combustible" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="Plazas">
                     <label class="registerLabel">Plazas</label>
                        <input id="Plaza" name="plazas" type="text" class="textBoxUserAccount" />
                 </li>
                <li id="cambio">
                     <label class="registerLabel">Cambio</label>
                    <select class ="textBoxUserAccount">
                        <option value="nada"> </option>
                      <option value="automatico">Automático</option>
                      <option value="manual">Manual</option>
                    </select>
                        
                 </li>
                <li id="clor">
                     <label class="registerLabel">Color</label>
                        <input id="color" name="Color" type="color" class="textBoxUserAccount" />
                 </li>
            </ul>
        </div>
         <div style="float:left; padding-left:100px;padding-top:10px;" class="contentInside">
             <input type="checkbox" name="your-group" value="unit-in-group" /> He leido y acepto los términos y condiciones.
         </div>
        <div  style="float:left; padding-left:100px;padding-bottom:30px;" class="contentInside">
            <input type="button" id="registrarbutton" value="Vender" class="buttonGreat buttonMedium" />
        </div>
   </div>
</asp:Content>
