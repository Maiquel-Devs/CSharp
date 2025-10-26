using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.D_Heraca
{
    internal class Index
    {
        static void Main(string[] args)
        {
            // Criando um objeto da classe Cachorro

            Cachorro chachorro = new Cachorro("Rex", 3);


            // Usando o método herdado da classe Animal

            chachorro.Comer();  // Saída: O cachorro Rex está comendo.

            // Usando o método específico da classe Cachorro

            chachorro.Latir();  // Saída: O cachorro Rex está latindo.
        }
    }
}
