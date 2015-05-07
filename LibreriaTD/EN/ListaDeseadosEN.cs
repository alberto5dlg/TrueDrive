using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.CAD;

namespace LibreriaTD.EN
{
    class ListaDeseadosEN
    {
        private string idCliente;
        List<CocheEN> coches;

        //Métodos
        public void AddCoche(CocheEN coche)
        {
            ListaDeseadosCAD aux = new ListaDeseadosCAD();
            if (aux.InsertarCoche(coche))
            {
                coches.Add(coche);
            }
        }

        //Getters y Setters
        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public List<CocheEN> Coches
        {
            get { return coches; }
            set { coches = value; }
        }

        //Llamadas a CADs
        //Inserta una lista en la BD
        public void Insertar()
        {
            ListaDeseadosCAD aux = new ListaDeseadosCAD();
            aux.InsertarLista(this);
        }
        //Borra la lista de la BD
        public void Borrar()
        {
            ListaDeseadosCAD aux = new ListaDeseadosCAD();
            aux.BorrarLista(this);
        }
        //Actualiza una lista en la BD
        public void Actualizar()
        {
            ListaDeseadosCAD aux = new ListaDeseadosCAD();
            aux.Actualizar(this);
        }
    }
}
