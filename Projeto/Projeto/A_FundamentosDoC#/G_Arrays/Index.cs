using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_.G_Arrays
{
    internal class Index
    {
        static void Main (string [] args)
        {
            // 9 Arrays (Vetores) em C#


            // 1. Criando um array de inteiros

            int[] numeros = new int[5];     // Array com 5 elementos

            // Atribuindo valores

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            // Exibindo valores

            Console.WriteLine("Array de números:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine();

            
            // 2. Criando um array de strings diretamente

            string[] nomes = { "João", "Maria", "Ana" };

            Console.WriteLine("Array de nomes:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine();

            
            // 3. Propriedades importantes do array
            
            Console.WriteLine("Tamanho do array numeros: " + numeros.Length);
            Console.WriteLine("Tamanho do array nomes: " + nomes.Length);

        }

    }
}
