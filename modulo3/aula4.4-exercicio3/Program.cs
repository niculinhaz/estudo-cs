// Exercício 3 - Diferenciação de qual a melhor situação para usar while e do-while

// string? input;
// int number = 0;
// bool valid = false;

// do{
//     Console.WriteLine("Insira um valor de 5 a 10: ");
//     input = Console.ReadLine();
//     valid = int.TryParse(input, out number);
//     if ( valid is false ){
//         Console.WriteLine("Por favor, insira um valor numérico."); continue;
//     }
//     if( number < 5 || number > 10 ){
//         Console.WriteLine("Por favor, insira um número válido."); 
//         valid = false; continue;
//     }
// }while( valid is false );
// Console.WriteLine("Número válido inserido!");


// Exercício 4

// string? input;
// bool validInput = false;

// Console.WriteLine("Qual o seu cargo?");
// while(validInput is false){
//     input = Console.ReadLine();
//     if (input == null){
//         Console.WriteLine("Por favor, insira um cargo.");
//     }
//     input = input.Trim();
//     input = input.ToLower();
//     switch(input){
//         case "administrador":
//         case "gerente":
//         case "usuário":
//             validInput = true; break;
//         default:
//             Console.WriteLine("Insira um cargo válido."); break; 
//     } continue;
// }
// Console.WriteLine($"Cargo inserido {input} aceito.");


// Exercício 5

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     while (periodLocation != -1)
//     {

//         mySentence = myString.Remove(periodLocation);

//         myString = myString.Substring(periodLocation + 1);

//         myString = myString.TrimStart();

//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }
 
//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }