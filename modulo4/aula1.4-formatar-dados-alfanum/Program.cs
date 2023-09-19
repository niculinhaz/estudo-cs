// Aula 4 - Formatando dados alfanuméricos

// Formatação composta -> usa espaços reservados numerados dentro de uma string
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// Console.WriteLine("{0} {0} {0}", first, second);

// Interpolação de strings
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");


// Formatando em formato de moeda
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Baseado na linguagem do sistema operacional do usuário


// Formatando para tornar números mais legíveis
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// :N -> Exibe dois dígitos após a vírgula, mas pode ser mudado para exibir mais ou menos, como :N4

// Formatando para percentual
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// Use o método PadLeft(int) para espaçar um texto no terminal com a quantidade de espaços à esquerda passada como argumento menos o tamanho da string
// O mesmo com PadRight(int)

// Para inserir um caractere no lugar dos espaços, use PadLeft(int, 'char') ou PadRight(int, 'char')
// Mais fácil de usar do que \t dentro de strings


// Exercício:
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
Console.WriteLine("Dear {0},", customerName);
Console.WriteLine("As a costumer of our {0} offering we are all excited to tell you about a new financial product that would dramatically increase your return.", currentProduct);
Console.WriteLine(comparisonMessage);
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}");
Console.WriteLine(comparisonMessage);   
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");
Console.WriteLine(comparisonMessage);
Console.WriteLine("Here's a quick comparison:");
Console.WriteLine(comparisonMessage);
Console.WriteLine($"{currentProduct.PadRight(20)}{currentReturn:P2}  {currentProfit:C}");
Console.WriteLine($"{newProduct.PadRight(20)}{newReturn:P2}  {newProfit:C}");