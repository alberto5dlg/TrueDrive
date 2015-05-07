using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.CAD;

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

        //Métodos
        //Inserta una bonificación en la BD
        public void Insertar()
        {
            BonificacionesCAD aux = new BonificacionesCAD();
            aux.Insertar(this);
        }
        //Borra una bonificación de la BD
        public void Borrar()
        {
            BonificacionesCAD aux = new BonificacionesCAD();
            aux.Borrar(this);
        }
        //Actualiza la bonificación
        public void Actualizar()
        {
            BonificacionesCAD aux = new BonificacionesCAD();
            aux.Actualizar(this);
        }
    }
}
