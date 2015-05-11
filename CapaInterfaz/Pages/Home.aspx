<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CapaInterfaz.Paginas.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <link href="../Styles/Home.css" type="text/css" rel="stylesheet" />
    <section>
        <div class="clear-fix displayGreat displayMedium">
           <div class="contentWrapper">
                <div class="ecoDrive">
                    <div class="ecoLeft">
                        <img src="../Styles/images/greendriver.png" />
                    </div>
                    <div class="ecoCenter">
                        <h3>NOS IMPORTA EL MEDIO AMBIENTE</h3>
                            <p>Queremos ayudar a mejorar el mundo y por ello apostamos en energías renovables.</p> 
                            <p>Ofrecemos una amplia gama de coches híbridos y eléctricos.</p>
                            <p>Además hemos puesto en marcha un proyecto para la elaboración de una red de suministro eléctrico a lo largo de toda Europa.</p>
                    </div>
                    <div class="ecoRigth">
                        <h3>ÚLTIMA TECNOLOGÍA</h3>
                            <p>Surtidores eléctricos con la ultima tecnología donde podrás llevar un control detallado del consumo de tu coche y muchas cosas más.</p>
                            <p>También te informamos que por ser miembro de My TrueDrive dispondrás de numerosos descuentos y regalos cada vez que recargues tu vehículo en uno de nuestros surtidores.</p>
                    </div>
                </div>
               <div class="myTrueDrive">
                   <h2>My TrueDrive</h2>
                   <div class="info">
                       <div class="titularApp">
                            <h3>My TrueDrive : TODO SOBRE TU COCHE</h3>
                       </div>
                   </div>
                   <div class="map">
                       <div class="titularApp">
                            <h3>NO TE QUEDARÁS SIN ENERGÍA</h3>
                       </div>
                       <img src="../Styles/images/surtidoresElectricos.png" />
                   </div>
                   <div class="app">
                       <div class="titularApp">
                            <h3>DESCARGA NUESTRA APP Y DESCUBRE MUCHO MÁS</h3>
                        </div>
                   </div>
               </div>

               </div>
            </div>
        </section>
</asp:Content>
