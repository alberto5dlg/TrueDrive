using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaTD.EN;
using LibreriaTD.CAD;
using System.Data;

namespace CapaInterfaz
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dni = Request.QueryString["dni"];
            EmpleadoEN em = new EmpleadoEN();

            EmpleadoEN Empleado = em.SacarEmpleado(dni);

            DataTable tabla = new DataTable();

            tabla.Columns.Add("Dni");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("NumContacto");
            tabla.Columns.Add("Email");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Pass");

           
                DataRow row = tabla.NewRow();
                row["Dni"] = Empleado.Dni;
                row["Nombre"] = Empleado.Nombre;
                row["Apellidos"] = Empleado.Apellidos;
                row["Direccion"] = Empleado.Direccion;
                row["NumContacto"] = Empleado.NumContacto;
                row["Email"] = Empleado.Email;
                row["Usuario"] = Empleado.Usuario;
                row["Pass"] = Empleado.Pass;
                tabla.Rows.Add(row);
            
            
            ListProducts.DataSource = tabla;
            ListProducts.DataBind();
        }
    }
}