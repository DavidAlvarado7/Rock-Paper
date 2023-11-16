namespace Roshambo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rock Paper Scissors!");
        Console.WriteLine("Please enter your name:");
        var name = Console.ReadLine();
        Player player = new Player(name);

        Console.WriteLine("Would you like to play agaist the RockPlayer or RandomPlayer?");
        var gameChoice = Console.ReadLine();

        Console.WriteLine("Rock, Paper, or Scissors?");
        var choice = Console.ReadLine();
        RockPlayer karla = new RockPlayer();
        karla.GenerateRoshambo();       
        
        
        while (true)
        {
            Console.WriteLine("Want to play again? (Y/N)");
            string yN = Console.ReadLine().ToUpper();

            if (yN == "Y")
            {
                Console.WriteLine("Rock, Paper, or Scissors?");
                var choice2 = Console.ReadLine();
                karla.GenerateRoshambo();
                Console.WriteLine();
            }
        }



    }
}
        

        
        
    



