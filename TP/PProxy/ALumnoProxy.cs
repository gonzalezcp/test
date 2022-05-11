using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP.PProxy
{
    public class ALumnoProxy : AlumnoComponent
    {
        private Alumno _alumnoReal = null;
        public StrategyDeComparacion strategyDeComparacion;
        public ALumnoProxy(string nombre, int dni, int legajo, int promedio)
        {
            this._promedio = promedio;
            this._legajo = legajo;
            this._nombre = nombre;
            this._dni = dni;
            this.strategyDeComparacion = new StrategyDeComparacionLegajo();
        }

        private int _calificacion;
        private int _legajo;
        private int _promedio;
        private string _nombre;
        private int _dni;

        public void SetCalifacion(int valor)
        {
            if (_alumnoReal == null)
                this._calificacion = valor;
            else
                _alumnoReal.SetCalifacion(valor);
        }
        public int GetCalificacion()
        {
            if (_alumnoReal == null)
                return this._calificacion;
            else
                return _alumnoReal.GetCalificacion();
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            if (_alumnoReal == null)
            { 
                _alumnoReal = new Alumno(_nombre, _dni, _legajo, _promedio);
                _alumnoReal.SetCalifacion(_calificacion);
            }
            return _alumnoReal.ResponderPregunta(pregunta);
        }

        public string MostrarCalificación()
        {
            if (_alumnoReal == null)
                return this.GetNombre() + " " + this.GetCalificacion();
            else
                return _alumnoReal.MostrarCalificación();
        }

        public bool SosIgual(Comparable o)
        {
            if (_alumnoReal == null)
                return strategyDeComparacion.SosIgual(this, (AlumnoComponent)o);
            else
                return _alumnoReal.SosIgual((AlumnoComponent)o);
        }

        public bool SosMenor(Comparable o)
        {
            if (_alumnoReal == null)
                return strategyDeComparacion.SosMenor(this, (AlumnoComponent)o);
            else
                return _alumnoReal.SosMenor((AlumnoComponent)o);
        }

        public bool SosMayor(Comparable o)
        {
            if (_alumnoReal == null)
                return strategyDeComparacion.SosMayor(this, (AlumnoComponent)o);
            else
                return _alumnoReal.SosMayor((AlumnoComponent)o);
        }

        public int GetLegajo()
        {
            if (_alumnoReal == null)
                return _legajo;
            else
                return _alumnoReal.GetLegajo();
        }

        public int GetPromedio()
        {
            if (_alumnoReal == null)
                return this._promedio;
            else
                return _alumnoReal.GetPromedio();
        }

        public override string ToString()
        {
            if (_alumnoReal == null)
                return "nombre: " + _nombre + ", dni: " + _dni + ", legajo: " + _legajo + ", promedio: " + _promedio;
            else
                return _alumnoReal.ToString();
        }

        public string GetNombre()
        {
            if (_alumnoReal == null)
                return _nombre;
            else
                return _alumnoReal.GetNombre();
        }

        public int GetDni()
        {
            if (_alumnoReal == null)
                return _dni;
            else
                return _alumnoReal.GetDni();
        }
    }
}
