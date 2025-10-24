using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.C_EstruturaDeDadosComposta.B_Tuplas
{
    internal class Index
    {
        static void Main (string[] args)
        {
            // TUPLAS EM C#
            

            // Tuplas permitem armazenar múltiplos valores em uma única variável.
            // Cada valor pode ter um tipo diferente (ex: string, int, bool, etc).
            // São úteis quando queremos retornar ou agrupar dados rapidamente.

            
            // Criando uma tupla simples
         
            var pessoa = ("João", 25);      // Usase o var para inferir o tipo da tupla

            Console.WriteLine("Tupla simples:");
            Console.WriteLine(pessoa.Item1); // João
            Console.WriteLine(pessoa.Item2); // 25

            Console.WriteLine();

            
            // Nomeando os elementos da tupla
            
            var aluno = (Nome: "Maria", Idade: 22, Ativo: true);

            Console.WriteLine("Tupla com nomes:");
            Console.WriteLine(aluno.Nome);   // Maria
            Console.WriteLine(aluno.Idade);  // 22
            Console.WriteLine(aluno.Ativo);  // True

            Console.WriteLine();

            
            // Retornando uma tupla de um método
            
            var resultado = CalcularOperacoes(10, 5);

            Console.WriteLine("Tupla retornada por um método:");
            Console.WriteLine($"Soma: {resultado.soma}");
            Console.WriteLine($"Multiplicação: {resultado.multiplicacao}");
        }

        // Método que retorna uma tupla nomeada
        static (int soma, int multiplicacao) CalcularOperacoes(int a, int b)
        {
            int soma = a + b;
            int multiplicacao = a * b;
            return (soma, multiplicacao);
        }
    }

}

