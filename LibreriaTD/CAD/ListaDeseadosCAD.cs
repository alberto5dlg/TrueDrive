using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;

namespace LibreriaTD.CAD
{
    class ListaDeseadosCAD
    {
        private string conexion; //Conexión con la BD
        //Método que saca toda la información de una lista dado el id del cliente
        public ListaDeseadosEN SacarLista(string id)
        {
            return new ListaDeseadosEN();
        }
        public bool InsertarCoche(CocheEN coche)
        {
            return true;
        }
        //Inserta una lista en la BD
        public bool InsertarLista(ListaDeseadosEN lista)
        {
            return true;
        }
        //Borra una lista en la BD
        public bool BorrarLista(ListaDeseadosEN lista)
        {
            return true;
        }
        //Actualiza una lista en la BD
        public bool Actualizar(ListaDeseadosEN lista)
        {
            return true;
        }
    }
}
