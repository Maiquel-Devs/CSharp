using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.D_Heraca
{
    internal class Animal
    {
        string nome;
        int idade;

        public Animal(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        // Método que vai ser herdado
        public void Comer()
        {
            Console.WriteLine($"{nome} está comendo...");
        }
    }
}
