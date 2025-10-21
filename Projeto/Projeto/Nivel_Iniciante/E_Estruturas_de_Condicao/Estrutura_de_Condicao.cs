using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.E_Estruturas_de_Condicao
{
    internal class Estrutura_de_Condicao
    {
        static void Main (string[] args)
        {
            
            int a = 10;

            if (a > 10)
            {
                Console.WriteLine(a + " é maior que 10");
            }
            else if (a < 10)
            {
                Console.WriteLine(a + " é menor que 10");
            }
            else
            {
                Console.WriteLine(a + " é igual a 10");
            }

            /* 
             Operadores de Comparação

                  ==  → igual a
                  !=  → diferente de
                  >   → maior que
                  <   → menor que
                  >=  → maior ou igual a
                  <=  → menor ou igual a
            */

            /* 
                If e Else de uma linha 

                if (true) Console.WriteLine("Entrou no if");
                else Console.WriteLine("Entrou no else");
            */
        }
    }
}
