// Aula 2 - Criando métodos com parâmetro

int[] schedule = {800, 1200, 1600, 2000};

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
    Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
    {
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    } 
    else 
    {
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
}

DisplayAdjustedTimes(schedule, 6, -6);

// Entendendo o escopo de um método
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

PrintCircleArea(12);
double circumference = 2 * pi * radius;

void PrintCircleCircumference(int radius)
{
    double pi = 3.14159;
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleArea(int radius)
{
    double pi = 3.14159;
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}


// Testando passagem por valor
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}


// Testando passagem por referência
int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) 
{
    foreach (int a in array) 
    {
        Console.Write($"{a} ");
    }
}

void Clear(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = 0;
    }
}

// Teste com strings
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}


// Métodos com parâmetros opcionais

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
{
    if (inviteOnly)
{
    bool found = false;
    foreach (string guest in guestList)
    {
        if (guest.Equals(name)) {
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine($"Sorry, {name} is not on the guest list");
        return;
    }
}

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}


// Usando argumentos por nome
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);



// Exercício
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
}

DisplayInternalEmails();
DisplayExternalEmails();

void DisplayExternalEmails()
{
    for(int i=0; i < external.GetLength(0); i++)
    {
        Console.WriteLine($"{external[i, 0]}@{externalDomain}\n{external[i,1]@{externalDomain}}");
    }
}

void DisplayInternalEmails(string[,] users)
{
    for(int i=0; i < corporate.GetLength(0); i++)
    {
        Console.WriteLine($"{corporate[i, 0]}@{externalDomain}\n{corporate[i,1]@{externalDomain}}");
    }
}