using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace LibreriaTD.CAD
{
    class CestaCAD
    {
        private string conexion;//Variable que se usará para guardar la cadena de conexión con la BD

        public CestaCAD()
        {
            conexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\TrueDriveBD.mdf';Integrated Security=True";
        }

        //Inserta una Cesta por si no está en la BD
        public bool Insertar(CestaEN cesta)
        {
            bool insert = false;
            string comando = "Insert into Cesta values ('" + cesta.IdCliente + "', '" + cesta.Precio + "')";
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < cesta.Coches.Count; i++)
                {
                    InsertarCoche(cesta.IdCliente, cesta.Coches[i].Matricula);
                }
                insert = true;
            }
            catch (Exception e)
            {
            }
            con.Close();
            return insert;
        }

        //Inserta un coche en la cesta así como actualizamos el precio en la cesta
        public bool InsertarCoche(string cesta, string coche)
        {
            bool insert = false;
            string comando = "Insert into CochesCesta values ('" + cesta + "', '" + coche + "')";
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

            }
            con.Close();
            return insert;
        }

        //Borra un coche de la cesta en la BD
        public bool BorrarCoche(string cesta, string coche)
        {
            bool delete = false;
            string comando = "delete from CochesCesta where Id = '" + cesta + "' and Coche = '" + coche + "'";
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();

                delete = true;
            }
            catch (Exception e)
            {

            }
            con.Close();
            return delete;
        }

        //Borra la cesta
        public bool Borrar(CestaEN cesta)
        {
            bool delete = false;
            string comando = "delete from Cesta where idCliente = '" + cesta.IdCliente + "'; delete from CochesCesta where Id = '" + cesta.IdCliente + "'";
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();

                delete = true;
            }
            catch (Exception e)
            {

            }
            con.Close();
            return delete;
        }

        //Actualiza la cesta en la BD
        public bool Actualizar(CestaEN cesta)
        {
            bool update = false;
            if (Borrar(cesta))
            {
                update = Insertar(cesta);
            }
            return update;
        }
        //Saca una cesta de la BD y la devuelve
        public CestaEN SacarCesta(string id)
        {
            CestaEN cesta = new CestaEN(id); ;
            string comando = "select * from Cesta where idCliente = '" + id + "'";
            SqlConnection con = new SqlConnection(conexion);
            try
            {

                con.Open();
                SqlCommand c = new SqlCommand(comando, con);
                SqlDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    cesta.Precio = double.Parse(dr[1].ToString());
                    cesta.Coches = SacarCoches(id);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            con.Close();
            return cesta;
        }

        //Saca la lista de coches asociados a la cesta
        public List<CocheEN> SacarCoches(string id)
        {
            List<CocheEN> coches = new List<CocheEN>();
            CocheEN coche;
            string comando = "select * from coche join CochesCesta on coche.matricula = CochesCesta.Coche where CochesCesta.Id = '" + id + "'";
            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(comando, con);
                SqlDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {
                    coche = new CocheEN((string)dr[0], (string)dr[1], (string)dr[2], double.Parse((string)dr[3]), int.Parse((string)dr[4]), (string)dr[5], double.Parse((string)dr[6]), int.Parse((string)dr[7]), (string)dr[8], int.Parse((string)dr[9]), (string)dr[10], (string)dr[11],(string)dr[12]);
                    coches.Add(coche);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            con.Close();
            return coches;
        }
    }
}