using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.G_Arrays_Vetores_Matrizes_Lista
{
    internal class X_Matrizes
    {
        static void Main(string[] args)
        {

            // Criando uma matriz 2x3 (2 linhas e 3 colunas)
            int[,] matriz = new int[2, 3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;

            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            for (int i = 0; i < 2; i++)          // percorre as linhas
            {
                for (int j = 0; j < 3; j++)      // percorre as colunas
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(); // quebra de linha a cada linha
            }

            Console.WriteLine("-----");

            // Criando já preenchida
            int[,] Matriz = {
                {10, 20, 30},
                {40, 50, 60}
            };

            // Impressão
            for (int i = 0; i < Matriz.GetLength(0); i++)       // linhas
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)   // colunas
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
