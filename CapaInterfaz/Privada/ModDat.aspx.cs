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
            if (Session["Usuario"] == null)
            {
                Response.Write("<script>window.alert('Debes estar registrado para poder acceder');</script>");
                Response.Redirect("../Pages/Home.aspx");
            }
            else
            {
                string user = Session["Usuario"].ToString();
                ClienteEN en = new ClienteEN();
                ClienteEN c = en.sacarCliente(user);
                
                Usuario.Text = c.usuCliente;
                Contrasenya.Text = c.passCliente;
                Nombre.Text = c.nombreCliente;
                Apellidos.Text = c.apellidosCliente;
                Dni.Text = c.nifCliente;
                Email.Text = c.emailCliente;
                Fecnac.Text = c.anyoNacimientoCliente;
                Direccion.Text = c.direccionCliente;
                Ciudad.Text = c.ciudadCliente;
                Codp.Text = Convert.ToString(c.codpCliente);
                Provincia.Text = c.provCliente;
                Pais.Text = c.paisCliente;
                Telefono.Text = c.telefonoCliente;
                Interesado.Text = c.interesadoEnCliente;
                Response.Write("<script>window.alert('" + c.usuCliente+ " JAJAJ');</script>");
            }
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
            {
                Response.Write("<script>window.alert('Se han modificado sus datos correctamente');</script>");
                Page_Load(sender,e);
            }
            else
                Response.Write("<script>window.alert('Algun error en la modificacion, consulte con nuestros tecnicos');</script>");

        }
    }
}