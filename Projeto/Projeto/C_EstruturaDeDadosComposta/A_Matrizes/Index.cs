using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.C_EstruturaDeDadosComposta.A_Matrizes
{
    internal class Index
    {
        static void Main(string[] args)
        {
            // MATRIZES EM C#


            // Matrizes são estruturas de dados que armazenam múltiplos valores em uma única variável.

            // Cada valor é acessado por meio de índices que representam sua posição na matriz.

            // Matrizes podem ter múltiplas dimensões (ex: 2D, 3D, etc).
            


            // Criando uma matriz 2x3 (2 linhas e 3 colunas).

            int[,] matriz = new int[2, 3];

            // Atribuindo valores manualmente

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;

            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;


            // Exibindo os valores da matriz

            for (int i = 0; i < 2; i++)          // percorre as linhas
            {
                for (int j = 0; j < 3; j++)      // percorre as colunas
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();    // quebra de linha após cada linha da matriz
            }

            Console.WriteLine("-----");


            // Criando e inicializando uma matriz diretamente

            int[,] Matriz = {
                {10, 20, 30},
                {40, 50, 60}
            };


            // Exibindo os valores da matriz

            for (int i = 0; i < Matriz.GetLength(0); i++)       // linhas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)   // colunas
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();    // quebra de linha após cada linha da matriz
            }
        }
    }
}
