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
            Response.Write(en.usuCliente + "<script>window.alert('Insertado Correctamente');</script>");
            en.InsertarCliente();
            if (insert == true)
                Response.Write("<script>window.alert('Insertado Correctamente');</script>");
            else
                Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");


        }
    }
}