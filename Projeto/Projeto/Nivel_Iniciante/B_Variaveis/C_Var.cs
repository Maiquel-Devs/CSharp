using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.B_Variaveis
{
    internal class C_Var
    {
        static void Main(string[] args)
        {
           
            var nome = "João";  // String
            var idade = 25;     // Int
            var altura = 1.75;  // Double
            var ativo = true;   // Boolean

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(ativo);

            // Var descobre automaticamente o tipo da variável com base no valor que você atribui a ela.
            // Porem ela não pode ser alterado.
        }
    }
}
