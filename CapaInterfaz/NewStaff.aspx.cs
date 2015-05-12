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
    public partial class NewStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertStaff_click(object sender, EventArgs e)
        {
            EmpleadoEN emple = new EmpleadoEN();
            bool insert = false;
            emple.Dni = Nif.Text;
            emple.Nombre = Nombre.Text;
            emple.Apellidos = Apellidos.Text;
            emple.Usuario = Usuario.Text;
            emple.Pass = Contrasenya.Text;
            emple.Email = Email.Text;
            emple.NumContacto = NumContacto.Text;
            emple.Direccion = Direccion.Text;

            insert = emple.InsertarEmpleado();
             if (insert == true)
                 Response.Write("<script>window.alert('Insertado Correctamente');</script>");
             else
                 Response.Write("<script>window.alert('No se ha conseguido insertar');</script>");

        }
    }
}