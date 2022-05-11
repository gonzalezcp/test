using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDecorator2
{
    public class Alumno : AlumnoComponet
    {
        // En Strategy es el Context
        // En Decorator es Concrete Component
        public StrategyDeComparacion strategyDeComparacion;
        public void SetEstartegiaDeComparacion(StrategyDeComparacion strategyDeComparacion)
        {
            this.strategyDeComparacion = strategyDeComparacion;
        }
        public Alumno(string nombre, int dni, int legajo, int promedio)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._promedio = promedio;
            this._legajo = legajo;
            this.strategyDeComparacion = new StrategyDeComparacionLegajo();
        }

        private int _calificacion;
        private int _legajo;
        private int _promedio;
        private string _nombre;
        private int _dni;

        public void SetCalifacion(int valor)
        {
            this._calificacion = valor;
        }
        public int GetCalificacion()
        {
            return this._calificacion;
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            return new Random().Next(1,3);
        }

        public string MostrarCalificación()
        {
            return this.GetNombre() + " " + this.GetCalificacion();
        }

        public bool SosIgual(Comparable o)
        {
            return strategyDeComparacion.SosIgual(this, (AlumnoComponet)o);
        }

        public bool SosMenor(Comparable o)
        {
            return strategyDeComparacion.SosMenor(this, (AlumnoComponet)o);
        }

        public bool SosMayor(Comparable o)
        {
            return strategyDeComparacion.SosMayor(this, (AlumnoComponet)o);
        }

        public int GetLegajo()
        {
            return _legajo;
        }

        public int GetPromedio()
        {
            return this._promedio;
        }

        public override string ToString()
        {
            return "nombre: " + _nombre + ", dni: " + _dni + ", legajo: " + _legajo + ", promedio: " + _promedio;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public int GetDni()
        {
            return _dni;
        }
    }
}
