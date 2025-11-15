namespace Practice.Quests
{
	internal class TheReplicatorOfDTo
	{
		//Make a program that creates an array of length 5
		//Ask the user for five numbers and put them in the array
		//Make a second array of length 5
		//Use a loop to copy the values out of the original array and into the new one
		//Display the contents of both arrays one at a time to illustrate that the Riplicator of D'To works again

		public static void ReplicateDTo()
		{
			int[] firstArray = new int[5];

			for (int i = 0; i < firstArray.Length;)
			{
				Console.WriteLine("Please input a whole number...");
				if (int.TryParse(Console.ReadLine(), out int inputValue))
				{
					firstArray[i] = inputValue;
					i++;
				}
			}

			int[] secondArray = new int[5];

			for (int i = 0; i < secondArray.Length; i++)
			{
				secondArray[i] = firstArray[i];

				Console.WriteLine($"First Array: {firstArray[i]}");
				Console.WriteLine($"Second Array: {secondArray[i]}");
			}
		}
	}
}
