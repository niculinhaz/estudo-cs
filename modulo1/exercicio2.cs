// Exercício guiado 2

int gradeA = 4;
int gradeB = 3;

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;
int totalCredit = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int generalGrade1 = course1Credit * course1Grade;
int generalGrade2 = course2Credit * course2Grade;
int generalGrade3 = course3Credit * course3Grade;
int generalGrade4 = course4Credit * course4Grade;
int generalGrade5 = course5Credit * course5Grade;

int gradeSum = generalGrade1 + generalGrade2 + generalGrade3 + generalGrade4 + generalGrade5;

double gradePointAverage = (double)gradeSum / totalCredit;
int leadingDigit = (int) gradePointAverage; // Recebe a parte inteira do GPA
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100); // Recebe os números decimais do GPA
// multiplica o GPA total por 100 (3.35294117647059) e subtrai da parte inteira multiplicada por 100, ficando apenas com a parte inteira
// Nesse caso: 335 - 300 = 35

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"GPA: {leadingDigit}.{trailingDigits}");