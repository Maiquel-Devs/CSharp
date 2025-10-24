using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_.H_Listas
{
    internal class Index
    {
        static void Main(string[] args)
        {
            //  Listas em C#
            
            
            // 1. Criando uma lista de strings
            
            List<string> nomes = new List<string>();

            // Adicionando elementos

            nomes.Add("João");
            nomes.Add("Maria");
            nomes.Add("Ana");

            // Exibindo valores

            Console.WriteLine("Lista de nomes:");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine();

            
            // 2. Criando uma lista de inteiros diretamente
            
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Lista de números:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();

            
            // 3. Propriedades e métodos importantes
            
            Console.WriteLine("Quantidade de elementos na lista nomes: " + nomes.Count);
            Console.WriteLine("Quantidade de elementos na lista numeros: " + numeros.Count);

            // Removendo elementos

            numeros.Remove(3);      // Remove o valor 3
            nomes.RemoveAt(0);      // Remove o primeiro elemento (índice 0)


            Console.WriteLine("Lista de números após remover o 3:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Lista de nomes após remover o primeiro elemento:");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            /* 
                Ela guarda vários valores do mesmo tipo e pode crescer ou diminuir conforme necessário.

                Diferente de um array (int[]), que tem tamanho fixo, uma List pode adicionar ou remover elementos livremente.
            */
        }

    }
}
