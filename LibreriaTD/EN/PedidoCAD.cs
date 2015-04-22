using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaTD.EN;

namespace LibreriaTD.CAD
{
    class PedidoCAD
    {
        //Creamos un nuevo pedido, insertando en la BD sus datos y devolviendo true. Devolvera false en otro caso.
        public bool NuevoPedido(PedidoEN nuevoPedido)
        {
            bool pedido = false;
            return pedido;
        }

        //Anularemos el pedido identificado por el codPedido que nos pasan. Si ha sido anulado devuelve true, false en otro caso.
        public bool AnularPedido(int codPedido)
        {
            bool anulado = false;
            return anulado;
        }

        //Modificaremos el pedido identificado por el codPedido que nos pasan (borrado y nueva creacion con mismo codPedido o modificacion de campos). 
        public bool ModificarPedido(int codPedido, PedidoEN pedidoModificado)
        {
            bool modificado = false;
            return modificado;
        }

        //Mostramos la informacion del pedido socilitado, que se identifica por su codPedido. 
        public bool ConsultarPedido(int codPedido)
        {
            bool existe = false;
            return existe;
        }
    }
}