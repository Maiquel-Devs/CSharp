
List<string> nomes = new List<string>();

nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Ana");


Console.WriteLine("Lista de nomes:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}



List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine("Lista de números:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}



// Ela guarda vários valores do mesmo tipo e pode crescer ou diminuir conforme necessário.


// Diferente de um array (int[]), que tem tamanho fixo, uma List pode adicionar ou remover elementos livremente.