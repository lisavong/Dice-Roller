int diceSide,diceTotal;
bool playAgain;

do
{
    DiceRoll();
    Console.WriteLine("Do you want to play again? y/n");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";
   
} while (playAgain==true);


int DiceRoll ()
{
    int diceOne,diceTwo;
    Console.WriteLine("How many sides does your die have?");
    bool isValid = int.TryParse(Console.ReadLine(),out diceSide);

    if (!isValid)
    {
        Console.WriteLine("Sorry, that's an invalid entry");
        Console.WriteLine("Hit any key to exit");
        Console.ReadKey();
        Environment.Exit(0);
    }

    Random random = new Random();

    diceOne= random.Next(1, diceSide+1);
    diceTwo= random.Next(1, diceSide+1);
    diceTotal=diceOne+diceTwo;

    if (diceSide==6)
    {
        SixSideDice(diceOne, diceTwo);
    }

    Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}");
    Console.WriteLine($"for a total of {diceTotal}");

    return diceTotal;
   
}

void SixSideDice(int diceOne, int diceTwo)
{
    if (diceOne==1 && diceTwo==1)
    {
        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}. SNAKE EYES! ");
    }
    else if (diceOne==1 && diceTwo==2)
    {
        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}. ACE DUECE ");
    }
    else if (diceOne==2 && diceTwo==1)
    {
        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}. ACE DUECE ");
    }
    else if (diceOne==6 && diceTwo==6)
    {
        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}. BOX CARS ");
    }
    else if (diceTotal==7 || diceTotal==11)
    {
        Console.WriteLine($"You rolled a {diceOne} and a {diceTwo}. YOU WIN ");
    }
    else if (diceTotal==2 || diceTotal==3 || diceTotal==12)
    {
        Console.WriteLine($"You rolled a {diceTotal}, CRAPS");
    }
}

Console.WriteLine("Thanks for playing! Hit any key to exit");
Console.ReadKey();
