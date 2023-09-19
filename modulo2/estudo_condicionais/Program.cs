Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int sum = roll1 + roll2 + roll3;

Console.WriteLine($"Soma dos dados: {roll1} + {roll2} + {roll3} = {sum}");

// if(sum > 14){
//     Console.WriteLine("Você ganhou!");
// } // Verifica se a soma dos lados é maior que 14, se for, declara vitória!
// else{
//     Console.WriteLine("Você perdeu!");
// } // Caso a soma seja menor ou igual a 14, executa esse bloco de código que determina a derrota.

// if((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)){
//     Console.WriteLine("Dois lados iguais! +2 na soma total!");
//     sum += 2;
// }

// if((roll1 == roll2) && (roll2 == roll3)){
//     Console.WriteLine("Você tirou três lados iguais! Bônus de +6 ao total!");
//     sum += 6;
// }

// Consertando a repetição do bônus com aninhamento
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Você tirou três lados iguais! Bônus de +6 ao total!");
        sum += 6;
    }
    Console.WriteLine("Dois lados iguais! +2 na soma total!");
    sum += 2;
}

// Usando if, else if e else
if (sum >= 16)
{
    Console.WriteLine("Você ganhou um carro!");
}
else if (sum >= 10)
{
    Console.WriteLine("Você ganhou um notebook!");
}
else if (sum == 7)
{
    Console.WriteLine("Você ganhou um cruzeiro para dois!");
}
else
{
    Console.WriteLine("Você não ganhou nada. Sinto muito!");
}
