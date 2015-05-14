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

namespace CapaInterfaz
{
    public partial class NewClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
 
        protected void registrar_Click(object sender, EventArgs e)
        {
            bool insert = false;

            ClienteEN en = new ClienteEN();
            en.usuCliente = Request.Form["Usuario"];
            en.passCliente = Request.Form["Contraseña"];
            en.nombreCliente = Request.Form["Nombre"];
            en.apellidosCliente = Request.Form["Apellidos"];
            en.nifCliente = Request.Form["Nif"];
            en.emailCliente = Request.Form["Email"];
            en.anyoNacimientoCliente = Request.Form["FechaNac"];
            en.direccionCliente = Request.Form["Direccion"];
            en.ciudadCliente = Request.Form["Ciudad"];
            en.codpCliente = Convert.ToInt32(Request.Form["Codp"]);
            en.provCliente = Request.Form["Provincia"];
            en.paisCliente = Request.Form["Pais"];
            en.interesadoEnCliente = Request.Form["Interesado"];
            en.telefonoCliente = Request.Form["Telefono"];

           
            insert = en.InsertarCliente();
            if (insert == true)
            {
                Response.Write("<script>window.alert('Insertado Correctamente');</script>");
                
            }
            else
                Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");
            if(insert == true)
                Response.Redirect("MenuCP.aspx");
        }
    }
}