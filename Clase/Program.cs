namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese opcion");
            Console.WriteLine("1 - Clase 1");
            Console.WriteLine("2 - Clase 2 - Strategy 1");
            Console.WriteLine("3 - Clase 2 - Strategy 2");
            Console.WriteLine("4 - Clase 2 - Iterator IEnumerable");
            Console.WriteLine("5 - Clase 2 - Iterator nuestro");
            Console.WriteLine("6 - Clase 2 - Iterator de Documentos");
            Console.WriteLine("7 - Clase 3 - Factory Method");
            Console.WriteLine("8 - Clase 3 - Factory Method Bici");
            Console.WriteLine("9 - Clase 3 - Observer");
            Console.WriteLine("10 - Clase 4 - Adapter");
            Console.WriteLine("11 - Clase 4 - Decorator");
            Console.WriteLine("12 - Clase 4 - Decorator Infusion");
            Console.WriteLine("13 - Clase 5 - Proxy");
            Console.WriteLine("14 - Clase 5 - Command");


            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    Clase1.Main.Run();
                    break;
                case "2":
                    Strategy1.Main.Run();
                    break;
                case "3":
                    Strategy2.Main.Run();
                    break;
                case "4":
                    PIterator.Main.Run();
                    break;
                case "5":
                    Iterator2.Main.Run();
                    break;
                case "6":
                    PIterator3.Main.Run();
                    break;
                case "7":
                    FM.Main.Run();
                    break;
                case "8":
                    FMBicicletas.Main.Run();
                    break;
                case "9":
                    PObserver.Main.Run();
                    break;
                case "10":
                    PAdapter.Main.Run();
                    break;
                case "11":
                    PDecorator.Main.Run();
                    break;
                case "12":
                    PDecorator2.Main.Run();
                    break;
                case "13":
                    PProxy.Main.Run();
                    break;
                case "14":
                    PCommand.Main.Run();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}