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
            Console.WriteLine("6 - TP 4 Adapter");
            Console.WriteLine("7 - TP 4 Decorator");
            Console.WriteLine("8 - TP 5 Proxy");
            //Console.WriteLine("8 - TP 5 Command");

            Console.WriteLine("100 - Test");

            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    TP.TP1.Run();
                    break;
                case "2":
                    TP.TP2.RunPersonas();
                    break;
                case "3":
                    TP.TP2.Run();
                    break;
                case "4":
                    TP.TP3.RunFactory();
                    break;
                case "5":
                    TP.TP3.RunJornadaDeVenas();
                    break;
                case "6":
                    TP.TP4.RunAdapter();
                    break;
                case "7":
                    TP.TP4.RunDecorator();
                    break;
                case "8":
                    TP.TP5.RunDecorator();
                    break;
                case "100":
                    TP.Test.Run();
                    break;
                default: Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
