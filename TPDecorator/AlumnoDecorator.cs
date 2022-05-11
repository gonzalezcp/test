using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDecorator
{
    public abstract class AlumnoDecorator : AlumnoComponet
    {
        protected AlumnoComponet _alumnoCompomponet;
        public AlumnoDecorator(AlumnoComponet alumnoCompomponet)
        {
            _alumnoCompomponet = alumnoCompomponet;
        }

        public int GetCalificacion()
        {
            return _alumnoCompomponet.GetCalificacion();
        }

        public int GetDni()
        {
            return _alumnoCompomponet.GetDni();
        }

        public int GetLegajo()
        {
            return _alumnoCompomponet.GetLegajo();
        }

        public string GetNombre()
        {
            return _alumnoCompomponet.GetNombre();
        }

        public int GetPromedio()
        {
            return _alumnoCompomponet.GetPromedio();
        }

        public abstract string MostrarCalificación();

        public int ResponderPregunta(int pregunta)
        {
            return _alumnoCompomponet.ResponderPregunta(pregunta);
        }

        public void SetCalifacion(int valor)
        {
            _alumnoCompomponet.SetCalifacion(valor);
        }

        public void SetEstartegiaDeComparacion(StrategyDeComparacion strategyDeComparacion)
        {
            _alumnoCompomponet.SetEstartegiaDeComparacion(strategyDeComparacion);
        }

        public bool SosIgual(Comparable o)
        {
            return _alumnoCompomponet.SosIgual(o);
        }

        public bool SosMayor(Comparable o)
        {
            return _alumnoCompomponet.SosMayor(o);
        }

        public bool SosMenor(Comparable o)
        {
            return _alumnoCompomponet.SosMenor(o);
        }
    }
}
