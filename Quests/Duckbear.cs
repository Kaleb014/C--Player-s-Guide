namespace Practice.Quests
{
	internal class Duckbear
	{
		//Create a program that lets the user enter the number of chocolate eggs gathered that day.
		//Using / and %, compute how many eggs each sister should get and how many are left over for the duckbear.

		public static void GatherEggs()
		{
			int chocolateEggs = TakingANumber.AskForNumber("How many chocolate eggs were gathered today? ");

			if (chocolateEggs > 0)
			{
				int sistersEggs = chocolateEggs / 4;
				int remainingEggs = chocolateEggs % 4;

				Console.WriteLine("Eggs Gathered: {0}\nSisters' Eggs: {1}\nDuckbear's Eggs: {2}", chocolateEggs, sistersEggs, remainingEggs);
			}
			else
			{
				Console.WriteLine("Cannot gather less than zero eggs.");
			}

			GatherEggs();
		}
	}
}
