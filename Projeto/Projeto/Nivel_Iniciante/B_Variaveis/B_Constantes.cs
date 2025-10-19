using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.B_Variaveis
{
    internal class B_Constantes
    {
        static void Main(string[] args)
        {
            
            const float PI = 3.14159f;         
            const string PAIS = "Brasil";

            Console.WriteLine(PI);      // Constante numérica (float)
            Console.WriteLine(PAIS);    // Constante de texto (string)

            // Constantes são valores que não podem ser alterados após sua definição (são imutáveis).
        }
    }
}
