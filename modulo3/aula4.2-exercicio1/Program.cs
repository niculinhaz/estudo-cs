// Exercício 1 - Desafio do FizzBuzz

int i;
for(i=1; i<=100; i++){
    Console.Write(i);
    Console.WriteLine(i % 3 == 0 ? (i % 5 == 0 ? " - FizzBuzz" : " - Fizz") : (i % 5 == 0 ? " - Buzz" : "")); 
}
