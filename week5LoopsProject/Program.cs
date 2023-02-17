using System.Diagnostics.Metrics;
/*
 * Clark Comstock
 * Week 5 Loops project
 * 2/17/2023
 */

namespace week5LoopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem #1: ");
            ProblemOne();
            Console.WriteLine("\nProblem #2: ");
            ProblemTwo();
            Console.WriteLine("\nProblem #3: ");
            ProblemThree();
            Console.WriteLine("\nProblem #4: ");
            ProblemFour();
        }

        static void ProblemOne()
        {
            //starts the count at 1 and increments it to 100
            //number is there to check the modulus of count, if it returns 0 then counter begins counting
            //displays counter after every loop to show how many numbers or divisible by 3
            int count = 1;
            int number = 0;
            int counter = 0;
            while (count <= 100)
            {
                number = count % 3;
                if (number == 0)
                    counter++;
                count++;
                Console.WriteLine(counter);
            }
        }

        static void ProblemTwo()
        {
            //takes the input from the user, checks if it's the assigned escape word, then converts it to an int
            //if the int conversion fails, the input is ignored and the loop repeats
            //displays the end sum when the user types the sentinel word
            string s = "";
            int i = 0;
            int sum = 0;
            Console.WriteLine("Enter any number or type 'ok' to finish: ");
            s = Console.ReadLine();
            while (s != "ok")
            {
                if (int.TryParse(s, out i))
                    sum += i;
                Console.WriteLine("Please enter another value, or enter 'ok': ");
                s = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }

        static void ProblemThree()
        {
            //takes a user's input and finds the factorial. have not tested this with letters and words, I assume it just breaks
            //checks to see if the input is greater than 0. factorials aren't fun if it ends before it starts
            int input = 0;
            int temp = 0;
            int total = 0;
            Console.WriteLine("Please enter a value greater than 0: ");
            input = Convert.ToInt32(Console.ReadLine());
            while (input < 0)
            {
                Console.WriteLine("Please neter a value GREATER than 0: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            //first if makes the total the starting number, that way the factorial works properly
            //the else multiplys the total by the subsequent numbers, making the factorial actually work
            for (temp = input; temp > 0; temp--)
            {
                if (temp == input)
                {
                    total += input;
                }
                else
                {
                    total *= temp;
                }
            }
            Console.WriteLine(input + "! = " + total);

        }

        static void ProblemFour()
        {
            //get the random number from the start, doesn't change throughout the program
            //counter is hard codded to 3 because the first user input is outside of the while statement
            Random r = new Random();
            int randNumber = r.Next(1, 10);
            int input = 0;
            int counter = 3;
            Console.WriteLine("Enter a number between 1 and 10: ");
            input = Convert.ToInt32(Console.ReadLine());
            //the AND makes it so if one of the two statements changes, it breaks the while
            while (input != randNumber && counter > 0)
            {
                counter--;
                Console.WriteLine("Try again: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            if (input == randNumber)
            {
                Console.WriteLine("You win!");
            }
            //show the user what the number was
            else
            {
                Console.WriteLine("It was: " + randNumber);
                Console.WriteLine("You lose");
            }
        }
    }
}