using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.B_Funcoes_e_Metodos.A_Métodos_Estáticos
{
    internal class Index
    {
            // Metódo Estático são aqueles que podem ser chamados sem a necessidade de instanciar um objeto da classe.


            // Método Esático Void

            // Void significa "vazio" — ele apenas executa uma ação e não retorna valor

            public static void MostrarMensagem(string nome)     // Coloca o public  para acessar fora da classe. 
        {
            Console.WriteLine("Bem-vindo, " + nome + "!");
        }


        // Método Estático com Retorno

        // Permite guardar um valor dentro de uma variável ou usá-lo em expressões.

        public static int Somar(int a, int b)
        {
            return a + b;   // Coloca-se o return para retornar o valor.
        }

        static void Main(string[] args)
        {

            MostrarMensagem("Maiquel");     // Chamando Método void.

            int resultado = Somar(1, 2);    // Armazenando dentro de uma variável.
            Console.WriteLine(resultado);
        }

        // No C#, métodos seguem a convenção de nomes PascalCase "LetraMaiúsculaNoInícioDeCadaPalavra".

        // Exemplo: MostrarMensagem(), CalcularTotal(), SomarValores()

    }
}

