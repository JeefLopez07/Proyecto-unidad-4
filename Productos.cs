using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Productos
    {
        private int _intidProducto;
        public int idProducto
        { get { return _intidProducto; } set { _intidProducto = value; } }
        private string _strNombre;
        public string Nombre
        { get { return _strNombre; } set { _strNombre = value; } }
        private int _intPrecio;
        public int Precio
        { get { return _intPrecio; } set { _intPrecio = value; } }
        private int _intStock;
        public int Stock
        { get { return _intStock; } set { _intStock = value; } }
        private int _intCantidadCompda;
        public int CantidadComprada
        { get { return _intCantidadCompda; } set { _intCantidadCompda = value; } }

        int DevolverCantidad()
        {
            return CantidadComprada;
        }
    }
}
