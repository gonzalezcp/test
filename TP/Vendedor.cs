using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PObsever;

namespace TP
{
    public class Vendedor : Persona, Observable
    {
        //Concrte Subject en el Observer
        int _sueldoBasico = 0;
        double _bonus = 0;
        public int ultimaVenta = 0;
        List<Observador> observadores = new List<Observador>();
        public Vendedor(string nombre, int dni, int sueldo) : base(nombre, dni)
        {
            _sueldoBasico = sueldo;
        }

        public void Venta(int monto)
        {
            ultimaVenta = monto;
            NotifyObserver();
            //Console.WriteLine("el vendedor " + _nombre + " hizo una venta de $" + monto + " de monto");
        }

        public void AumentaBonus()
        {
            _bonus = _bonus + 0.1;
        }

        public override string ToString()
        {
            return "nombre: " + _nombre + ", dni: " + _dni + ", sueldo: " + _sueldoBasico + ", bonus: " + _bonus;
        }

        public void AddObserver(Observador o)
        {
            observadores.Add(o);
        }

        public void RemoveObserver(Observador o)
        {
            observadores.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (Observador o in observadores)
            {
                o.Update(this);
            }
        }
    }
}
