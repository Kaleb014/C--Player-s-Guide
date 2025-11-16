namespace Practice.Quests
{
	internal class RepairingTheClocktower
	{
		//Take a number as input from the console.
		//Display the word "Tick" if the number is even.
		//Display the word "Tock" if the number is odd.

		public static void TickTockOnTheClock()
		{
			int tickOrTock = TakingANumber.AskForNumberInRange("Clock value? (Enter a value ranging from -2,147,483,647 to 2,147,483,647) ", -2147483647, 2147483647);
			
			switch (tickOrTock % 2)
			{
				case 0:
					Console.WriteLine("Tick");
					break;
				default:
					Console.WriteLine("Tock");
					break;
			}

			TickTockOnTheClock();
		}
	}
}
