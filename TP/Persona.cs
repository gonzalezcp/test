using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Persona : Comparable
    {
        public Persona(string nombre, int dni)
        {
            this._nombre = nombre;
            this._dni = dni;
        }
        protected string _nombre;
        protected int _dni;
        public string GetNombre()
        {
            return _nombre;
        }

        public int GetDni()
        {
            return _dni;  
        }

        public virtual bool SosIgual(Comparable o)
        {
            return _dni == ((Persona)o)._dni;
        }

        public virtual bool SosMenor(Comparable o)
        {
            return _dni > ((Persona)o)._dni;
        }

        public virtual bool SosMayor(Comparable o)
        {
            return _dni < ((Persona)o)._dni;
        }

        public override string ToString()
        {
            return "nombre: " + _nombre + ", dni: " + _dni;
        }
    }
}
