using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Alumno : Persona
    {
        public StrategyDeComparacion strategyDeComparacion;
        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this._promedio = promedio;
            this._legajo = legajo;
            this.strategyDeComparacion = new StrategyDeComparacionLegajo();
        }

        private int _legajo;
        private int _promedio;

        public override bool SosIgual(Comparable o)
        {
            return strategyDeComparacion.SosIgual(this, (Alumno)o);
        }

        public override bool SosMenor(Comparable o)
        {
            return strategyDeComparacion.SosMenor(this, (Alumno)o);
        }

        public override bool SosMayor(Comparable o)
        {
            return strategyDeComparacion.SosMayor(this, (Alumno)o);
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
