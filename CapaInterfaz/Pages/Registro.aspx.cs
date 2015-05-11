using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaTD.EN;
using LibreriaTD.CAD;

namespace CapaInterfaz.Paginas
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrarbutton(object sender, EventArgs e)
        {
            ClienteEN en = new ClienteEN();
            en.Usuario = "";
            en.Contrasenya = "";
            en.nombreCliente = "";
            en.apellidosCliente = "";
            en.nifCliente = "";
            en.emailCliente = "";
            en.anyoNacimientoCliente = "";
            en.direccionCliente = "";
            en.ciudadCliente = "";
            en.CodigoPostal = 0123;
            en.Provincia = "";
            en.paisCliente = "";
            en.interesadoEnCliente = "";
            en.telefonoCliente = "";
           
            en.InsertarCliente();



        }
    }
}