using System;
using System.Threading;

namespace dadoCsharp
{
    class Program
    {
        static void DibujarDado(int caraSuperior, int caraFrontal, int caraIzquierda)
        {

            //cara superior
            Console.WriteLine("                    ###########");
            Console.WriteLine("                    #         #");
            Console.WriteLine("                    #    {0}    #", caraSuperior);
            Console.WriteLine("                    #         #"); 
            //caras frontales 
            Console.WriteLine("#########################################");
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#    {0}    #    {1}    #    {2}    #    {3}    #",7-caraFrontal,7- caraIzquierda , caraFrontal, caraIzquierda);
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#########################################");
            //cara inferior   
            Console.WriteLine("                    #         #");
            Console.WriteLine("                    #    {0}    #", 7-caraSuperior);
            Console.WriteLine("                    #         #");
            Console.WriteLine("                    ###########");
 
        }
        static void Main(string[] args)
        {

            ConsoleKeyInfo keyInfo;

            Console.WriteLine("Bienvenido a la aplicación Dado en C#." );
            Console.WriteLine("Presione Escape para terminar la aplicación");
            Console.WriteLine("Presione Enter para ver una nueva visualización.");
            Console.WriteLine("--------------------------------------");

            do
            {

                while (!Console.KeyAvailable)
                { }
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(Environment.NewLine +"Has solicitado una Nueva Visualización" + Environment.NewLine);
                    DibujarDado(4, 5, 6);
                }


            } while (keyInfo.Key != ConsoleKey.Escape);

            Console.WriteLine("Aplicación finalizada." + Environment.NewLine);
            Environment.Exit(0);
        }
    }
}
