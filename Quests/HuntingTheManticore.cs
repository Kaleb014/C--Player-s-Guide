namespace Practice.Quests
{
	//Establish the game's starting state: the Manticore begins with 10 hp and the city with 15. <-|
	// |-> The game starts at round 1.
	//Ask the first player to choose the Manticore's distance from the city (0 to 100). <-|
	// |-> Clear the screen afterward.
	//Run the game in a loop until either the Manticore's or city's health reaches 0.
	//Before the second player's turn, display the round number, the city's hp, and the Manticore's hp.
	//Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple <-|
	// |-> of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. <-|
	// |-> Display this to the player.
	//Get a target range from the second player, and resolve its effect. Tell the user if they overshot <-|
	// |-> (too far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore's hp <-|
	// |-> by the expected amount.
	//If the Manticore is still alive, reduce the city's hp by 1.
	//Advance to the next round.
	//When the Manticore or the city's hp reaches 0, end the game and dispaly the outcome.
	//User different colors for different types of messages.
	internal class HuntingTheManticore
	{
		public static void TheHunt()
		{
			Console.WriteLine("The Uncoded One's airship, the Manticore, has begun an all-out attack on the city of Consolas.\n" +
				"It must be destroyed, or the city will fall!\n");

			byte manticoreLocation = GetManticoreLocation();
			
			GameInfo gameInfo = new GameInfo();
			Manticore manticore = new Manticore(manticoreLocation);
			City city = new City();

			Console.Clear();
			Console.WriteLine("Player 2, it is your turn.");
			while (!manticore.IsDestroyed && !city.IsDestroyed)
			{
				CombatLoop(gameInfo, manticore, city);
			}
		}

		private static void CombatLoop(GameInfo gameInfo, Manticore manticore, City city)
		{
			DrawLine();

			Console.WriteLine($"STATUS: Round: {gameInfo.Round}  City: {city.MaxHP}/{city.HP}  Manticore: {manticore.MaxHP}/{manticore.HP}");
			byte damage = city.DealDamage(gameInfo.Round);
			Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
			Console.ForegroundColor = ConsoleColor.Green;

			city.attackLocation = GetShotRange();
			bool dealDamage = City.HitOrMiss(city.attackLocation, manticore.location);

			if (dealDamage)
			{
				manticore.TakeDamage(damage);
			}

			if (manticore.IsDestroyed)
			{
				Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
			}
			else
			{
				city.TakeDamage(manticore.DealDamage());
				gameInfo.Round++;
			}
		}

		private static byte GetShotRange()
		{
			string prompt = "From 0-100 enter the desired cannon range: ";
			
			return (byte)TakingANumber.AskForNumberInRange(prompt, 0, 100);
		}

		private static byte GetManticoreLocation()
		{
			string prompt = "Player 1, from 0-100 what is the Manticore's location? (Do not share with Player 2): ";
			
			return (byte)TakingANumber.AskForNumberInRange(prompt, 0, 100);
		}

		private static void DrawLine()
		{
			byte repeat = 0;
			while (repeat != 100)
			{
				Console.Write("-");
				repeat++;
			}
			Console.WriteLine("");
		}

		private class Entity
		{
			public byte HP { get; private set; }
			public byte MaxHP { get; private set; }

			public Entity(byte _hp)
			{
				HP = _hp;
				MaxHP = _hp;
			}

			public bool IsDestroyed => HP == 0;

			public void TakeDamage(byte _damage)
			{
				HP = (byte)(HP > _damage ? HP - _damage : 0);
			}

			public virtual byte DealDamage(byte _round = 1)
			{
				return _round;
			}
		}

		private class City : Entity
		{
			private const byte defaultHP = 15;
			public byte attackLocation;
			public City() : base(defaultHP)
			{
			}

			public static bool HitOrMiss(byte shotRange, byte manticoreLocation)
			{
				if (shotRange == manticoreLocation)
				{
					Console.WriteLine("That round was a DIRECT HIT!");
					return true;
				}
				else if (shotRange > manticoreLocation)
				{
					Console.WriteLine("That round OVERSHOT the target.");
				}
				else
				{
					Console.WriteLine("That round FELL SHORT of the target.");
				}

					return false;
			}

			public override byte DealDamage(byte _round)
			{
				if (_round % 5 == 0 && _round % 3 == 0)
				{
					Console.ForegroundColor = ConsoleColor.White;
					return 10;
				}
				else if (_round % 5 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					return 3;
				}
				else if (_round % 3 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					return 3;
				}

				return 1;
			}
		}

		private class Manticore : Entity
		{
			private const byte defaultHP = 10;
			public byte location;
			public Manticore(byte _location) : base(defaultHP)
			{
				location = _location;
			}
		}

		private class GameInfo
		{
			public byte Round { get; set; }

			public GameInfo()
			{
				Round = 1;
			}
		}
	}
}
