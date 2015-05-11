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
                       <p>Queremos lo mejor para nuestros clientes y por ello hemos creado My TrueDrive</p>
                       <p>Un apartado totalmente personalizado donde obtendrás la atención que necesitas además de poder consultar todo tipo de datos: productos, información adicional, servicio postventa, garantía, seguros, y mucho más...</p>
                       <p>Una vez te registres en nuestra web, dispondrás de un usuario y contraseña con el que identificarte y poder acceder a My TrueDrive</p>
                       <p>No lo dudes, una experiencia a la última en tecnología y con los servicios personalizados para que comprar tu coche no sea algo aburrido y monotono.</p>
                       <p>No es solo comprar un coche. Es disfrutarlo todos los días.</p>
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
                       <p>Ya tienes disponible en PlayStore y AppStore nuestra aplicación: MyTrueDrive</p>
                       <p>Con ella podrás además de consultar nuestros productos y tu área cliente, obtener información de tu coche.</p>
                       <p>Y si ya te has sumado al Eco-TrueDrive te recordamos que dispones de una amplia red de surtidores electricos a lo largo de la comunidad.</p>
                       <p>Podrás consultar cual es el más cercano, horas de consumo, consejos para hacer más eficientes tus recorrido y ahorrar energia.</p>
                       <h4>¡NO TE LO PIERDAS!</h4>
                   </div>
               </div>

               </div>
            </div>
        </section>
</asp:Content>
