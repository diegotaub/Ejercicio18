using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Debe ingresar un número. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }

            Console.Write($"El número ingresado redondeado a dos decimales es: {Math.Round(num1, 2)}");
            Console.ReadKey();
        }
    }
}
