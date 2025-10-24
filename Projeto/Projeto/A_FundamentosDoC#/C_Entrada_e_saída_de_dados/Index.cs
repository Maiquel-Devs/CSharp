using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_.C_Entrada_e_saída_de_dados
{
    internal class Index
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hellow Word");       // Unidade de saída no consolea

            string nome = Console.ReadLine();       // Console.ReadLine() lê texto digitado pelo usuário

            Console.WriteLine($"Olá, {nome}!");     // Saída usando interpolação


            int idade = int.Parse(Console.ReadLine());    // Converte a entrada de string para int

            Console.WriteLine(idade);

            float altura = float.Parse(Console.ReadLine());     // Converte a entrada de string para float

            Console.WriteLine(idade);

            // OBS : Por Padrão o Console.ReadLine(); é convertido para string.
        }

    }
}
