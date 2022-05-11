using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP
{
    public class Alumno : Persona, AlumnoComponent
    {
        //Contexto en Strategy
        //Adaptee en Adapter
        //Component en Decorator
        //Real Subject de Proxy
        public StrategyDeComparacion strategyDeComparacion;
        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this._promedio = promedio;
            this._legajo = legajo;
            this.strategyDeComparacion = new StrategyDeComparacionLegajo();
            Console.WriteLine("Creando alumno Real Nombre: " + nombre + " Dni: "+dni);
            Thread.Sleep(1000);
        }

        private int _calificacion;
        private int _legajo;
        private int _promedio;

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


        public override bool SosIgual(Comparable o)
        {
            return strategyDeComparacion.SosIgual(this, (AlumnoComponent)o);
        }

        public override bool SosMenor(Comparable o)
        {
            return strategyDeComparacion.SosMenor(this, (AlumnoComponent)o);
        }

        public override bool SosMayor(Comparable o)
        {
            return strategyDeComparacion.SosMayor(this, (AlumnoComponent)o);
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
    }
}
