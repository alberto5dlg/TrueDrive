using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;

namespace LibreriaTD.CAD
{
    class CestaCAD
    {
        //private string conexion;//Variable que se usará para guardar la cadena de conexión con la BD

        public CestaCAD()
        {
            //adquirir la cadena de la conexión
        }

        //Inserta una Cesta por si no está en la BD
        public bool Insertar(CestaEN cesta)
        {
            return true;
        }

        //Inserta un coche en la cesta así como actualizamos el precio en la cesta
        public bool InsertarCoche(CestaEN cesta, CocheEN coche)
        {
            return true;
        }

        //Borra un coche de la cesta en la BD
        public bool BorrarCoche(CestaEN cesta, CocheEN coche)
        {
            return true;
        }

        //Borra la cesta
        public bool Borrar(CestaEN cesta)
        {
            return true;
        }

        //Actualiza la cesta en la BD
        public bool Actualizar(CestaEN cesta)
        {
            return true;
            //Código para actualizar la BD
        }
    }
}
