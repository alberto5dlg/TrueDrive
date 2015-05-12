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
            bool insert = false;

            ClienteEN cli = new ClienteEN();
            cli.usuCliente = Usuario.Text;
            cli.passCliente = Pass.Text;

           insert = cli.ConsultarUsuario();

            if (insert == true)
                Response.Write("<script>window.alert('Insertado Correctamente');</script>");
            else
                Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");
        }
    }
}