using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.H_Método_Estático
{
    internal class Void
    {

        // Método estático criado fora do corpo do Main
        public static void MostrarMensagem(string nome)
        {
            Console.WriteLine("Bem-vindo, " + nome + "!");
        }

        static void Main(string[] args)
        {
            MostrarMensagem("Marcos"); // Chamando o método
        }

        
        // Void significa "vazio" — ele apenas executa uma ação e não retorna valor.

        // Métodos em C# também não podem ser declarados dentro de outros métodos (por isso criamos fora do Main).

        // Um método estático pode ser chamado diretamente pela classe, sem instanciar um objeto.
        // Exemplo: NomeDaClasse.MetodoEstatico();

        // Por Pãdrão os métodos em C# são privado então se quiser acessar fora da classe colocar public.

    }
}
