using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.C_Operadores_Aritmeticos
{
    internal class Operadores_Aritmeticos
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;

            Console.WriteLine("a + b = " + (a + b));    // 12 (adição)
            Console.WriteLine("a - b = " + (a - b));    // 8 (subtração)
            Console.WriteLine("a * b = " + (a * b));    // 20 (multuplicação)
            Console.WriteLine("a / b = " + (a / b));    // 5 (divisão)
            Console.WriteLine("a % b = " + (a % b));    // 0 (resto da divisão)

        }
    }
}
