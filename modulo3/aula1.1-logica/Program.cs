using System;

// Testando condições
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine("a" == "a ");
// Usar o método .Trim() para remover espaços em branco à esquerda e à direita

// Testando desigualdades
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");

/* Testando métodos que retornam true ou false */
string Pangram = "The quick brown fox jumps over the the lazy dog.";
Console.WriteLine(Pangram.Contains("fox"));
Console.WriteLine(Pangram.Contains("cow"));
Console.WriteLine(!Pangram.Contains("fox")); // Se a string Pangram NÃO contém "fox"


