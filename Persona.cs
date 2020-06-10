using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Persona
    {
        private int _intId;
        public int Id
        { get { return _intId; } set { _intId = value; } }

        private string _strNombre;
        public string Nombre
        { get { return _strNombre; } set { _strNombre = value; } }
        private int _intTelefono;
        public int Telefono
        { get { return _intTelefono; } set { _intTelefono = value; } }
        private int _intLada;
        public int Lada
        { get { return _intLada; } set { _intLada = value; } }
        private int _intEdad;
        public int Edad
        { get { return _intEdad; } set { _intEdad = value; } }        
    }
}
