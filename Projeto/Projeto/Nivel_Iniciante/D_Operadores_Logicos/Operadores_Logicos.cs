using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.D_Operadores_Logicos
{
    internal class Operadores_Logicos
    {
        static void Main(string[] args)
        {
            
            bool a = true;   // Declara uma variável booleana com valor verdadeiro
            bool b = false;  // Declara uma variável booleana com valor falso

            Console.WriteLine("a && b = " + (a && b)); // AND lógico: true se ambos forem verdadeiros
            Console.WriteLine("a || b = " + (a || b)); // OR lógico: true se pelo menos um for verdadeiro
            Console.WriteLine("!a = " + (!a));         // NOT lógico: inverte o valor (true vira false)
            Console.WriteLine("a ^ b = " + (a ^ b));   // XOR lógico: true se apenas um for verdadeiro

        }
    }
}
