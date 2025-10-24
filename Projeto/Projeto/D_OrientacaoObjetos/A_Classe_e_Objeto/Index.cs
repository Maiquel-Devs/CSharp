using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.A_Classe_e_Objeto
{
    internal class Index
    {

        class Pessoa 
        {
            // Atributos — características da classe

            public string Nome;
            public int Idade;

            // Método — comportamento da classe
            public void Falar()
            {
                Console.WriteLine($"{Nome} está falando.");
            }
               
        }


        static void Main(string[] args)
        {
            // Criando um objeto da classe Pessoa

            Pessoa p1 = new Pessoa();

            // Atribuindo valores aos atributos

            p1.Nome = "João";
            p1.Idade = 25;

            // Chamando o método

            p1.Falar();     // Saída: João está falando.

        }
    }
}
