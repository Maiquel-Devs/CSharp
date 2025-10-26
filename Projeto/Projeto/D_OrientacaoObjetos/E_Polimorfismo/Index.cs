using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.E_Polimorfismo
{
    internal class Index
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Rex", 3);

            cachorro.EmitirSom();  // Saída: Latindo
        }
    }
}
