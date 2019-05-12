using System;

namespace emailTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEmail = Console.ReadLine();
            byte count = 0;
            while (count !=1)
            {
                    foreach (var item in userEmail)
                    {
                        if (item == '@')
                        {
                            count++;
                        }
                    }
                if (count == 0)
                {
                    Console.WriteLine("Please input a valid e-mail");
                    userEmail = Console.ReadLine();

                }
            }
            if (count == 1)
            {
                Console.WriteLine("Ur e-mail is valid");
            }
        }
    }
}
