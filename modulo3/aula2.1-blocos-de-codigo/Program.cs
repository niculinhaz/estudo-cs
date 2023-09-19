// Escopo de variáeis
// bool flag = true;

// if (flag) {
//     int value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}"); // A variável value não existe aqui

// bool flag = true;
// int value;

// if (flag) {
//     int value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}"); // Agora a variável não foi inicializada fora do bloco de código

bool flag = true;
int value = 0;

if (flag) {
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}"); // Agora a variável existe e foi inicializada fora do bloco condicional de código.

