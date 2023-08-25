using System;
using System.Threading;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime hora = DateTime.Now;
                Console.Clear();  // Limpiar la consola para mostrar la hora actualizada

                Console.WriteLine("Reloj Digital");
                Console.WriteLine("---------------------");
                Console.WriteLine($"{hora:HH:mm:ss}");
                Console.WriteLine("---------------------");

                Thread.Sleep(1000);  // Espera 1 segundo
            }
        }
    }
}


