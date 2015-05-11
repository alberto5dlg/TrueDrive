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

        protected void registrar_Click(object sender, EventArgs e)
        {
            ClienteEN en = new ClienteEN();
            en.usuCliente = usuario.Text;
            en.passCliente = "";
            en.nombreCliente = "";
            en.apellidosCliente = "";
            en.nifCliente = "";
            en.emailCliente = "";
            en.anyoNacimientoCliente = "";
            en.direccionCliente = "";
            en.ciudadCliente = "";
            en.codpCliente = 0123;
            en.provCliente = "";
            en.paisCliente = "";
            en.interesadoEnCliente = "";
            en.telefonoCliente = "";
           
            en.InsertarCliente();



        }
    }
}