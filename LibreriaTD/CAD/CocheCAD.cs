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
            conexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\TrueDriveBD.mdf';Integrated Security=True";
        }

        /*Con esta funcion insertaremos un coche en nuestra base de datos
         * devolvera verdadero cuando se inserte correctamente en caso contrario 
         * devolvera false
          */
        public bool InsertarCoche(CocheEN c)
        {
            bool insert = false;
            string comando = "Insert into Coche (matricula,marca,modelo,precio,puertas,motor,km,anyo,combustible,plazas,cambio,color) values ('" + c.Matricula + "','" + c.Marca + "','" + c.Modelo + "','" + c.Precio + "','" + c.Puertas + "','" + c.Motor + "','" + c.Km + "','" + c.Anyo + "','" + c.Tipo + "','" + c.Plazas + "','" + c.Cambio + "','" + c.Color + "')";

            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();
                insert = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            con.Close();
            return insert;
        }
        /*Borramos un coche cuando no queden mas unidades de este y no dispongamos de el en stock
         * la funcion de tipo bool devolvera true en caso de que se borre el coche, y si el coche, 
         * no se ha borrado devolvera false
         */
        public bool BorrarCoche(string matricula)
        {
            bool delete = false;

            string cmd = "delete from coche where matricula = '" + matricula + "'";

            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                c.ExecuteNonQuery();
                delete = true;
            }
            catch (Exception e)
            {
                delete = false;
            }
            finally
            {
                con.Close();
            }
            return delete;
        }

        public bool Actualizar(CocheEN coche)
        {
            bool update = false;

            string cmd = "update coche set marca = '" + coche.Marca + "', modelo = '" + coche.Modelo + "', precio = '" + coche.Precio + "', puertas = '" + coche.Puertas + "', motor = '" + coche.Motor + "', km = '" + coche.Km + "', anyo = '" + coche.Anyo + "', combustible = '" + coche.Tipo + "', plazas = '" + coche.Plazas + "', cambio = '" + coche.Cambio + "', color = '" + coche.Color + "' where matricula = '" + coche.Matricula + "'";

            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                c.ExecuteNonQuery();
                update = true;
            }
            catch (Exception e)
            {
                update = false;
            }
            finally
            {
                con.Close();
            }
            return update;
        }

        public CocheEN SacarCoche(string matricula)
        {
            CocheEN coche = new CocheEN();
            string comando = "select * from coche where matricula = '" + matricula + "'";
            SqlConnection con = new SqlConnection(conexion);
            try
            {

                con.Open();
                SqlCommand c = new SqlCommand(comando, con);
                SqlDataReader dr = c.ExecuteReader();
                dr.Read();
                coche = new CocheEN((string)dr[0], (string)dr[1], (string)dr[2], double.Parse((string)dr[3]), int.Parse((string)dr[4]), (string)dr[5], double.Parse((string)dr[6]), int.Parse((string)dr[7]), (string)dr[8], int.Parse((string)dr[9]), (string)dr[10], (string)dr[11]);

                dr.Close();
            }
            catch (Exception e)
            {

            }
            con.Close();
            return coche;
        }

        public CocheEN[] SacarCoches()
        {
            List<CocheEN> coches = new List<CocheEN>();
            CocheEN coche;
            string comando = "select * from coche";
            SqlConnection con = new SqlConnection(conexion);
            try
            {

                con.Open();
                SqlCommand c = new SqlCommand(comando, con);
                SqlDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {
                    coche = new CocheEN((string)dr[0], (string)dr[1], (string)dr[2], double.Parse((string)dr[3]), int.Parse((string)dr[4]), (string)dr[5], double.Parse((string)dr[6]), int.Parse((string)dr[7]), (string)dr[8], int.Parse((string)dr[9]), (string)dr[10], (string)dr[11]);
                    coches.Add(coche);
                }
                dr.Close();
            }
            catch (Exception e)
            {

            }
            con.Close();
            return coches.ToArray();
        }
    }
}