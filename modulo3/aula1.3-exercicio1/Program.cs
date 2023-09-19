// Exercício 1 - Cara ou coroa

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine(flip == 0 ? "Cara" : "Coroa");