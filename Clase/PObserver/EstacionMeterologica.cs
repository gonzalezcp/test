using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PObserver
{
    public class EstacionMeterologica : Subject
    {
        string _nombre;
        int temp = 0;
        int humedad = 0;
        int presion = 0;

        public void SetTemperatura(int temp)
        {
            this.temp = temp;
            this.NotifyObserver();
        }

        public void SetPresion(int presion)
        {
            this.presion = presion;
            this.NotifyObserver();
        }

        public void SetHumedad(int humedad)
        {
            this.humedad = humedad;
            this.NotifyObserver();
        }
        public EstacionMeterologica(string nombre)
        {
            this._nombre = nombre;
        }
        List<Observer> observadores = new List<Observer>();

        public void AddObserver(Observer o)
        {
            observadores.Add(o);
        }

        public void NotifyObserver()
        {
            foreach (Observer o in observadores)
            {
                o.Update(this);
            }
        }

        public void RemoveObserver(Observer o)
        {
            observadores.Remove(o);
        }

        public override string ToString()
        {
            return _nombre + "presion: " + presion + ", humedad: "+ humedad + " temperatura: " + temp;
        }
    }
}
