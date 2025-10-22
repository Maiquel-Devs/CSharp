using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Nivel_Iniciante.E_Estruturas_de_Condicao
{
    internal class @switch
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7: ");
            int dia = int.Parse(Console.ReadLine());    // Parse converte String para Int "Pois o ReadLine() retorna uma String"

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia inválido");
                    break;
            }

        }
    }
}
