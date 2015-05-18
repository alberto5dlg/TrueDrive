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
            ValidacionesEN validacion = new ValidacionesEN();
            bool validation = true;

            //ver si los campos tienen algo y no estan vacios
            validation = validacion.Vacio(Usuario.Text);
            validation = validacion.Vacio(Contrasenya.Text);
            validation = validacion.Vacio(Nif.Text);
            validation = validacion.Vacio(Nombre.Text);
            validation = validacion.Vacio(Apellidos.Text);
            validation = validacion.Vacio(Direccion.Text);
            validation = validacion.Vacio(Email.Text);
            //validation = validacion.Vacio(NumContacto);
            if (validation == false)
            {
                //si estan todos los campos rellenos entonces pasamos a comprobar si estan bien 
                //ver si los campos respetan la sintaxis mediantes expresiones regulares
                bool validation2 = false;
                validation2 = validacion.ValidarPassword(Contrasenya.Text);
                validation2 = validacion.ValidarNif(Nif.Text);
                validation2 = validacion.ValidarNombrePersona(Nombre.Text);
                validation2 = validacion.ValidarCiudadPersona(Apellidos.Text);
                validation2 = validacion.ValidarEmail(Email.Text);
                //Si se cumple lo anterior entonces insertamos 
                if (validation2 == true)
                {
                    EmpleadoEN emple = new EmpleadoEN();

                    emple.Dni = Nif.Text;
                    emple.Nombre = Nombre.Text;
                    emple.Apellidos = Apellidos.Text;
                    emple.Usuario = Usuario.Text;
                    emple.Pass = Contrasenya.Text;
                    emple.Email = Email.Text;
                    emple.NumContacto = Convert.ToInt32(NumContacto.Text);
                    emple.Direccion = Direccion.Text;

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
    }
}