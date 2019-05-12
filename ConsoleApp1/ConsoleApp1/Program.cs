using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number(it must be 0 to 4,294,967,295)");
            string userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out _))
            {
                Console.WriteLine("Please input a valid number(it must be 0 to 4,294,967,295)");
                userInput = Console.ReadLine();
            }

            var userinputNumber = int.Parse(userInput);
            var total = 0;
            var sumEvens = 0;
            var sumDigits = 0;
            foreach (var item in userInput)
            {
                sumDigits = sumDigits + int.Parse(item.ToString());   
            }
            while (userinputNumber > 0)
            {
                total = total + userinputNumber;
                if (userinputNumber % 2 == 0)
                {
                    sumEvens = sumEvens + userinputNumber;
                }
                userinputNumber--;
            }
            Console.WriteLine("Sum of from 1 to " + userInput + " is:" + total);
            Console.WriteLine("Sum Even numbers of from 1 to " + userInput + " is:" + sumEvens);
            Console.WriteLine("Sum of digits: " + sumDigits);
        }
    }
}
