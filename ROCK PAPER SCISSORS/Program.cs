//rock paper scissors

string player;
string computer;
string response;
bool playAgain = true;
Random random = new Random();

while (playAgain)
{
    player = "";
    computer = "";
    response = "";

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.WriteLine("Enter rock, paper or scissors");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
        break;
        case 2:
            computer = "PAPER";
        break;
        case 3:
            computer = "SCISSORS";
        break;
    }
    Console.WriteLine("Player : " + player);
    Console.WriteLine("Computer : " + computer);
    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("DRAW");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("Loser!");
            }
            else
            {
                Console.WriteLine("WINNER");
            }
        break;
        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine("WINNER");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("loser");
            }
        break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("LOSER");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("WINNER WINNER CHICKEN DINNER");
            }
            else
            {
                Console.WriteLine("A TIE!");
            }
        break;
    }
    Console.WriteLine("Would you like to play again? (Y/N) : ");
    response = Console.ReadLine();
    response = response.ToUpper();
    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
Console.WriteLine("Thanks for playing! :)");

Console.ReadKey();