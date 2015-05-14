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



namespace CapaInterfaz.Privada
{
    public partial class SellCar : System.Web.UI.Page
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
            
            Response.Write(car.Marca+car.Modelo+car.Precio+car.Puertas+car.Matricula+car.Motor+car.Km+car.Anyo+car.Cambio+car.Plazas+car.Tipo+car.Color);        

           /* insert = car.insertarCoche();
            if (insert == true)
                Response.Write("<script>window.alert('Se ha puesto a la venta su coche');</script>");
            else
                Response.Write("<script>window.alert('No se ha podido poner a la venta, contacte con nosotros para cualquier duda');</script>");
       */ }
    }
}