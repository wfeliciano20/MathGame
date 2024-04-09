using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class MathGame
    {

        public List<string> RecordOfOperations { get; set; } = new List<string>();

        public double SummationOperation(double a, double b)
        {
            RecordOfOperations.Add($"{a} + {b} = {a + b}");
            return a + b;
        }

        public double SubtractionOperation(double a, double b)
        {
            RecordOfOperations.Add($"{a} - {b} = {a - b}");
            return a - b;
        }

        public double MultiplicationOperation(double a, double b)
        {
            RecordOfOperations.Add($"{a} * {b} = {a * b}");
            return a * b;
        }

        public int DivisionOperation(int a, int b)
        {
            while (a < 0 || a > 100)
            {
                Console.WriteLine("Please Enter a valid dividend, valid values are from 0 - 100");
                a = Convert.ToInt32(Console.ReadLine());
            }

            if (a % b != 0)
            {
                // don't show anything since division resulted in a floating point value
                return int.MaxValue;
            }
            else
            {
                RecordOfOperations.Add($"{a} / {b} = {a / b}");
                return a / b;
            }
        }


        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Math Game");
            Console.WriteLine("1) Summation Operation");
            Console.WriteLine("2) Subtraction Operation");
            Console.WriteLine("3) Multiplication Operation");
            Console.WriteLine("4) Division Operation");
            Console.WriteLine("5) Show Past Operations");
            Console.WriteLine("6) Quit");
        }
    }
}
