using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaTD.EN;
using LibreriaTD.CAD;


namespace CapaInterfaz
{
    public partial class NewStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertStaff_click(object sender, EventArgs e)
        {
            EmpleadoEN emple = new EmpleadoEN();
            
            emple.dni = Nif.Text;
            emple.nombre = Nombre.Text;
            emple.apellidos = Apellidos.Text;
            emple.usuario = Usuario.Text;
            emple.pass = Pass.Text;
            emple.email = Email.Text;
            emple.numContacto = NumContacto.Text;
            emple.direccion = Direccion.Text;
            
            Response.Write("<script>window.alert('Alberrrrtooooorrrr esto funciona !!');</script>");

            //emple.InsertarEmpleado();


        }
    }
}