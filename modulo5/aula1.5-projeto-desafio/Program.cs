using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;
bool wasEaten = false;
int speed = 1;


// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit)
{
    Move();
}

// Returns true if the Terminal was resized 
bool TerminalResized(int a, int b)
{
    int terminalHeight = Console.WindowHeight;
    int terminalWidth = Console.WindowWidth;
    if (a != terminalHeight || b != terminalWidth) shouldExit = true;
    else shouldExit = false;
    return shouldExit;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int moveSpeed = 1)
{
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            playerY-=moveSpeed;
            break;
        case ConsoleKey.DownArrow:
            playerY+=moveSpeed;
            break;
        case ConsoleKey.LeftArrow:
            playerX-=moveSpeed;
            break;
        case ConsoleKey.RightArrow:
            playerX+=moveSpeed;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            break;
        default:
            shouldExit = true;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

bool EatFood(bool eat)
{
    while(true)
    {
        if (playerX == foodX && playerY == foodY)
        {
            player = states[1];
            eat = true;
            return eat;
        }
        Move();
    }
    return eat;
}

void isPoisoned(string player)
{
    if (player == states[2]){
            FreezePlayer();
        }
}

int isHappy(string player)
{
    if(player == states[1])
        {
            speed = 3;
            return speed;
            if (player != states[1]) {
                speed = 1; 
                return speed;
            }
        }
    return speed;
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    int initialTerminalHeight = Console.WindowHeight;
    int initialTerminalWidth = Console.WindowWidth;
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
    while(!shouldExit){
        if (TerminalResized(initialTerminalHeight, initialTerminalWidth))
        {
            Console.Clear();
            Console.WriteLine("Console was resized. Program exiting."); continue;
        }
        ShowFood();
        Move(speed);
        EatFood(wasEaten);
        ChangePlayer();
        isPoisoned(player);
        speed = isHappy(player);
    }
}