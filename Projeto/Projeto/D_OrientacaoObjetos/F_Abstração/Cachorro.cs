using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.F_Abstração
{
    internal class Cachorro : Animal // Herda da classe abstrata Animal
    {
        public override void EmitirSom() // Implementação do método abstrato
        {
            Console.WriteLine("O cachorro late: Au Au!");
        }
    }
}
