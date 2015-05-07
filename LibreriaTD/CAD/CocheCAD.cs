using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;

namespace LibreriaTD.CAD
{
    public class CocheCAD
    {

        //private string conexion;
        
        public CocheCAD()
        {

        }

        /*Con esta funcion insertaremos un coche en nuestra base de datos
        * devolvera verdadero cuando se inserte correctamente en caso contrario 
        * devolvera false
         */
        public bool InsertarCoche(CocheEN nuevoCoche)
        {
            bool insert = false;
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
        /*En caso de que no se pueda borrar un coche porque todavia tiene unidades en stock
         * restaremos una unidad que sera pasada por parametro, porque este coche todavia estara
         * en stock
         */
        public bool modUds(int mUnidad)
        {
            bool modifi = false;
            return modifi;
        }

        /*Modificar el precio del coche */
        public bool modPrecio(double mPre)
        {
            bool modifi = false;
            return modifi;
        }
    }
}
