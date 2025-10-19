using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.B_Variaveis
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            String nome = "João";   // Texto
            int idade = 20;         // Números inteiros
            float altura = 1.73f;   // Número decimal (obrigatório usar 'f' no final)
            bool sexo = true;       // Valores booleanos (true ou false)

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(sexo);


            Console.WriteLine(nome + " tem " + idade + " anos , tem " + altura + " de altura .");  // Concatenação

            Console.WriteLine($"{nome} tem {idade} anos, tem {altura} de altura.");     // Interpolação de strings

            Console.WriteLine("---------------------------");

            char letra = 'M';                   // Único caractere                 
            byte numeroPequeno = 30;            // Pequeno inteiro (-128 até 127)         
            short numeroMedio = 32000;          // Inteiro médio     
            long numeroGrande = 8000000000L;    // Inteiro longo (obrigatório colocar 'L' no final)
            double salario = 2500.99;           // Número decimal de maior precisão

            Console.WriteLine(letra);
            Console.WriteLine(numeroPequeno);
            Console.WriteLine(numeroMedio);
            Console.WriteLine(numeroGrande);
            Console.WriteLine(salario);


            // float: menor, ocupa menos memória, mas perde precisão em números muito longos. 32 bits ~7 casas decimais
            // double: maior, mais preciso, é o tipo padrão para decimais em C#. 64 bits ~15 casas decimais
        }
    }
}
