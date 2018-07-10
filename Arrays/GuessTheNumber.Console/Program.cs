namespace GuessTheNumber.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(0, 101);
            Console.WriteLine("Guess which number I have in my mind, from 0 to 100");
            while (true)
            {
                var input = int.Parse(Console.ReadLine());
                if (input == -1) break;

                if (input == number)
                {
                    Console.WriteLine($"Congrats! You found it! It's {input}");
                    Console.WriteLine("Try again? Enter -1 to exit or just press enter to continue.");
                    if (int.TryParse(Console.ReadLine(), out int restart))
                    {
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine("Guess which number I have in my mind, from 0 to 100");
                    number = random.Next(0, 101);
                }
                else
                {
                    var direction = number > input ? "greater" : "less";
                    Console.Write("Too bad! Try again! ");
                    Console.WriteLine($"The number is {direction} than what you guessed!");
                }
            }
        }
    }
}
