using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.B_Construtores
{
    internal class Index
    {
        class Pessoa
        {

            string nome;
            int idade;

            // Construtor       permite colocar parametros de uma classe ao instanciar um objeto.
            public Pessoa(string nome, int idade)
            {
                this.nome = nome;       // o this referencia o atributo da classe
                this.idade = idade;
            }

            public void Apresentar()
            {
                Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
            }

        }


        static void Main1(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Ana", 25);
            Pessoa pessoa2 = new Pessoa("Bruno", 30);
            
            pessoa1.Apresentar(); 
            pessoa2.Apresentar(); 
        }

    }
}
