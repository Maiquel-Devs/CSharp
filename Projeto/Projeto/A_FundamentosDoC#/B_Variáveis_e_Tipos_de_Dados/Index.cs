using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.A_FundamentosDoC_.B_Variáveis_e_Tipos_de_Dados
{
    internal class Index
    {
        static void Main1(string[] args)
        {
            // Variáveis Principais em C#

            String nome = "João";   // Texto
            int idade = 20;         // Números inteiros
            float altura = 1.73f;   // Número decimal (obrigatório usar 'f' no final)
            bool sexo = true;       // Valores booleanos (true ou false)

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(sexo);


            // Variáveis Principais em C# - Parte 2

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

            // Constantes em C#

            const float PI = 3.14159f;
            const string PAIS = "Brasil";

            Console.WriteLine(PI);      // Constante numérica (float)
            Console.WriteLine(PAIS);    // Constante de texto (string)

            // Var em C#

            var Nome = "João";  // String
            var Idade = 25;     // Int
            var Altura = 1.75;  // Double
            var Ativo = true;   // Boolean

            Console.WriteLine(Nome);
            Console.WriteLine(Idade);
            Console.WriteLine(Altura);
            Console.WriteLine(Ativo);

            // Formas de exibir texto no Console

            Console.WriteLine(nome + " tem " + idade + " anos , tem " + altura + " de altura .");  // Concatenação

            Console.WriteLine($"{nome} tem {idade} anos, tem {altura} de altura.");     // Interpolação de strings
        }
    }
}
