<%@ Page Title="" Language="C#" MasterPageFile="~/TrueDrive.Master" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="CapaInterfaz.Pages.Location" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/Location.css" type="text/css" rel="stylesheet" />
    <section>
        <div class="clear-fix displayGreat displayMedium">
           <div class="contentWrapper">
               <div class="headerWrap identityHeader">
                        <h1>¿Dónde estamos?</h1>
                </div>
                <div class="contentInside">
                    <div id="Div1">
                        <iframe class="mapa"; src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3126.928427453615!2d-0.5231388!3d38.3969039!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd6236abaa293ea5%3A0xe1cea5c1af8e8a90!2sCarrer+Dr.+Trueta%2C+4%2C+03690+Sant+Vicent+del+Raspeig%2C+Alicante!5e0!3m2!1ses!2ses!4v1431019735611" width="400" height="300" ></iframe>
                        <div id="Div3">
                            <div class="location" style=" margin-right: 40px;">
                            <p><strong>Dirección:</strong>
                            <p>Calle Doctor Trueta, 4</p> 
                            <p>03690  San Vicente del Raspeig, Alicante</p>
                            <br />
                            <br />
                            <p><strong>Teléfono de contacto:</strong></p>
                            <p>965 66 54 72</p>
                            <p>655 81 26 80</p>
                            </div>

                            <div class="location">
                            <p><strong>Horario:</strong></p>
                            <p>De Lunes a Viernes de 9:30h a 13:30h y de 17:30h a 20:30h</p>
                            <p>Sábados de 10:00h a 14:00h</p>
                            <p>Domingos y Festivos CERRADO</p>

                            <p><strong>Horario de verano:</strong></p>
                            <p>De Lunes a Viernes de 9:30h a 13:30h y de 18:00 a 21:00h</p>
                            <p>Sábados de 10:00h a 14:00h</p>
                            <p>Domingos y Festivos CERRADO</p>
                            </div>
                        </div>
                    </div>
                </div>
               </div>
            </div>
        <script type="text/javascript" src="../Scripts/widthmenu.js"></script>
    </section>
</asp:Content>
