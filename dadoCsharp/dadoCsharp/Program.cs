using System;
using System.Threading;

namespace dadoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo keyInfo;

            Console.WriteLine("Bienvenido a la aplicación Dado en C#." + Environment.NewLine);
            Console.WriteLine("Presione Escape para terminar la aplicación" + Environment.NewLine);
            Console.WriteLine("Presione Enter para ver una nueva visualización." + Environment.NewLine);
            Console.WriteLine("--------------------------------------" + Environment.NewLine);

            do
            {

                while (!Console.KeyAvailable)
                { }
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Has solicitado una Nueva Visualización");
                }


            } while (keyInfo.Key != ConsoleKey.Escape);

            Console.WriteLine("Aplicación finalizada." + Environment.NewLine);
            Environment.Exit(0);
        }
    }
}
