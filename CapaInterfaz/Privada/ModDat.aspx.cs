using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Linq;
using LibreriaTD.EN;
using LibreriaTD.CAD;

namespace CapaInterfaz.Privada
{
    public partial class ModDat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            bool modify = false;
             
            ClienteEN en = new ClienteEN();
            en.usuCliente = Usuario.Text;
            en.passCliente = Contrasenya.Text;
            en.nombreCliente = Nombre.Text;
            en.apellidosCliente = Apellidos.Text;
            en.nifCliente = Dni.Text;
            en.emailCliente = Email.Text;
            en.anyoNacimientoCliente = Fecnac.Text;
            en.direccionCliente = Direccion.Text;
            en.ciudadCliente = Ciudad.Text;
            en.codpCliente = Convert.ToInt16(Codp.Text);
            en.provCliente = Provincia.Text;
            en.paisCliente = Pais.Text;
            en.interesadoEnCliente = Interesado.Text;
            en.telefonoCliente = Telefono.Text;

            modify = en.ModCliente();
            if (modify == true)
                Response.Write("<script>window.alert('Se han modificado sus datos correctamente');</script>");
            else
                Response.Write("<script>window.alert('Algun error en la modificacion, consulte con nuestros tecnicos');</script>");

        }
    }
}