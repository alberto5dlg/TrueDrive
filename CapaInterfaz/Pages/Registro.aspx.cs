using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaTD.EN;
using LibreriaTD.CAD;
using System.Windows.Forms;

namespace CapaInterfaz.Pages
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The calculations are complete", "My Application",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            ClienteEN en = new ClienteEN();
            en.usuarioCliente = this.Request.Form["usuario"];
            en.contraCliente = this.Request.Form["contrasenya"];
            en.nombreCliente = this.Request.Form["nombre"];
            en.apellidosCliente = this.Request.Form["apellidos"];
            en.nifCliente = this.Request.Form["dni"];
            en.emailCliente = this.Request.Form["email"];
            en.anyoNacimientoCliente = this.Request.Form["fecnac"];
            en.direccionCliente = this.Request.Form["direccion"];
            en.ciudadCliente = this.Request.Form["ciudad"];
            en.codpCliente = 03503;
            en.provCliente = this.Request.Form["provincia"];
            en.paisCliente = this.Request.Form["pais"];
            en.interesadoEnCliente = this.Request.Form["interesado"];
            en.telefonoCliente = this.Request.Form["telefono"];
           
            en.InsertarCliente();



        }
    }
}