using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaInterfaz
{
    public partial class Cesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Usuario"] == null)
            {
                Response.Write("<script>window.alert('Debes estar registrado para poder acceder');</script>");
                Response.Redirect("../Pages/Home.aspx");
            }

        }
    }
}