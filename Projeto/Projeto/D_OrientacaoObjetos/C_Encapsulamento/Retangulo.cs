using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.D_OrientacaoObjetos.C_Encapsulamento
{
    internal class Retangulo
    {
        // Atributos Privados

        private double largura;
        private double altura;


        // Construtor

        public Retangulo(double largura, double altura)
        {
            Largura = largura;  // Usa o set (com verificação)      Lembre-se: Largura maiúsculo representa a função de propriedade (Getter e Setter)
            Altura = altura;
        }

        // Propriedade Largura com validação

        public double Largura       // Largura maiúsculo representa a função de propriedade (Getter e Setter)
        {
            get { return largura; }

            set
            {
                if (value > 0)
                {
                    largura = value;
                }
                else
                {
                    Console.WriteLine("Largura inválida");
                }
            }
        }


        // Propriedade Altura com validação

        public double Altura
        {
            get { return altura; }

            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    Console.WriteLine("Altura inválida");
                }
            }
        }


        // Método booleano (is)

        public bool IsQuadrado()
        {
            return largura == altura;
        }

    }
}
