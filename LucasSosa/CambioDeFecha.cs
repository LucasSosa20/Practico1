using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LucasSosa
{
    class Program
    {
        static void Main(string[] args)
        {
            do { 
            Console.WriteLine("Ingrese el día, el mes y el año :");
            int day = int.Parse(Console.ReadLine());

                if (day == 0)
                    break;

                

                int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            if (FechaValida(day, month, year))
            {
                string monthName = ObtenerNombreMes(month);
                Console.WriteLine($"{day} de {monthName} de {year}");
            }
            else
            {
                Console.WriteLine("Fecha inválida.");
            }
                Console.WriteLine("Si quiere terminar ingrese 0");
            
               } while (true);
        }

        static bool FechaValida(int day, int month, int year)
        {
            if (year < 1 || month < 1 || month > 12 || day < 1)
                return false;

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            

            return day <= daysInMonth[month];
        }

       

        static string ObtenerNombreMes(int month)
        {
            string[] monthNames = { "", "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            return monthNames[month];
        }
    }
}

