// Exercício guiado
// Declarando a nota de cada aluno
int currentAssignments = 5;

var sophia1 = 93;
var sophia2 = 87;
var sophia3 = 98;
var sophia4 = 95;
var sophia5 = 100;
var sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;

var nicolas1 = 80;
var nicolas2 = 83;
var nicolas3 = 82;
var nicolas4 = 88;
var nicolas5 = 85;
var nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;

var zahirah1 = 84;
var zahirah2 = 96;
var zahirah3 = 73;
var zahirah4 = 85;
var zahirah5 = 79;
var zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;

var jeong1 = 90;
var jeong2 = 92;
var jeong3 = 98;
var jeong4 = 100;
var jeong5 = 97;
var jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

var sophiaFinal = (double)sophiaSum / currentAssignments;
var nicolasFinal = (double)nicolasSum / currentAssignments;
var zahirahFinal = (double)zahirahSum / currentAssignments;
var jeongFinal = (double)jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia:\t\t{sophiaFinal}" + "\tA");
Console.WriteLine($"Nicolas:\t{nicolasFinal}" + "\tB");
Console.WriteLine($"Zahirah:\t{zahirahFinal}" + "\tB");
Console.WriteLine($"Jeong:\t\t{jeongFinal}" + "\tA");
