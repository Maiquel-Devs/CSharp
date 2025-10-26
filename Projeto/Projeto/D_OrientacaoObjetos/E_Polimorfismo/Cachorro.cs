using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.E_Polimorfismo
{
    internal class Cachorro : Animal
    {
        public Cachorro (string nome , int idade) : base (nome , idade)
        {

        }
        
        public override void EmitirSom()    // Escreva "override" para sobrescrever o método da classe base
        {
            Console.WriteLine("Au au!");
        }
    }
}
