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

    
    try
    {
        selection = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Please Enter a Valid Value: 1 - 6");
        selection = Convert.ToInt32(Console.ReadLine());
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
            break;
        case 2:
            result = mathGame.SubstractionOperation(firstNumber,secondNumber);
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}\n\n");
            break;
        case 3:
            result = mathGame.MultiplicationOperation(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}\n\n");
            break;
        case 4:
            result = mathGame.DivisionOperation(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}\n\n");
            break;
        case 5:
            Console.WriteLine("Previous Operations:");
            mathGame.RecordOfOperations.ForEach(Console.WriteLine);
            break;
        case 6:
            gameOver = true;
            break;
        default:
            Console.WriteLine("Please enter a valid option: 1 - 6");
            break;
    }

    
}

Console.WriteLine("Thanks for playing this numbers game");