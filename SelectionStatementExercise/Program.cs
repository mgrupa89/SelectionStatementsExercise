using System;

namespace SelectionStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name.");
            //var name = (Console.ReadLine());

            //Console.WriteLine("I need you to give me the upper limit for the range of numbers");


            //bool rightAnswer = false;
            //var userResponse = Console.ReadLine();

            //var upperLimit = int.Parse(userResponse);

            //var random = new Random();
            //var number = random.Next(1, upperLimit);

            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");
            //Console.WriteLine("*******************************************************");

            //Console.WriteLine($"Hello {name}, I want to play a game.");
            //Console.WriteLine("For too long you have copy pasted code, randomly entering what you found on Google, and Stack Overflow, not knowing what you were entering. Now you must put your faith in randomness to survive. ");


            //Console.WriteLine("Live or die, make your choice.");
            //do
            //{
            //    var guess = int.Parse(Console.ReadLine());

            //    if (guess > number)
            //    {
            //        Console.WriteLine($"I'm sorry {name}, you are too high, Game Over.");
            //    }

            //    else if (guess < number)
            //    {
            //        Console.WriteLine($"I'm sorry {name}, you are too low, Game Over.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Congratulations {name}, you are free.");
            //        rightAnswer = true;
            //    }
            //} while (rightAnswer == false);

            Console.WriteLine("What is your favorite school subject?");

            var subjectResponse = Console.ReadLine();

            switch (subjectResponse.ToLower().Trim())
            {
                case "history":
                    Console.WriteLine("History is cool I like history too!");
                    break;
                case "science":
                    Console.WriteLine("I love science! that's also my favorite subject");
                    break;
                case "english":
                    Console.WriteLine("English is a close second favorite for me. I love to read and write!");
                    break;
                case "math":
                    Console.WriteLine("Ugh, I really don't like math, but thats cool that you enjoy it!");
                    break;
                case "phyed":
                    Console.WriteLine("PhyEd is nice, it's good to get a bit of exercise once and a while!");
                    break;
                default:
                    Console.WriteLine("Please enter one of the following: \n" + "history \n" + "science \n" + "english \n" + "math \n" + "phyed");
                    break;












            }

            
        } 


    }
}
        
