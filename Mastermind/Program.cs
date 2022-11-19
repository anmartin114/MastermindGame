using Mastermind;

Console.WriteLine("Welcome to Matermind!");
Console.WriteLine("You have 10 attempts to guess a sequence of 4 numbers between 1 and 6");
List<int> correctNumbers = GameMethods.GetNumbers();
string correctNumberString = GameMethods.NumberListString(correctNumbers);
int count = 0;
bool win = false;

while (count < 10)
{
    count++;
    Console.WriteLine("\nEnter your guess: ");

    string userInput = Console.ReadLine();

    while (!GameMethods.IsValidNumber(userInput))
    {
        Console.WriteLine("Invalid number \n Enter your guess: ");
        userInput = Console.ReadLine();
    }

    List<int> guessedNumbers = GameMethods.GetNumbersFromUser(userInput);
    List<char> compareToAnswer = GameMethods.CompareGuessToAnswer(guessedNumbers, correctNumbers);

    foreach (char c in compareToAnswer)
    {
        Console.Write(c);
    }

    if (GameMethods.isCorrect(compareToAnswer))
    {
        Console.WriteLine($"\nCorrect! You win! The secret number was: {correctNumberString}");
        win = true;
        break;
    }
}
if (!win)
{
    Console.WriteLine("You couldn't guess the secret number in time :(");
    Console.WriteLine($"The answer was: {correctNumberString}");
}