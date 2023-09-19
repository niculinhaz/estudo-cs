// Aula 5 - Métodos para extração e uso de dados de array

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('('); // Retorna a posição do primeiro '('
int closingPosition = message.IndexOf(')'); // Retorna a posição do primeiro ')'

openingPosition +=1; // Aumenta em 1, para que o '(' seja removido

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); // Substring() retorna a string que se encontra entre as posições especificadas


// Usando o método IndexOf() com strings

message = "What is the value <span>between the tags</span>?";

openingPosition = message.IndexOf("<span>"); // Encontra a posição do primeiro "<span>"
closingPosition = message.IndexOf("</span>"); // Encontra a posição do primeiro "</span>"

openingPosition += 6; // Aumenta a posição inicial para remover "<span>"
length = closingPosition - openingPosition; 
Console.WriteLine(message.Substring(openingPosition, length));


// Usando o método IndexOf() com constantes
message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

openingPosition = message.IndexOf(openSpan);
closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


// Método IndexOfAny() e LastIndexOf()

message = "(What if) I am (only interested) in the last (set of parentheses)?";
openingPosition = message.LastIndexOf('('); // Retorna a posição da última ocorrência de '('

openingPosition += 1; // Remove o '('
closingPosition = message.LastIndexOf(')'); // Retorna a posição da última ocorrência de ')'
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Caso existam repetições do caractere que deseja ser encontrado
message = "(What if) there are (more than) one (set of parentheses)?";
while (true) // Cria um laço que retornará todas Substrings entre '(' e ')' até que não encontre mais '('
{
    openingPosition = message.IndexOf('('); // IndexOf() retorna -1 se não encontrar o caractere ou string especificada
    if (openingPosition == -1) break;

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}


// Caso você queira encontrar mais de um caractere diferente, e retornar o que há dentro de cada um
message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

closingPosition = 0;

while (true)
{
    openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}


// Método Remove()

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20); // Remove o que há entre a posição 5 a 20, no caso, 5-19
Console.WriteLine(updatedData);

// Método Replace()
 message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " "); 
message = message.Replace("-", "");
// Substitui cada ocorrência do primeiro argumento pelo segundo argumento

Console.WriteLine(message);




// Exercício

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
// Extract the quantity
int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div>");
int divLength = "<div>".Length;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div>");
int divCloseLength = "</div>".Length;
output = output.Remove(divCloseStart, divCloseLength);
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);


Console.WriteLine(quantity);
Console.WriteLine(output);