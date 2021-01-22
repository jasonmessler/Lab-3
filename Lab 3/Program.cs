using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo; 

            Console.Write("Welcome to the number analyzer! Please enter your name  ");  //name entry
            var name = Console.ReadLine();
            
                do
                {
                    Console.Write("Please enter a number between 1 and 100  ");
                    var userInput = Console.ReadLine();
                    var input = int.Parse(userInput);

                    if (input < 1 || input > 100) // validation guarantee
                    {
                        Console.WriteLine($"Incorrect. You must select a number between 1 and 100");
                    }

                    else if (input % 2 != 0)  // requirement 1
                    {
                        Console.WriteLine($"{name} chose {input}: Odd");
                    }

                    else if (input % 2 == 0 && input > 1 && input < 25)   // requirement 2
                    {
                        Console.WriteLine($"{name} chose even and less than 25");
                    }

                    else if (input % 2 == 0 && input > 25 && input < 61)  // requirement 3
                    {
                        Console.WriteLine($"{name} chose Even");
                    }

                    else if (input % 2 == 0 && input > 60)  // reqirement 4
                    {
                        Console.WriteLine($"{name} chose {input}: Even");
                    }

                    else if (input % 2 != 0 && input > 60)  // requirement 5 - could also have been combined with requirement 1 as a single statement but separated to fit specifications. edit: clarified in class
                    {
                        Console.WriteLine($"{name} chose {input}: Odd");
                    }

                    else if (input % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }

                    Console.Write("Would you like to continue (y/n)? ");
                    yesOrNo = Console.ReadLine();

                } while (yesOrNo == "y");
            
              Console.WriteLine($"Thanks for playing {name}! May the Schwartz be with you! Goodbye ");
              Console.ReadLine();






        }











    }
        
    
}
