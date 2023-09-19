// Aula 4 - Matrizes

// Declarando uma matriz de strings
string[] fraudulentOrderIDs = new string[3];

// Atribuindo valores aos espaços da matriz
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Terceiro: {fraudulentOrderIDs[2]}");

// Reatribuindo valor
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reatribuído: {fraudulentOrderIDs[0]}");

// Inicializando uma matriz com valores atribuídos
int[] numeros = { 123, 456, 789, 001 };

// Length
Console.WriteLine($"Há {fraudulentOrderIDs.Length} pedidos fraudulentos para processar.");


// Iterando sobre uma matriz
string[] nomes = { "Nicholas", "Daniel", "Márcio" };
foreach (string nome in nomes){
    Console.WriteLine(nome);
}
