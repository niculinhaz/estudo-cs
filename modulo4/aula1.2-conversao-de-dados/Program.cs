// Aula 2 - Conversões de dados
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result); // Gera uma exceção por conversão implícita

// string result = first + second;
// Console.WriteLine(result); // Converte o inteiro para string implicitamente

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}"); // Qualquer inteiro pode ser convertido para ponto flutuante
// // de forma direta

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}"); // Números de ponto flutuante podem ser convertidos para inteiro, mas
// explicitamente

// Conversão de expansão - tipo de dados menor para maior (int para decimal, por exemplo)
// Conversão de restrição - tipo de dados maior para menor (decimal para int, por exemplo)

// Para converter um número em string, usar o método ToString()
// Para converter string em inteiro, usar Parse() ou Convert.ToInt32()
// Ao usar Convert.Int32 em decimais, o número será arredondado para cima
// (int)variavelDecimal é coerção, variavelDecimal.Convert.ToInt32() é arredondamento


// O método TryParse() converte strings em números e retorna true se houver sucesso, se não, retorna false
// Está disponível para todos tipos numéricos
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if(result>50)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}"); // Retorna erro


/* Exercício */
// // código base:
// string[] values = { "12,3", "45", "ABC", "11", "DEF" };
// // resultado desejado:
// /*
// Message: ABCDEF
// Total: 68.3
// */
// decimal sum = 0m;
// string phrase = "";

// foreach (var value in values)
// {
//     decimal number;
//     if (decimal.TryParse(value, out number) )
//     {
//         sum += number;  
//     }
//     else phrase += value;
// }

// Console.WriteLine($"Message: {phrase}");
// Console.WriteLine($"Total: {sum}");

/* Exercício 2 */
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = value1 / Convert.ToInt32(value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
//
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
//
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");