using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.FM;
using TP.PAdapter;
using TP.PDecorator;

namespace TP
{
    public class TP4
    {
        public static void RunAdapter()
        {
            Teacher teacher = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Alumno al = (Alumno)FMComparables.CrearAleatorio("2");
                StudentAdapter student = new StudentAdapter(al);
                teacher.goToClass(student);
            }
            for (int i = 0; i < 10; i++)
            {
                Alumno al = (Alumno)FMComparables.CrearAleatorio("4");
                StudentAdapter student = new StudentAdapter(al);
                teacher.goToClass(student);
            }
            teacher.teachingAClass();
        }

        public static void RunDecorator()
        {
            Teacher teacher = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Alumno al = (Alumno)FMComparables.CrearAleatorio("2");
                AlumnoComponent alumnoDecorado = new LegajoDecorator(al);
                StudentAdapter student = new StudentAdapter(alumnoDecorado);
                teacher.goToClass(student);
            }
            for (int i = 0; i < 10; i++)
            {
                Alumno al = (Alumno)FMComparables.CrearAleatorio("4");
                AlumnoComponent alumnoDecorado = new LegajoDecorator(al);
                StudentAdapter student = new StudentAdapter(alumnoDecorado);
                teacher.goToClass(student);
            }
            teacher.teachingAClass();
        }

        public static void TestDecorator()
        {
            Alumno alumno = new Alumno("Josefina", 1, 1, 8);
            AlumnoComponent alumnoDecorado = new LegajoDecorator(alumno);
            Console.WriteLine(alumnoDecorado.MostrarCalificación());
        }
    }
}
