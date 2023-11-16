using System;
namespace Roshambo
{
	public class Player
	{
		
		public string Name { get; set; }
		public Roshambo Value { get; set; }

		public Player ()
		{
			Name = string.Empty;			
		}

		public Player(string name)

		{
			name = Name;
			

		}

		public void GenerateRoshambo()	
		{
			RockPlayer Karla = new RockPlayer();
			Karla.Value.ToString();
			
			Console.WriteLine($"Karla Threw {Value}");
				
			
			
		}
	}

	public class RockPlayer : Player
	{
		
		public RockPlayer()
		{
			
			Value = Roshambo.rock;
				
		}
	}
	




	
}

