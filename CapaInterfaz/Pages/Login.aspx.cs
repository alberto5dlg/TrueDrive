using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaTD.EN;
using LibreriaTD.CAD;

namespace CapaInterfaz.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            bool consult = false;
            ClienteEN cli = new ClienteEN();
            cli.usuCliente = Usuario.Text;
            cli.passCliente = Pass.Text;

            EmpleadoEN emp = new EmpleadoEN();
            emp.Usuario = Usuario.Text;
            emp.Pass = Pass.Text;

            if (consult = cli.ConsultarUsuario() == true)
            {
                Response.Redirect("../Privada/ClientMenu.aspx");
                Session["Usuario"] = cli.usuCliente;
            }
            else if (consult = emp.ConsultarEmpleado() == true)
            {
                Session["Empleado"] = emp.Usuario;
                Response.Redirect("../MenuCP.aspx");
            }
            else
                Response.Write("<script>window.alert('No existe el usuario');</script>");
        }
    }
}