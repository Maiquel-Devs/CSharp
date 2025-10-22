using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.G_Arrays_Vetores_Matrizes_Lista
{
    internal class Array
    {
        static void Main (string[] args)
        {

            // Declarando o array com 5 posições
            int[] numeros = new int[5];

            // Atribuindo valores manualmente
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            // Imprimindo os valores
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posição " + i + ": " + numeros[i]);
            }

            Console.WriteLine("-------------");

            // Criando e inicializando direto
            string[] frutas = { "Maçã", "Banana", "Morango" };  // Tamanho definido automaticamente

            // Imprimindo os valores com foreach
            foreach (string comida in frutas)
            {
                Console.WriteLine(comida);
            }

        }
    }
}
