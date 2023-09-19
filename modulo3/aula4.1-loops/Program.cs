// Aula 1 - Laço for

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Testando outras formas de usar o laço
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}


// Usando a keyword break para encerrar o laço
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


// Iterando sobre os elementos de uma matriz
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// Diferenças entre foreach e for
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     Can't do this:
//     if (name == "David") name = "Sammy";
// }
//
// Dessa forma, funcionaria:
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

