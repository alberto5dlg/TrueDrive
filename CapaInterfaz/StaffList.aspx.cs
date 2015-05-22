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
    public partial class StaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpleadoEN em = new EmpleadoEN();

            EmpleadoEN[] listaEmpleado = em.MostrarEmpleados();
            
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Dni");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("NumContacto");
            tabla.Columns.Add("Email");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Pass");

            for (int i = 0; i < listaEmpleado.Length; i++)
            {

                DataRow row = tabla.NewRow();
                row["Dni"] = listaEmpleado[i].Dni;
                row["Nombre"] = listaEmpleado[i].Nombre;
                row["Apellidos"] = listaEmpleado[i].Apellidos;
                row["Direccion"] = listaEmpleado[i].Direccion;
                row["NumContacto"] = listaEmpleado[i].NumContacto;
                row["Email"] = listaEmpleado[i].Email;
                row["Usuario"] = listaEmpleado[i].Usuario;
                row["Pass"] = listaEmpleado[i].Pass;
                tabla.Rows.Add(row);
            }
            

            ListProducts.DataSource = tabla;
            ListProducts.DataBind();
        }

    }
}