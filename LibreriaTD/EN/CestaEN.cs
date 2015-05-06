using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTD.EN
{

    class CestaEN
    {
        private string idCliente;
        private List<CocheEN> coches;
        private List<int> cantidad;
        private double precio;

        public CestaEN(string id)
        {
            idCliente = id;
            precio = 0;
        }

        public void AddCoche(CocheEN coche)
        {
            if (coches.Contains(coche))
            {
                cantidad[coches.IndexOf(coche)] += 1;
            }
            else
            {
                coches.Add(coche);
                cantidad.Add(1);
            }
            precio += coche.Precio;
        }

        public void DeleteCoche(CocheEN coche)
        {
            if(coches.Contains(coche))
            {
                if (cantidad[coches.IndexOf(coche)] == 1)
                {
                    cantidad.RemoveAt(coches.IndexOf(coche));
                    coches.Remove(coche);
                }
                else
                {
                    cantidad.RemoveAt(coches.IndexOf(coche));
                }
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
