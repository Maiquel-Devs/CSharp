using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Projeto.D_OrientacaoObjetos.D_Heraca
{
    internal class Cachorro : Animal  // Herança da classe Animal
    {

        public Cachorro(string nome, int idade) : base(nome, idade)   // Chama o construtor da classe base (Animal)   é o super() do C#
        {
           
        }

        // Método específico da classe Cachorro
        public void Latir()
        {
            Console.WriteLine("Au au!");
        }
    }
}
