using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.C_Encapsulamento
{
    internal class Index
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(10, 5);

            // Usando o Setter para definir valores

            retangulo.Largura = 15;     // Invoca o set da propriedade Largura " Maiúscula "
            retangulo.Altura = 20;

            // Usando o Getter para obter valores

            Console.WriteLine($"Largura: {retangulo.Largura}");     // Invoca o get da propriedade Largura " Maiúscula "
            Console.WriteLine($"Altura:  {retangulo.Altura}");

            // Verificando se é um quadrado

            retangulo.IsQuadrado();     // false

        }
    }
}
