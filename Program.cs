using Game;

var mathGame = new MathGame();

var gameOver = false;
int selection;
double result;
double firstNumber = -1;
double secondNumber = -1;

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

        Console.WriteLine("Please enter the first number");
        while (firstNumber < 0)
        {
            try
            {
                firstNumber = Double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Please Enter a Valid Number:");
            }
        }

        Console.WriteLine("Please enter the second number");

        while (secondNumber < 0)
        {
            try
            {       
                secondNumber = Double.Parse(Console.ReadLine());
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
            result = mathGame.DivisionOperation((int)firstNumber, (int)secondNumber);
            if(result != int.MaxValue)
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = {(int) result}\n\n");
            }
            else
            {
                Console.WriteLine("The result was not an integer.");
            }
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