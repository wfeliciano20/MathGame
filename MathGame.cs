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

        public int SummationOperation(int a, int b)
        {
            RecordOfOperations.Add($"{a} + {b} = {a + b}");
            return a + b;
        }

        public int SubstractionOperation(int a, int b)
        {
            RecordOfOperations.Add($"{a} - {b} = {a - b}");
            return a - b;
        }

        public int MultiplicationOperation(int a, int b)
        {
            RecordOfOperations.Add($"{a} * {b} = {a * b}");
            return a * b;
        }

        public int DivisionOperation(int a, int b)
        {


            var invalid = true;
            while (invalid)
            {
                if (a < 0 || a > 100)
                {
                    Console.WriteLine("Please Enter a valid dividend, valid values are from 0 - 100");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                else 
                {
                    invalid = false;
                }
            }

            RecordOfOperations.Add($"{a} / {b} = {a / b}");

            return a / b;
        }


        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Math Game");
            Console.WriteLine("1) Sumation Operation");
            Console.WriteLine("2) Substraction Operation");
            Console.WriteLine("3) Multiplication Operation");
            Console.WriteLine("4) Division Operation");
            Console.WriteLine("5) Show Past Operations");
            Console.WriteLine("6) Quit");
        }
    }
}
