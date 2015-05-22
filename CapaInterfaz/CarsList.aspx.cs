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
    public partial class CarsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CocheEN coc = new CocheEN();

            CocheEN[] listaCoches = coc.MostrarCoches();
            
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Matricula");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Puertas");
            tabla.Columns.Add("Motor");
            tabla.Columns.Add("Km");
            tabla.Columns.Add("Anyo");
            tabla.Columns.Add("Tipo");
            tabla.Columns.Add("Plazas");
            tabla.Columns.Add("Cambio");
            tabla.Columns.Add("Color");
            tabla.Columns.Add("Imagen");

            for (int i = 0; i < listaCoches.Length; i++)
            {

                DataRow row = tabla.NewRow();
                row["Matricula"] = listaCoches[i].Matricula;
                row["Marca"] = listaCoches[i].Marca;
                row["Modelo"] = listaCoches[i].Modelo;
                row["Puertas"] = listaCoches[i].Puertas;
                row["Motor"] = listaCoches[i].Motor;
                row["Km"] = listaCoches[i].Km;
                row["Anyo"] = listaCoches[i].Anyo;
                row["Tipo"] = listaCoches[i].Tipo;
                row["Plazas"] = listaCoches[i].Plazas;
                row["Cambio"] = listaCoches[i].Cambio;
                row["Color"] = listaCoches[i].Color;
                row["Imagen"] = listaCoches[i].Imagen;
                tabla.Rows.Add(row);
            }
            

            ListProducts.DataSource = tabla;
            ListProducts.DataBind();
        
        }
    }
}