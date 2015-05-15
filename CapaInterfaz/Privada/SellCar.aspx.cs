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



namespace CapaInterfaz.Privada
{
    public partial class SellCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         private Boolean ValidaExtension(string sExtension)
        {
            Boolean rel = false;
            switch (sExtension)
            {
                case ".jpg": 
                case ".jpeg":
                case ".png": 
                case ".gif": 
                case ".bmp":
                    rel = true;
                    break;
                default:
                    rel = false;
                    break;

            }
            return rel;
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
           
            if((file1.PostedFile!=null)&&(file1.PostedFile.ContentLength > 0))
            {
                if (file1.Value.EndsWith(".JPG") || file1.Value.EndsWith(".jpg") || 
                    file1.Value.EndsWith(".ico") || file1.Value.EndsWith(".ICO") || 
                    file1.Value.EndsWith(".gif") || file1.Value.EndsWith(".GIF") || 
                    file1.Value.EndsWith(".png") || file1.Value.EndsWith(".PNG")) 
                {
                       string fn = System.IO.Path.GetFileName(file1.PostedFile.FileName);
                       string SaveLocation = Server.MapPath(@"../ICoches") + "//" + fn;
                       
                       try
                       {
                           file1.PostedFile.SaveAs(SaveLocation);
                           Label1.Text = "El archivo se ha cargado.";
                           car.Imagen = SaveLocation;  
                       }
                       catch (Exception ex)
                       {
                           Response.Write(ex.Message);
                       }
                }
                else
                    Label1.Text = "No se pudo cargar el archivo seleccionado, por favor seleccione una imagen .jpg, .gif o .png";
            }
            

            insert = car.InsertarCoche();
            if (insert == true)
                Response.Write("<script>window.alert('Se ha puesto a la venta su coche');</script>");
            else
                Response.Write("<script>window.alert('No se ha podido poner a la venta, contacte con nosotros para cualquier duda');</script>");
        }
    }
}