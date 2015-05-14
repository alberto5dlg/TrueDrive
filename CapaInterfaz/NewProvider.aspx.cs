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
    public partial class NewProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void insertar_Click(object sender, ImageClickEventArgs e)
        {
            bool insert = false;
            ProveedorEN pro = new ProveedorEN();

            pro.Cif = Request.Form["Cif"];
            pro.Empresa = Request.Form["Empresa"];
            pro.Ciudad = Request.Form["Ciudad"];
            pro.Pais = Request.Form["Pais"];
            pro.Telefono = Convert.ToInt32(Request.Form["Telefono"]);
            pro.Fax = Convert.ToInt32(Request.Form["Fax"]);
            pro.Email = Request.Form["Email"];
            pro.CodigoPostal = Convert.ToInt32(Request.Form["CodigoPostalEmpresa"]);
           
            insert = pro.insertarProveedor();
            
            if (insert == true)
            {
                Response.Write("<script>window.alert('Insertado el proveedor correctamente');</script>");
            }
            else
                Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");
            if (insert == true)
                Response.Redirect("MenuCP.aspx");
        }
    }
}