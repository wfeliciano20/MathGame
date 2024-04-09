using Game;

var mathGame = new MathGame();

var gameOver = false;
int selection;
int result;
int firstNumber = -1;
int secondNumber = -1;

while (!gameOver)
{
    mathGame.DisplayMenu();

    firstNumber = -1;
    secondNumber = -1;
    
    try
    {
        selection = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
    }
    catch (Exception)
    {
        Console.WriteLine("Please Enter a Valid Value: 1 - 6");
        selection = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
    }


    // Ask for numbers to do operations with
    if (selection < 5)
    {

        Console.WriteLine("Please enter the first integer number");
        while (firstNumber < 0)
        {
            try
            {
                firstNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Please Enter a Valid Integer Number:");
            }
        }

        Console.WriteLine("Please enter the second integer number");

        while (secondNumber < 0)
        {
            try
            {       
                secondNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter a Valid Integer Number:");
            }
        }
    }

    switch (selection)
    {
        case 1:
            result =  mathGame.SummationOperation(firstNumber,secondNumber);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}\n\n");
            Console.WriteLine("\n");
            break;
        case 2:
            result = mathGame.SubtractionOperation(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}\n\n");
            Console.WriteLine("\n");
            break;
        case 3:
            result = mathGame.MultiplicationOperation(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}\n\n");
            Console.WriteLine("\n");
            break;
        case 4:
            result = mathGame.DivisionOperation(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}\n\n");
            Console.WriteLine("\n");
            break;
        case 5:
            Console.WriteLine("Previous Operations:");
            mathGame.RecordOfOperations.ForEach(Console.WriteLine);
            Console.WriteLine("\n");
            break;
        case 6:
            gameOver = true;
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("Please enter a valid option: 1 - 6");
            Console.WriteLine("\n");
            break;
    }

    
}

Console.WriteLine("Thanks for playing this numbers game");