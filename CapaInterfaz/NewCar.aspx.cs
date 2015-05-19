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
using System.IO;


namespace CapaInterfaz
{
    public partial class NewCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_click(object sender, EventArgs e)
        {
            bool insert = false;
            CocheEN car = new CocheEN();
            string pla = Request.Form["Plaza"];
            string precios = Request.Form["Precio"];
            string puertas = Request.Form["Puertas"];
            string kms = Request.Form["Km"];
            string anyo = Request.Form["Anyos"];

            car.Marca = Request.Form["Marca"];
            car.Modelo = Request.Form["Modelo"];
            car.Precio = Convert.ToDouble(precios);
            car.Puertas = Convert.ToInt32(puertas);
            car.Matricula = Request.Form["Matricula"];
            car.Motor = Request.Form["Motor"];
            car.Km = Convert.ToDouble(kms);
            car.Anyo = Convert.ToInt32(anyo);
            car.Cambio = Request.Form["Cambio"];
            car.Plazas = Convert.ToInt32(pla);
            car.Tipo = Request.Form["Tipo"];
            car.Color = Request.Form["Color"];

            if ((file1.PostedFile != null) && (file1.PostedFile.ContentLength > 0))
            {
                //comprobamos que el formato es el correcto para una fotografia 
                if (file1.Value.EndsWith(".JPG") || file1.Value.EndsWith(".jpg") ||
                    file1.Value.EndsWith(".ico") || file1.Value.EndsWith(".ICO") ||
                    file1.Value.EndsWith(".gif") || file1.Value.EndsWith(".GIF") ||
                    file1.Value.EndsWith(".png") || file1.Value.EndsWith(".PNG"))
                {
                    string fn = System.IO.Path.GetFileName(file1.PostedFile.FileName);
                    string SaveLocation = Server.MapPath(@"/ICoches") + "//" + fn;

                    try
                    {
                        file1.PostedFile.SaveAs(SaveLocation);
                        //string SaveLocation2 = Server.MapPath("/ICoches/") + fn;
                        car.Imagen = SaveLocation;
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }
                else
                    Response.Write("<script>window.alert('No es el formato correcto de imagen');</script>");
            }


            insert = car.InsertarCoche();
            if (insert == true)
                Response.Write("<script>window.alert('Se ha puesto a la venta el coche');</script>");
            else
                Response.Write("<script>window.alert('No se ha podido poner a la venta');</script>");
        }
    }
}