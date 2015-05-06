using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTD.EN
{
    class BonificacionesEN
    {
        private string idBonificacion;
        private double cantidadBonificacion;
        private string descripcion;
        private double cantidadGastada;

        //Getters y Setters
        public string Id
        {
            get { return idBonificacion; }
            set { idBonificacion = value; }
        }

        public double CantidadBonificacion
        {
            get { return cantidadBonificacion; }
            set { cantidadBonificacion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double CantidadGastada
        {
            get { return cantidadGastada; }
            set { cantidadGastada = value; }
        }
    }
}
