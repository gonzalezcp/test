using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP.PAdapter
{
    //Adapter en Adapter
    public class StudentAdapter : Student
    {
        public AlumnoComponent _alumno;
        public StudentAdapter(AlumnoComponent alumno)
        {
            this._alumno = alumno;
        }
        public bool equals(Student student)
        {
            return this._alumno.SosIgual(((StudentAdapter)student)._alumno);
        }

        public string getName()
        {
            return _alumno.GetNombre();
        }

        public bool greaterThan(Student student)
        {
            return this._alumno.SosMayor(((StudentAdapter)student)._alumno);
        }

        public bool lessThan(Student student)
        {
            return this._alumno.SosMenor(((StudentAdapter)student)._alumno);
        }

        public void setScore(int score)
        {
            _alumno.SetCalifacion(score);
        }

        public string showResult()
        {
            return _alumno.MostrarCalificación();
        }

        public int yourAnswerIs(int question)
        {
            return _alumno.ResponderPregunta(question);
        }
    }
}
