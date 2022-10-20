

int easy = 10;
int medium = 50;
int hard = 100;
int winningNumber = 0;
int userNum;
int numTries = 0;
string? answer;
string? userGuess = "";
bool validNum = false;
bool guessAgain = true;

Console.Clear();

string? playAgain = "yes";
while (playAgain == "yes")
{

    Console.WriteLine("We are going to play a guessing game");
    Console.WriteLine("Enter easy (1-10), medium (1-50), or hard (1-100)");
    answer = Console.ReadLine();
    answer = answer.ToLower();

    while (answer != "easy" && answer != "medium" && answer != "hard")
    {
        Console.WriteLine("Invalid response. Please enter easy (1-10), medium (1-50), or hard (1-100) ");
        answer = Console.ReadLine();
    }

    Console.WriteLine($"You chose {answer}. Please enter a number:");

    Random num = new Random();

    if (answer == "easy")
    {
        winningNumber = num.Next(0, easy);
    }
    else if (answer == "medium")
    {
        winningNumber = num.Next(0, medium);
    }
    else if (answer == "hard")
    {
        winningNumber = num.Next(0, hard);
    }

    while (guessAgain)
    {

        userGuess = Console.ReadLine();
        validNum = int.TryParse(userGuess, out userNum);

        if (validNum)
        {



            if (winningNumber < userNum)
            {
                numTries++;
                Console.WriteLine($"The winning number is lower than {userNum}");
            }
            else if (winningNumber > userNum)
            {
                numTries++;
                Console.WriteLine($"The winning number is greater than  {userNum}");
            }
            else
            {
                numTries++;
                Console.WriteLine($"Good Job! You guessed the number correct in {numTries} tries.");
                guessAgain = false;
            }

        }
        else
        {
            Console.WriteLine("Invalid reponse. Please enter a number: ");
        }

    }

    string? input = "";
    while (input != "yes" && input != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        input = Console.ReadLine();
        input = input.ToLower();
        if (input == "yes")
        {
            playAgain = input;
        }
        else if (input == "no")
        {
            playAgain = input;
        }
        else
        {
            Console.WriteLine("Invalid Answer");
        }

    }


}

