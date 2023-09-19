// Aula - C# - Primeira Aula

// Console.WriteLine("Hello World!");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first line of code.");

// Segunda Aula - Tipos de dados

// Exibindo char
Console.WriteLine('b');

// Exibindo string
Console.WriteLine("Oiiiiii...");

// Exibindo int
Console.WriteLine(125);

// Exibindo floats
Console.WriteLine(0.25F); // float
Console.Write(2.625); // double
Console.Write(12.8725m); // decimal

// Exibindo bool
Console.WriteLine(true);
Console.WriteLine(false);

// Declarando variáveis usando o CamelCase
string firstName;
int gameScore;
double particlesPerMillion;

// Inicializando e acessando o valor de uma variável
firstName = "Bob";
Console.WriteLine(firstName);
// Mudando o valor da variável
firstName = "Liam";
Console.WriteLine(firstName);

// Declarando uma variável de tipo implícito
var message = "Hello World";
// var message; -> Retorna erro, variável implícita deve ser inicializada em sua declaração

// Aula 3 - Formatando strings

// Para adicionar quebras de linha, tabulações, etc.
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

// Para adicionar aspas
Console.WriteLine("Hello\"World\"!");

// Para adicionar barras invertidas
Console.WriteLine("Hello\\World!");

// Exemplo de uso de formatação
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Imprimindo sem caracteres de escape
Console.WriteLine(@"     c:\source\apps
            (this is where your code goes.)");

// Caracteres Unicode (UTF-16)
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

// Concatenando strings
string firstName = "Bob";
string message = "Hello, " + firstName;
Console.WriteLine(message);

message = "Hello";
string greeting = message + " " + firstName + "!";
Console.WriteLine(greeting);

// Sem usar uma variável intermediária
Console.WriteLine(message + " " + firstName + "!");

// Interpolação de strings
greeting = $"{message} {firstName}!";

var version = 11;
var updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}");

// Combinando com literais textuais
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// Exemplo
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
  c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}
  c:\Exercise\{projectName}\data.txt");

// Aula 4 - Realizando operações com valores numéricos
int firstNum = 12;
int secondNum = 7;
Console.WriteLine(firstNum + secondNum);

// Conversão implícita
string text = "Bob sold " + secondNum + " houses this month.";
Console.WriteLine(text);

// Operações dentro de uma conversão implícita
text = "Bob sold " + firstNum + secondNum + " houses this month.";
Console.WriteLine(text); // Será realizada uma concatenação.
text = "Bob sold " + (firstNum + secondNum) + " houses this month.";
Console.WriteLine(text); // Entre parentêses, a operação numérica será realizada

// Realizando operações matemáticas simples
int soma = 7 + 5;
int difference = 7 - 5;
int produto = 7 * 5;
int divisao = 7 / 5;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Diferença: " + difference);
Console.WriteLine("Produto: " + produto);
Console.WriteLine("Quociente: " + divisao); // Ao declarar uma variável como int e associar um valor decimal a ela, ela apenas retornará o que existe antes da vírgula

double divisaoDecimal = 7.0 / 5.0; // ou decimal divisaoDecimal = 7.0m / 5;
Console.WriteLine($"Quociente decimal: {divisaoDecimal}");

// Conversão de inteiro para float
int first = 7;
int second = 5;
decimal quociente = (decimal)first / (decimal)second;
Console.WriteLine(quociente);

// Obtendo o resto de uma divisão
Console.WriteLine($"Resto de 7 / 5: {7 % 5}");


// A ordem de operações segue o princípio matemático 
// 1 - Parênteses
// 2 - Exponenciação / Radiação -> Módulo System.Math
// Da esquerda para a direita:
// 3 - Multiplicação / Divisão
// 4 - Soma / Subtração

// Incrementos e decrementos
int valor = 0;
valor = valor +  5;
valor += 5; // Essa linha e a linha de cima são equivalentes.

valor++; // Incrementa o valor em 1.

valor = valor - 5;
valor -= 5; // Essa linha e a linha de cima são equivalentes.

valor --; // Decrementa o valor em 1.

// Incrementos/Decrementos antes e depois de recuperar o valor de uma variável
int value = 1;
value++;
Console.WriteLine("Primeiro: " + value);
Console.WriteLine("Segundo: " + value++);
Console.WriteLine("Terceiro: " + value);
Console.WriteLine("Quarto: " + (++value));

// Ao realizar o incremento antes do valor (++value), o valor é incrementado antes de ser resgatado e imprimido.
// Ao realizar o incremento depois do valor (value++), o valor é imprimido e só então é incrementado. Em sua próxima chamada será resgatado o valor incrementado.

// Exemplo - Conversão de temperatura
int fahrenheit = 94;

double celsius = ((double)fahrenheit - 32) * 5 / 9;

Console.WriteLine($"The temperature is {celsius} Celsius.");