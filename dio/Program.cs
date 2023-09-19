using dio.Models; // Importa o namespace que contém a classe Pessoa

// Pessoa pessoa1 = new Pessoa(); // Cria um objeto da classe Pessoa

// pessoa1.nome = "Nicholas";
// pessoa1.idade = 18; // Atribuindo valores ao objeto pessoa1
// pessoa1.apresentar(); // Chamando o método apresentar() com os valores do objeto pessoa1


Calculator calculadora = new Calculator();

Console.WriteLine("Bem vindo ao sistema de calculadora!");
Console.WriteLine("Pressione Enter para continuar.");
Console.ReadLine();
Console.Clear();
int operation = 0;
bool loop = true;
while (loop == true)
{
    Console.WriteLine("Insira a operação que deseja realizar:");
    Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Potência\n6 - Seno\n7 - Cosseno\n8 - Tangente\n9 - Raiz Quadrada");
    string input = Console.ReadLine();
    if (int.TryParse(input, out operation) == false)
    {
        Console.WriteLine("Operação inválida. Por favor, insira novamente."); continue;
    }

    int.TryParse(input, out operation);
    if (operation > 9 || operation < 0)
    {
        Console.WriteLine("Operação inválida. Por favor, insira novamente."); continue;
    }

    loop = false;
}

decimal num1, num2;
double angle;

switch (operation)
{
    case 1:
        Console.WriteLine("Insira o primeiro valor:");
        decimal.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Insira o segundo valor:");
        decimal.TryParse(Console.ReadLine(), out num2);
        calculadora.Sum(num1, num2); break;
    case 2:
        Console.WriteLine("Insira o primeiro valor:");
        decimal.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Insira o segundo valor:");
        decimal.TryParse(Console.ReadLine(), out num2);
        calculadora.Sub(num1, num2); break;
    case 3:
        Console.WriteLine("Insira o primeiro valor:");
        decimal.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Insira o segundo valor:");
        decimal.TryParse(Console.ReadLine(), out num2);
        calculadora.Multiply(num1, num2); break;
    case 4:
        Console.WriteLine("Insira o primeiro valor:");
        decimal.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Insira o segundo valor:");
        decimal.TryParse(Console.ReadLine(), out num2);
        calculadora.Division(num1, num2); break;
    case 5:
        Console.WriteLine("Insira o valor base:");
        decimal.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Insira o valor da potência:");
        decimal.TryParse(Console.ReadLine(), out num2);
        calculadora.Power(num1, num2); break;
    case 6:
        Console.WriteLine("Insira um ângulo, em graus:");
        double.TryParse(Console.ReadLine(), out angle);
        calculadora.Sin(angle); break;
    case 7:
        Console.WriteLine("Insira um ângulo, em graus:");
        double.TryParse(Console.ReadLine(), out angle);
        calculadora.Cos(angle); break;
    case 8:
        Console.WriteLine("Insira um ângulo, em graus:");
        double.TryParse(Console.ReadLine(), out angle);
        calculadora.Tan(angle); break;
    case 9:
        Console.WriteLine("Insira um número:");
        decimal.TryParse(Console.ReadLine(), out num1);
        calculadora.SquareRoot(num1); break;
}



