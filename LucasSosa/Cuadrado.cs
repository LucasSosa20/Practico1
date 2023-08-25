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
                Console.Write("Ingrese el tamaño del lado del cuadrado: ");
                int lado = int.Parse(Console.ReadLine());

                if (lado > 0)
                {
                    for (int i = 1; i <= lado; i++)
                    {
                        for (int j = 1; j <= lado; j++)
                        {
                            if (i == 1 || i == lado || j == 1 || j == lado)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }

                Console.WriteLine();
            }
                else
                {
                    Console.WriteLine("El tamaño del lado debe ser mayor que 0.");
                }
            }
        }
    

}

