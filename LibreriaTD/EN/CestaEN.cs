using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.CAD;

namespace LibreriaTD.EN
{

    public class CestaEN
    {
        private string idCliente;
        private List<CocheEN> coches;
        private double precio;

        public CestaEN()
        {
            idCliente = null;
            precio = 0;
            coches = new List<CocheEN>();
        }
        public CestaEN(string id)
        {
            idCliente = id;
            precio = 0;
            coches = new List<CocheEN>();
        }

        public bool Insertar()
        {
            CestaCAD aux = new CestaCAD();
            bool insert = aux.Insertar(this);
            return insert;
        }

        public bool Borrar()
        {
            CestaCAD aux = new CestaCAD();
            bool delete = aux.Borrar(this);
            return delete;
        }

        public void SacarCesta(string id)
        {
            CestaCAD cesta = new CestaCAD();
            CestaEN cestaAux = new CestaEN();
            cestaAux = cesta.SacarCesta(id);
            this.idCliente = cestaAux.idCliente;
            this.coches = cestaAux.coches;
            this.precio = cestaAux.precio;
        }

        public void AddCoche(CocheEN coche)
        {
            CestaCAD aux = new CestaCAD();
            coches.Add(coche);
            precio += coche.Precio;
        }

        public void DeleteCoche(CocheEN coche)
        {
            coches.Remove(coche);
            precio -= coche.Precio;
        }

        public bool Actualizar()
        {
            CestaCAD aux = new CestaCAD();
            return aux.Actualizar(this);
        }




        //Getters Setters
        public string IdCliente //Este id nunca se modificará por lo tanto no tiene setter
        {
            get { return idCliente; }
        }

        public List<CocheEN> Coches //Este get devuelve un array con los coches
        {
            get { return coches; }
            set { coches = value; }
        }

        public double Precio//El precio se calcula al añadir un coche a la lista, por lo tanto solo se tendrá el getter
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}
