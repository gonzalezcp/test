namespace Tp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese opcion");
            Console.WriteLine("1 - TP 1");
            Console.WriteLine("2 - TP 2 Personas");
            Console.WriteLine("3 - TP 2 Alumnos");
            Console.WriteLine("4 - TP 3 Factory");
            Console.WriteLine("5 - TP 3 Observer");

            Console.WriteLine("100 - Test");

            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    TP3.TP1.Run();
                    break;
                case "2":
                    TP3.TP2.RunPersonas();
                    break;
                case "3":
                    TP3.TP2.Run();
                    break;
                case "4":
                    TP3.TP3.RunFactory();
                    break;
                case "5":
                    TP3.TP3.RunJornadaDeVenas();
                    break;
                case "100":
                    TP3.Test.Run();
                    break;
                default: Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
