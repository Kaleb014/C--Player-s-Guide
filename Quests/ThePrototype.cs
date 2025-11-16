namespace Practice.Quests
{
	internal class ThePrototype
	{
		//Build a program that will allow a user, the pilot, to enter a number.
		//If the number is above 100 or less than 0, keep asking.
		//Clear the screen once the program has collected a good number.
		//Ask a second user, the hunter, to guess numbers.
		//Indicate whether the user guessed too high, too low, or guessed right.
		//Loop until they get it right, then end the program.
		public static void GuessShipLocation()
		{
			int maxValue = 100;
			int minValue = 0;
			int pilotValue = -1;
			int hunterValue = -1;


			Console.WriteLine("'Lo there, Pilot! Where will ye be flying the Uncoded One's airship?");
			while (pilotValue < minValue || pilotValue > maxValue)
			{
				pilotValue = TakingANumber.AskForNumberInRange("Enter a whole value ranging from 0 - 100: ", 0, 100);
			}


			Console.WriteLine("Hunter, where do you think the Uncoded One's airship pilot is navigating his vessel?");
			while (hunterValue < minValue || hunterValue > maxValue)
			{
				hunterValue = TakingANumber.AskForNumberInRange("Enter a whole value ranging from 0 - 100: ", 0, 100);

				if (hunterValue > pilotValue)
				{
					Console.WriteLine("You guessed too high! Try again.");
					hunterValue = -1;
					continue;
				}

				else if (hunterValue < pilotValue)
				{
					Console.WriteLine("You guessed too low! Try again.");
					hunterValue = -1;
					continue;
				}

				else
				{
					Console.WriteLine("That's correct, excellent job!");
				}
			}
		}
	}
}
