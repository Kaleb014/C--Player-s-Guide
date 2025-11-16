namespace Practice.Quests
{
	internal class DominionOfKings
	{
		//Create a program that allows the users to enter how many provinces, duchies, and estates they have.
		//Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
		//Display the point total to the user.

		public static void CalculateKingdomScore(int estates = 0, int duchies = 0, string currentCase = "Estate")
		{
			switch (currentCase)
			{
				case "Estate":
					estates = TakingANumber.AskForNumber("Estates: ");

					CalculateKingdomScore(estates, 0, "Duchy");
					break;
				case "Duchy":
					duchies = TakingANumber.AskForNumber("Duchies: ");

					CalculateKingdomScore(estates, duchies, "Province");
					break;
				case "Province":
					int provinces = TakingANumber.AskForNumber("Provinces: ");

					int totalScore = (estates * 1) + (duchies * 3) + (provinces * 6);
					Console.WriteLine("Total Kingdom Points: {0}", totalScore);
					CalculateKingdomScore();
					break;

				default:
					CalculateKingdomScore();
					break;
			}
		}
	}
}
