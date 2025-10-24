using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_.F_Estruturas_de_Repeticao
{
    internal class Index
    {
        static void Main(string[] args)
        {
            // While 

            int A = 0;

            while (A < 5)       // Executa o bloco enquanto a condição for verdadeira.
            {
                Console.WriteLine("A = " + A);
                A++;
            }


            // Do ..While

            int B = 0;

            do                  // Executa pelo menos uma vez, e depois verifica a condição.
            {
                Console.WriteLine("B = " + B);
                B++;
            } while (B < 5);


            // For

            for (int C = 0; C > 5; C++)         // Laço com inicialização, condição e incremento
            {
                Console.WriteLine("C = " + C);
            }


            // Foreach

            string[] frutas = { "Maçã", "Banana", "Laranja" };

            foreach (string fruta in frutas)        // Muito usado para arrays ou listas.
            {
                Console.WriteLine("Fruta: " + fruta);
            }


            // break → interrompe o laço imediatamente.
            // continue → pula a iteração atual e vai para a próxima.

        }

    }
}
