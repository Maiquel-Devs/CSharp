using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.C_EstruturaDeDadosComposta.C_Dicionários
{
    internal class Index
    {
        static void Main(string[] args)
        {
            // Dicionários em C#


            // Um dicionário armazena pares de chave e valor.
            
            // Cada chave é única e permite acessar rapidamente o valor associado a ela.

            
            // Criação de um dicionário com chaves do tipo string e valores do tipo int

            Dictionary<string, int> idades = new Dictionary<string, int>();

            // Adicionando elementos

            idades["João"] = 25;    // Adiciona a chave "João" com o valor 25     string "João"    int 25
            idades["Maria"] = 30;
            idades["Pedro"] = 22;

            // Acessando valores

            Console.WriteLine(idades["Maria"]); // 30

            // Verificando se a chave existe

            if (idades.ContainsKey("Pedro"))
            {
                Console.WriteLine("Pedro está no dicionário!");
            }

            // Percorrendo todos os itens

            foreach (var item in idades)
            {
                Console.WriteLine($"{item.Key} tem {item.Value} anos.");
            }
        }
    }
}
