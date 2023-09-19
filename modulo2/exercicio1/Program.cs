// Exercício 1 - Módulo 2

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// ======================= //
if(daysUntilExpiration <= 10){
    if(daysUntilExpiration == 0){
        Console.WriteLine("Your subscription has expired.");
    }
    else if(daysUntilExpiration == 1){
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires in a day!\nRenew now and save {discountPercentage}%!");
    }
    else if(daysUntilExpiration <= 5){
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days!\nRenew now and save {discountPercentage}%!");
    }
    Console.WriteLine("Your subscription expires soon. Renew now!");
}
