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


namespace CapaInterfaz.Pages
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrar_Click(object sender, EventArgs e)
        {
            bool insert = false;

            ClienteEN en = new ClienteEN();
            en.usuCliente = Usuario.Text;
            en.passCliente = contrasenya.Text;
            en.nombreCliente = nombre.Text;
            en.apellidosCliente = apellidos.Text;
            en.nifCliente = dni.Text;
            en.emailCliente = email.Text;
            en.anyoNacimientoCliente = fecnac.Text;
            en.direccionCliente = direccion.Text;
            en.ciudadCliente = Ciudad.Text;
            en.codpCliente = Convert.ToInt32(codp.Text);
            en.provCliente = Provincia.Text;
            en.paisCliente = Pais.Text;
            en.interesadoEnCliente = interesado.Text;
            en.telefonoCliente = telefono.Text;

           
            insert = en.InsertarCliente();
            if (insert == true)
            {
                Response.Write("<script>window.alert('Insertado Correctamente');</script>");
                Response.Redirect("Home.aspx");
            }
            else
                Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");


        }
    }
}