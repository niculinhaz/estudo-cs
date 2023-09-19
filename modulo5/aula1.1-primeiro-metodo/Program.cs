// Aula 1 - Criando Métodos

using System;

// Declarando um método
void SayHello() 
{
    Console.WriteLine("Hello World!");
}

// Chamando um método
SayHello();


// Outro exemplo
int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

// Criando um método
Console.WriteLine("Generating random numbers...");
DisplayRandomNumber();

void DisplayRandomNumber()
{
    Random number = new Random();
    for(int i = 0; i< 5; i++)
    {
        Console.WriteLine($"{(number.Next(1, 100))}");
    }
}

// Criando métodos reutilizáveis
// Para isso, primeiro realize se há repetição no código
// Então, organize essa repetição em um método

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }
DisplayTimes();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    // for (int i = 0; i < times.Length; i++) 
    // {
    //     times[i] = ((times[i] + diff)) % 2400;
    // }
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    // for (int i = 0; i < times.Length; i++) 
    // {
    //     times[i] = ((times[i] + diff)) % 2400;
    // }
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

/* Format and display medicine times */
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }
DisplayTimes();
Console.WriteLine();


void DisplayTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}

void AdjustTimes()
{
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}