using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.CAD;

namespace LibreriaTD.EN
{

    class CestaEN
    {
        private string idCliente;
        private List<CocheEN> coches;
        private double precio;

        public CestaEN(string id)
        {
            idCliente = id;
            precio = 0;
        }

        public void Insertar()
        {
            CestaCAD aux = new CestaCAD();
            aux.Insertar(this);
        }

        public void Borrar()
        {
            CestaCAD aux = new CestaCAD();
            aux.Borrar(this);
        }

        public void AddCoche(CocheEN coche)
        {
            CestaCAD aux = new CestaCAD();
            if (aux.InsertarCoche(this, coche))
            {
                coches.Add(coche);
                precio += coche.Precio;
            }
        }

        public void DeleteCoche(CocheEN coche)
        {
            CestaCAD aux = new CestaCAD();
            if(aux.BorrarCoche(this, coche))
            {
                coches.Remove(coche);
                precio -= coche.Precio;
            }
            
        }



        //Getters Setters
        public string IdCliente //Este id nunca se modificará por lo tanto no tiene setter
        {
            get { return idCliente; }
        }

        public List<CocheEN> Coches //Este get devuelve un array con los coches
        {
            get { return coches; }
        }

        public double Precio//El precio se calcula al añadir un coche a la lista, por lo tanto solo se tendrá el getter
        {
            get { return precio; }
        }

    }
}
