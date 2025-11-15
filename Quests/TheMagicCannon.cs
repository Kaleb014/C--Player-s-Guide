namespace Practice.Quests
{
	internal class TheMagicCannon
	{
		//Every third turn of a crank, the fire gem activates, and the cannon produces a fire blast.
		//Every fifth turn of the crank, an electric gem activates, and the cannon produces an electric blast.
		//When the two line up, it generates a potent combined blast.
		//Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect.
		//Change the color of the output based on the type of blast. (Red for fire, yellow for electric, and blue for electric and fire).
		public static void CalculateBlastType()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 5 == 0 && i % 3 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine($"{i}: Electric & Fire.");
					continue;
				}
				else if (i % 5 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine($"{i}: Electric.");
					continue;
				}

				else if (i % 3 == 0)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"{i}: Fire.");
					continue;
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"{i}: Normal.");
			}
		}
	}
}
