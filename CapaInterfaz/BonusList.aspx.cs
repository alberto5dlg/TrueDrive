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
    public partial class BonusList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BonificacionesEN em = new BonificacionesEN();

            BonificacionesEN[] listaBonificacion = em.MostrarBonificaciones();

            DataTable tabla = new DataTable();

            tabla.Columns.Add("IdBonificacion");
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("CantidadBonificacion");
            tabla.Columns.Add("Franja");

            for (int i = 0; i < listaBonificacion.Length; i++)
            {
                DataRow row = tabla.NewRow();
                row["IdBonificacion"] = listaBonificacion[i].IdBonificacion;
                row["Descripcion"] = listaBonificacion[i].Descripcion;
                row["CantidadBonificacion"] = listaBonificacion[i].CantidadBonificacion;
                row["Franja"] = listaBonificacion[i].Franja;
                tabla.Rows.Add(row);
            }

            ListProducts.DataSource = tabla;
            ListProducts.DataBind();
        }
    }
}