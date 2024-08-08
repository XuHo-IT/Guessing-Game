using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 100);
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 100 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");
          

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess or 0 for exit.");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == 0)
                {
                    Console.WriteLine("Thanks for using our app!");
                    break;
                }
                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Unbelievable!!! Correct!!");
                    isCorrectGuess = true;
                    Console.WriteLine("Congratulation, you have won the game");
                }
            }
           
            Console.ReadKey();
        }
    }
}
