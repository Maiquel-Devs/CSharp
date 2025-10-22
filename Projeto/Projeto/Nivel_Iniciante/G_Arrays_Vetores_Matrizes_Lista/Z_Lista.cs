using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.G_Arrays_Vetores_Matrizes_Lista
{
    internal class Z_Lista
    {

        static void Main(string[] args)
        {

            // Criando uma Lista tipo string
            List<string> nomes = new List<string>();

            // Adicionando intem na Lista
            nomes.Add("João");
            nomes.Add("Maria");
            nomes.Add("Ana");


            // Exibindo todos os nomes da lista
            Console.WriteLine("Lista de nomes:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }


            // Criando Lista de forma direta 
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };


            // Exibindo todos os números da Lista
            Console.WriteLine("Lista de números:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }



            // Ela guarda vários valores do mesmo tipo e pode crescer ou diminuir conforme necessário.

            // Diferente de um array (int[]), que tem tamanho fixo, uma List pode adicionar ou remover elementos livremente.

        }

    }
}
