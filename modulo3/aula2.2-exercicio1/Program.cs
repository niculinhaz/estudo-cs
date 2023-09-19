// Exercício 1 - Remover blocos de código

bool flag = true;
if (flag){
    Console.WriteLine(flag);
}

// Bloco if sem chaves
if (flag)
    Console.WriteLine(flag);

// Bloco if em uma linha
if (flag) Console.WriteLine(flag);

// Testando em if-else-if maiores
string name = "Steve";
if (name == "Steve") Console.WriteLine("Found Steve!");
else if (name == "Bob") Console.WriteLine("Found Bob!");
else Console.WriteLine("Found Chuck!");

if (name == "Steve")
    Console.WriteLine("Found Steve!");
else if (name == "Bob")
    Console.WriteLine("Found Bob!");
else
    Console.WriteLine("Found Chuck!");

