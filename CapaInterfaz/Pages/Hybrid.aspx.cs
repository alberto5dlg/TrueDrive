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
    public partial class Hybrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CocheEN car = new CocheEN();

            CocheEN[] listaCoche = car.ExtraerTipo("Hibrido");
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Imagen");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Tipo");
            tabla.Columns.Add("Puertas");
            tabla.Columns.Add("Color");
            tabla.Columns.Add("Cambio");

            for (int i = 0; i < listaCoche.Length; i++)
            {

                DataRow row = tabla.NewRow();
                row["Imagen"] = listaCoche[i].Imagen;
                row["Marca"] = listaCoche[i].Marca;
                row["Modelo"] = listaCoche[i].Modelo;
                row["Precio"] = listaCoche[i].Precio;
                row["Color"] = listaCoche[i].Color;
                row["Puertas"] = listaCoche[i].Puertas;
                row["Tipo"] = listaCoche[i].Tipo;
                row["Cambio"] = listaCoche[i].Cambio;
                tabla.Rows.Add(row);
            }

            ListProducts.DataSource = tabla;
            ListProducts.DataBind();
        }
    }
}