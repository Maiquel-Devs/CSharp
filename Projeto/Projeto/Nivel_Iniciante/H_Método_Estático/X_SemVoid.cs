using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.H_Método_Estático
{
    internal class X_SemVoid
    {

        public static int Somar(int a, int b)
        {
            return a + b; // Obrigatório usar return neste caso.
        }

        static void Main(string[] args)
        {
            int resultado = Somar(2, 2); // Chamando o método e guardando em uma variável
            Console.WriteLine(resultado); // Imprimindo o resultado
        }


        // O método estático sem void precisa declarar o tipo de retorno (nesse caso, int).

        // É obrigatório usar 'return' para devolver o resultado.

        // O valor retornado pode ser guardado em uma variável ou usado diretamente em uma expressão.
    }
}
