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
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace CapaInterfaz
{
    public partial class NewStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertStaff_click(object sender, EventArgs e)
        {
            bool insert = false;

            EmpleadoEN emple = new EmpleadoEN();
           
            ValidacionesEN validacion = new ValidacionesEN();
            
            //ver si los campos tienen algo y no estan vacios
            bool usuario = validacion.Vacio(Usuario.Text);
            bool password = validacion.Vacio(Contrasenya.Text);
            bool NIF = validacion.Vacio(Nif.Text);
            bool nombre = validacion.Vacio(Nombre.Text);
            bool apellidos = validacion.Vacio(Apellidos.Text);
            bool direccion = validacion.Vacio(Direccion.Text);
            bool email = validacion.Vacio(Email.Text);
            //bool NumContacto = validacion.Vacio(NumContacto);

            //ver si los campos respetan la sintaxis mediantes expresiones regulares
            bool passwordER = validacion.ValidarPassword(Contrasenya.Text);
            bool nifER = validacion.ValidarNif(Nif.Text);
            bool nombreER = validacion.ValidarNombrePersona(Nombre.Text);
            bool apellidosER = validacion.ValidarCiudadPersona(Apellidos.Text);
            bool emailER = validacion.ValidarEmail(Email.Text);

            

            insert = emple.InsertarEmpleado();
            if (insert == true)
            {
                Response.Write("<script>window.alert('Insertado Correctamente');</script>");
                if (insert == true)
                    Response.Redirect("MenuCP.aspx");
            }
            else
                Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");

        }
    }
}