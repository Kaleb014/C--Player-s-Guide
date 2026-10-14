namespace Practice.Quests
{
	internal class SimulasTest
	{
		// Define an enumeration for the state of the chest. (Open, closed, locked)
		// Make a variable whose type is this new enumeration.
		// Write code to allow you to manipulate the chest with the lock, unlock, <-|
		// |-> open, and close commands, but ensure that you don't transition <-|
		// |-> between states that don't support it.
		// Loop forever, asking for the next command.
		public static void RunTest()
		{
			Console.Write("Input 'STOP' at any time to exit program loop. Press [ENTER] to continue...");
			string input = Console.ReadLine().ToLower() == "stop" ? "stop" : "";
			Console.Clear();
			
			Chest chest = Chest.Open;
			
			while (input.ToLower() != "stop")
			{
				Console.Write($"The chest is {chest} what would you like to do? ({GetChestCommands(chest)}): ");
				
				input = Console.ReadLine();
				chest = SetChestState(chest, input);
				Console.Clear();
			}
		}

		enum Chest
		{
			Open,
			Closed,
			Locked,
		}

		private static string GetChestCommands(Chest _chest)
		{
			return _chest switch
			{
				Chest.Open => "Close",
				Chest.Closed => "Open or Lock",
				Chest.Locked => "Unlock",
				_ => string.Empty,
			};
		}

		private static Chest SetChestState(Chest _chest, string _command)
		{
			_command = (_command ?? string.Empty).Trim().ToLowerInvariant();

			return (_chest, _command) switch
			{
				(Chest.Open,  "close")  => Chest.Closed,
				(Chest.Closed,"lock")   => Chest.Locked,
				(Chest.Locked,"unlock") => Chest.Closed,
				(Chest.Closed,"open")   => Chest.Open,
				_                       => _chest,
			};
		}
	}
}
