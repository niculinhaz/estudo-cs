// Exercício 2 - Laços de iteração - Desafio de batalha de RPG

Random attack = new Random();

int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;

do{
    Console.WriteLine($"O herói possui {heroHealth} pontos de vida, e o monstro possui {monsterHealth}.");
    damage = attack.Next(1, 11);
    monsterHealth = monsterHealth - damage;
    if ( monsterHealth < 0 ) monsterHealth = 0;
    Console.WriteLine($"O herói ataca com força {damage}! Resta ao monstro {monsterHealth} pontos de vida.");
    if( monsterHealth == 0 ) break;
    damage = attack.Next(1, 11);
    heroHealth = heroHealth - damage;
    if ( heroHealth < 0 ) heroHealth = 0;
    Console.WriteLine($"O monstro ataca com força {damage}! Resta ao herói {heroHealth} pontos de vida.");
    if ( heroHealth == 0 ) break;
} while ( heroHealth > 0 && monsterHealth > 0 );

Console.WriteLine("A batalha acabou!");
