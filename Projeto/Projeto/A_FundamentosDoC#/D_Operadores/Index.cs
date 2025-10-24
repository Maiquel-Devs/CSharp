using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_
{
    internal class Index
    {

        static void Main(string[] args)
        {            
            // Operadores Aritméticos

            Console.WriteLine("=== Operadores Aritméticos ===");
            int a = 10;
            int b = 5;

            Console.WriteLine("Soma: " + (a + b));              // 15 (adição)
            Console.WriteLine("Subtração: " + (a - b));         // 5 (subtração)
            Console.WriteLine("Multiplicação: " + (a * b));     // 50 (multuplicação)
            Console.WriteLine("Divisão: " + (a / b));           // 2 (divisão)
            Console.WriteLine("Resto: " + (a % b));             // 0 (resto da divisão)

            Console.WriteLine();

            // Operadores Relacionais
            Console.WriteLine("=== Operadores Relacionais ===");
            Console.WriteLine("a == b: " + (a == b));       // Igual
            Console.WriteLine("a != b: " + (a != b));       // Diferente
            Console.WriteLine("a > b: " + (a > b));         // Maior que
            Console.WriteLine("a < b: " + (a < b));         // Menor que
            Console.WriteLine("a >= b: " + (a >= b));       // Maior ou igual
            Console.WriteLine("a <= b: " + (a <= b));       // Menor ou igual

            Console.WriteLine();

            // Operadores Lógicos
            Console.WriteLine("=== Operadores Lógicos ===");
            bool x = true;
            bool y = false;

            Console.WriteLine("x && y: " + (x && y));    // AND lógico: true se ambos forem verdadeiros
            Console.WriteLine("x || y: " + (x || y));    // OR lógico: true se pelo menos um for verdadeiro
            Console.WriteLine("!x: " + (!x));            // NOT lógico: inverte o valor (true vira false)
            Console.WriteLine("x ^ y: " + (x ^ y));      // XOR lógico: true se apenas um for verdadeiro

            Console.WriteLine();

            // Operadores de Atribuição
            Console.WriteLine("=== Operadores de Atribuição ===");
            int c = 10;
            c += 5;    // c = c + 5
            Console.WriteLine("c += 5: " + c);
            c -= 3;    // c = c - 3
            Console.WriteLine("c -= 3: " + c);
            c *= 2;    // c = c * 2
            Console.WriteLine("c *= 2: " + c);
            c /= 4;    // c = c / 4
            Console.WriteLine("c /= 4: " + c);
            c %= 3;    // c = c % 3
            Console.WriteLine("c %= 3: " + c);

            Console.WriteLine();

            // Incremento e Decremento
            Console.WriteLine("=== Incremento e Decremento ===");
            int d = 5;
            d++;    // Incremento: d = d + 1
            Console.WriteLine("d++: " + d);
            d--;    // Decremento: d = d - 1
            Console.WriteLine("d--: " + d);
        }

    }
}
