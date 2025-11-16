namespace Practice.Quests
{
	internal class TakingANumber
	{
		//Make a method with the signature int AskForNumber(string text)
		//display the text parameter in the console window, get a response from the user,
		//convert it to an int, and return it
		//Make a method with the signature int AskForNumberInRange(string text, int min, int max)
		//only return if the entered number is between the min and max values,
		//otherwise ask again

		public static int AskForNumber(string text)
		{
			while (true)
			{
				Console.Write(text);

				if (int.TryParse(Console.ReadLine(), out int number))
				{
					return number;
				}

				Console.WriteLine("Enter only whole numbers.");
			}
		}
		public static int AskForNumberInRange(string text, int min, int max)
		{
			while (true)
			{
				Console.Write(text);

				if (int.TryParse(Console.ReadLine(), out int number))
				{
					if(number > min && number < max)
					{
						return number;
					}
				}

				Console.WriteLine("Enter only whole numbers within the given range.");
			}
		}
	}
}
