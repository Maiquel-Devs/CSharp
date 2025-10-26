using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.F_Abstração
{
    internal class Index
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();

            cachorro.EmitirSom(); // Chama o método implementado na classe Cachorro

            Animal a = new Cachorro();

            a.EmitirSom();  // Chama o método implementado na classe Cachorro através da referência da classe abstrata

            // Animal a = new Animal(); // ERRO

        }
    }
}
