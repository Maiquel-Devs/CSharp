using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_.E_Estruturas_condicionais
{
    internal class Index
    {
        static void Main(string[] args)
        {
            //  IF / ELSE IF / ELSE

            int a = 10;

            if (a > 10)     // Se
            {
                Console.WriteLine(a + " é maior que 10");
            }
            else if (a < 10)    // Caso contrário, se
            {
                Console.WriteLine(a + " é menor que 10");
            }
            else    // Caso contrário
            {
                Console.WriteLine(a + " é igual a 10");
            }


            // SWITCH CASE

            Console.Write("Digite um número de 1 a 3: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)      // Colocar a variável a ser verificada
            {
                case 1:     // Caso a variável seja igual a 1
                    Console.WriteLine("Você escolheu a opção 1.");
                    break;
                case 2:     // Caso a variável seja igual a 2
                    Console.WriteLine("Você escolheu a opção 2.");
                    break;
                case 3:     // Caso a variável seja igual a 3
                    Console.WriteLine("Você escolheu a opção 3.");
                    break;
                default:    // Caso a variável não seja igual a nenhuma das opções acima
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }
    }
}
