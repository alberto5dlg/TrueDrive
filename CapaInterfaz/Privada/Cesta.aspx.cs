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
    public partial class Cesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Usuario"] == null)
            {
                Response.Write("<script>window.alert('Debes estar registrado para poder acceder');</script>");
                Response.Redirect("../Pages/Home.aspx");
            }
            else
            {
                ClienteEN cli = new ClienteEN();
                cli = cli.sacarCliente(Session["Usuario"].ToString());
                CestaEN cesta = new CestaEN();
                cesta.SacarCesta(cli.nifCliente);
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Matricula");
                tabla.Columns.Add("Imagen");
                tabla.Columns.Add("Marca");
                tabla.Columns.Add("Modelo");
                tabla.Columns.Add("Precio");
                precio.Text = "Precio total: " + cesta.Precio + " €";
                for (int i = 0; i < cesta.Coches.Count; i++)
                {
                    DataRow row = tabla.NewRow();
                    row["Matricula"] = cesta.Coches[i].Matricula;
                    row["Imagen"] = cesta.Coches[i].Imagen;
                    row["Marca"] = cesta.Coches[i].Marca;
                    row["Modelo"] = cesta.Coches[i].Modelo;
                    row["Precio"] = cesta.Coches[i].Precio;
                    tabla.Rows.Add(row);
                }

                ListProducts.DataSource = tabla;
                ListProducts.DataBind();
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            ClienteEN cli = new ClienteEN();
            cli = cli.sacarCliente(Session["Usuario"].ToString());
            CocheEN coche = new CocheEN();
            coche.SacarCoche(((ImageButton)sender).CommandArgument);
            CestaEN cesta = new CestaEN();
            cesta.SacarCesta(cli.nifCliente);
            cesta.DeleteCoche(coche);
            cesta.Actualizar();
        }
    }
}