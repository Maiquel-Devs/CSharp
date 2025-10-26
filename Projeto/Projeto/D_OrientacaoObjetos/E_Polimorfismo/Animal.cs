using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.E_Polimorfismo
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
        public virtual void EmitirSom()     // Escreva "virtual" para permitir sobrescrita em classes derivadas " subclasses / classe filhas"
        {
            Console.WriteLine("O animal está emitindo um som genérico");
        }
    }
}
