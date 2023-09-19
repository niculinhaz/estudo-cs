// Exercício 2 - Regras de negócio

string permission = "Admin";
int level = 60;

Console.WriteLine(permission.Contains("Admin") ? (level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.") : permission.Contains("Manager") ? (level > 20 ? "Contact an Admin for acess." : "You do not have enough privileges.") : "You do not have enough privileges.");
