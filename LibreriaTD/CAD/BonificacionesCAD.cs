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
    public class BonificacionesCAD
    {

        private string conexion;
        
        //private string conexion;//Variable que se usará para guardar la cadena de conexión con la BD

        public BonificacionesCAD()
        {
             conexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\TrueDriveBD.mdf';Integrated Security=True";
        }

        public BonificacionesEN[] MostrarBonificaciones()
        {
            List<BonificacionesEN> bonificaciones = new List<BonificacionesEN>();
            BonificacionesEN nBoni;
            string cmd = "select * from bonificaciones";

            SqlConnection con = new SqlConnection(conexion);
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand(cmd, con);
                SqlDataReader dr = c.ExecuteReader();
                while (dr.Read())
                {
                    nBoni = new BonificacionesEN((int)dr[0], (string)dr[1], (decimal)dr[2], (string)dr[3]);
                    bonificaciones.Add(nBoni);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                return null;
            }

            con.Close();
            return bonificaciones.ToArray();
        }
    }
}
