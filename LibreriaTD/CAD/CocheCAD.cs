using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibreriaTD.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

namespace LibreriaTD.CAD
{
    public class CocheCAD
    {

        private string conexion;
        
        public CocheCAD()
        {

        }

        /*Con esta funcion insertaremos un coche en nuestra base de datos
        * devolvera verdadero cuando se inserte correctamente en caso contrario 
        * devolvera false
         */
        public bool InsertarCoche(CocheEN c)
        {
            bool insert = false;
            string comando = "Insert into Coche (matricula,marca,modelo,precio,puertas,motor,km,anyo,combustible,plazas,cambio,color) values ('" + c.Matricula  + "','" + c.Marca + "'," + c.Modelo + "','" + c.Precio + "','" + c.Puertas + "','" + c.Motor  + "','" + c.Km  + "','" + c.Anyo + "','" + c.Tipo + "','" + c.Plazas + "','" + c.Cambio + "','" + c.Color +"')";

            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.ExecuteNonQuery();

            if (cmd.ExecuteNonQuery() == 1)
                insert = true;
            else
                insert = false;

            con.Close();
            return insert;
        }
        /*Borramos un coche cuando no queden mas unidades de este y no dispongamos de el en stock
         * la funcion de tipo bool devolvera true en caso de que se borre el coche, y si el coche, 
         * no se ha borrado devolvera false
         */
        public bool BorrarCoche(CocheEN borrarCoche)
        {
            bool borrado = false;
            return borrado;
        }
        /* Modificaremos los kilometros de un coche cuando este coche sea alquilado por 
         * algun cliente y tenga mas de los kilometros que tenia antes de ser alquilado
         */
        public bool modKM(double modKm)
        {
            bool modifi = false;
            return modifi;
        }
       

        /*Modificar el precio del coche
         */
        public bool modPrecio(double mPre)
        {
            bool modifi = false;
            return modifi;
        }
    }
}
