using System;
using System.Threading;

namespace dadoCsharp
{
    class Program
    {

        static int[] ObtenerValoresAleatorios()
        {
            Random aleatorio = new Random();
            int indice = 0;
            int[] respuesta = new int[3];

            while (indice < 3)
            {
                int nuevoAleatorio = aleatorio.Next(1, 7);

                if (nuevoAleatorio != respuesta[0] && nuevoAleatorio != respuesta[1] && nuevoAleatorio != respuesta[2] &&
                    7 - nuevoAleatorio != respuesta[0] && 7 - nuevoAleatorio != respuesta[1] && 7 - nuevoAleatorio != respuesta[2])
                {

                    respuesta[indice] = nuevoAleatorio;
                    indice++;
                }

            }
            return respuesta;
        }
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
            Console.WriteLine("#    {0}    #    {1}    #    {2}    #    {3}    #", 7 - caraFrontal, 7 - caraIzquierda, caraFrontal, caraIzquierda);
            Console.WriteLine("#         #         #         #         #");
            Console.WriteLine("#########################################");
            //cara inferior   
            Console.WriteLine("                    #         #");
            Console.WriteLine("                    #    {0}    #", 7 - caraSuperior);
            Console.WriteLine("                    #         #");
            Console.WriteLine("                    ###########");

        }
        static void Main(string[] args)
        {

            ConsoleKeyInfo keyInfo;

            Console.WriteLine("Bienvenido a la aplicación Dado en C#.");
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

                    Console.WriteLine(Environment.NewLine + "Has solicitado una Nueva Visualización" + Environment.NewLine);
                    DibujarDado(4, 5, 6);
                   
                    int[] valores = ObtenerValoresAleatorios();
                    Console.WriteLine("Números: {0} -- {1} -- {2}", valores[0], valores[1], valores[2]);
                }


            } while (keyInfo.Key != ConsoleKey.Escape);

            Console.WriteLine("Aplicación finalizada." + Environment.NewLine);
            Environment.Exit(0);
        }
    }
}
