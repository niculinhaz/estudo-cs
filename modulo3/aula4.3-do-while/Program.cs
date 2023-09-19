// Aula 2 - Laço Do-While
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue; // Se current for maior ou igual a 8, pula direto para a verificação de condição.
    Console.WriteLine(current);
} while (current != 7); // Executa o código a menos que current seja igual a 7, se for, interrompe o laço.

// Laço While

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");