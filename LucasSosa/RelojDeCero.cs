using System;
using System.Threading;

namespace Reloj
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            while (true)
            {
                Console.Clear();  // Limpiar la consola para mostrar el tiempo actualizado

                Console.WriteLine("       Reloj         ");
                Console.WriteLine("---------------------");

                string Hora = hours < 10 ? "0" + hours : hours.ToString();
                string Minutos = minutes < 10 ? "0" + minutes : minutes.ToString();
                string Segundos = seconds < 10 ? "0" + seconds : seconds.ToString();

                Console.WriteLine ($"     {Hora}:{Minutos}:{Segundos}");

                Console.WriteLine("---------------------");

                seconds++;

                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;

                    if (minutes == 60)
                    {
                        minutes = 0;
                        hours++;

                        if (hours == 24)
                        {
                            hours = 0;
                        }
                    }
                }

                Thread.Sleep(1000);  // Esperar 1 segundo
            }
        }
    }
}

