namespace Practice.Quests
{
	internal class TheLawsOfFreach
	{
		public static void CountDownFromTenToOne(int number = 10)
		{
			//Write code that counts down from 10 to 1 using a recursive method

			Console.WriteLine(number);

			if(number != 1)
			{
				number--;
				CountDownFromTenToOne(number);
			}
		}
		public static void ComputeMinimumAndAverageValuesForLoop()
		{
			//Start with the code for computing an array's minimum and average values
			//in the section "Some Examples with Arrays," starting on page 94.
			//Modify the code to use foreach loops instead of for loops

			int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

			int currentSmallest = int.MaxValue;
			for (int index = 0; index < array.Length; index++)
			{
				if (array[index] < currentSmallest)
				{
					currentSmallest = array[index];
				}
			}

			Console.WriteLine(currentSmallest);

			int total = 0;
			for (int index = 0; index < array.Length; index++)
			{
				total += array[index];
			}

			float average = (float)total / array.Length;
			Console.WriteLine(average);
		}


		public static void ComputeMinimumAndAverageValuesForeachLoop()
		{
			//Start with the code for computing an array's minimum and average values
			//in the section "Some Examples with Arrays," starting on page 94.
			//Modify the code to use foreach loops instead of for loops

			int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

			int currentSmallest = int.MaxValue;
			foreach (int number in array)
			{
				if (number < currentSmallest)
				{
					currentSmallest = number;
				}
			}

			Console.WriteLine(currentSmallest);

			int total = 0;
			foreach (int number in array)
			{
				total += number;
			}

			float average = (float)total / array.Length;
			Console.WriteLine(average);
		}
	}
}
