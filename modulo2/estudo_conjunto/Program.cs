// Usando laços for e foreach para analisar dados de uma matriz

int currentAssignments = 5;

string[] names = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

int[] sophiaGrades = new int[] { 90, 86, 87, 98, 100 };
int[] andrewGrades = new int[] { 92, 89, 81, 96, 90 } ;
int[] emmaGrades =  new int[] { 90, 85, 87, 98, 68 } ;
int[] loganGrades =  new int[] { 90, 95, 87, 88, 96 } ;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;


double sophiaScore, andrewScore, emmaScore, loganScore;
 
foreach (int grade in sophiaGrades)
{
    sophiaSum += grade;
}

foreach (int grade in andrewGrades)
{
    andrewSum += grade;
}

foreach (int grade in emmaGrades)
{
    emmaSum += grade;
}

foreach (int grade in loganGrades)
{
    loganSum += grade;
}

sophiaScore = (double) sophiaSum / currentAssignments;
andrewScore = (double) andrewSum / currentAssignments;
emmaScore = (double) emmaSum / currentAssignments;
loganScore = (double) loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");

double[] scores = new double[] { sophiaScore, andrewScore, emmaScore, loganScore };
int count = 0;


foreach (string name in names)
{
    if (scores[count] >= 97){
        Console.WriteLine($"{name}\t\t{scores[count]}\tA+");
        count+=1;
    }
    else if (scores[count] >= 93){
        Console.WriteLine($"{name}\t\t{scores[count]}\tA");
        count+=1;
    }
    else if (scores[count] >= 90){
        Console.WriteLine($"{name}\t\t{scores[count]}\tA-");
        count+=1;
    }
    else if (scores[count] >= 87){
        Console.WriteLine($"{name}\t\t{scores[count]}\tB+");
        count+=1;
    }
    else if (scores[count] >= 83){
        Console.WriteLine($"{name}\t\t{scores[count]}\tB");
        count+=1;
    }
    else if (scores[count] >= 80){
        Console.WriteLine($"{name}\t\t{scores[count]}\tB-");
        count+=1;
    }
    else if (scores[count] >= 77){
        Console.WriteLine($"{name}\t\t{scores[count]}\tC+");
        count+=1;
    }
    else if (scores[count] >= 73){
        Console.WriteLine($"{name}\t\t{scores[count]}\tC");
        count+=1;
    }
    else if (scores[count] >= 70){
        Console.WriteLine($"{name}\t\t{scores[count]}\tC-");
        count+=1;
    }
    else if (scores[count] >= 67){
        Console.WriteLine($"{name}\t\t{scores[count]}\tD+");
        count+=1;
    }
    else if (scores[count] >= 63){
        Console.WriteLine($"{name}\t\t{scores[count]}\tD");
        count+=1;
    }
    else if (scores[count] >= 60){
        Console.WriteLine($"{name}\t\t{scores[count]}\tD-");
        count+=1;
    }
    else{
        Console.WriteLine($"{name}\t\t{scores[count]}\tF");
        count+=1;
    }
}
Console.WriteLine("Pressione enter para continuar.");
Console.ReadLine();