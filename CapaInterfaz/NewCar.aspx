<%@ Page Title="" Language="C#" MasterPageFile="~/ControlPanel.Master" AutoEventWireup="true" CodeBehind="NewCar.aspx.cs" Inherits="CapaInterfaz.NewCar"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="headControlPanel" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentControlPanel" runat="server">
    <form runat="server">
     <div class="cajaPrincipal1" style="min-height:750px;">
        <div style="background:#de3939;color:white;padding:10px;padding-left:50px;">
            <span style="font-size:25px;color:white;"> Ficha Coche </span>
        </div>
        <div style="padding:50px;">
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Matricula </legend>
                <input name="matricula" type="text" id="Matricula" class="inputDatos" />
            </fieldset>
            <fieldset class="cajonesFlotantes"">
                <legend class="etiquetaCajon"> Marca </legend>
                <input name="marca" type="text" id="Marca" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Modelo </legend>
                <input name="modelo" type="text" id="Modelo" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Precio </legend>
                <input name="precio" type="text" id="Precio" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Nº Puertas </legend>
                <input name="puertas" type="text" id="Puertas" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Motor </legend>
                 <input name="motor" type="text" id="Motor" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Km&#39;s </legend>
                <input name="kms" type="text" id="Km" class="inputDatos"/>
            </fieldset>
            
             <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Plazas</legend>
                <input name="plazas" type="text" id="Plaza" class="inputDatos"/>
            </fieldset>
            
              <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Año</legend>
                <input type="text" name="anyo" id="Anyo" class="inputDatos"/>
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Imagen</legend>
                <input type="file" id="file1" runat="server" class="inputDatos" />
            </fieldset>
             <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Cambio</legend>
                <select name="Cambio" id="Cambio" class ="inputDatos">
                        <option value="nada"> </option>
                      <option value="Automático">Automático</option>
                      <option value="Manual">Manual</option>
                    </select>  
            </fieldset>
            <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Color</legend>
                <input name="color" type="color" id="Color" class="inputDatos"/>
            </fieldset>
             <fieldset class="cajonesFlotantes">
                <legend class="etiquetaCajon"> Tipo</legend>
                <select name="Tipo" id="Tipo" class ="inputDatos">
                        <option value="nada"> </option>
                      <option value="Hibrido">Híbrido</option>
                      <option value="Electrico">Eléctrico</option>
                    </select>    
            </fieldset>
        </div>
        <span class ="anotacionespiepag">*El precio introducido es sin IVA, luego se aplicará</span>
    </div>
    <div class="cajaPrincipal2">
        <div style="background:#444242;color:white;padding:10px;text-align:center;">
            <span style="font-size:25px;color:white;"> Acciones </span>
        </div>
        <div style="padding:50px;">
            <div class="botonInsertar">
                 <asp:ImageButton runat="server" ID="insertar" ImageUrl="../Styles/images/insertar.png" OnClick="Button_click" />
            </div>
        </div>
    </div>
    </form>
</asp:Content>
