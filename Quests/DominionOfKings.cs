namespace Practice.Quests
{
	internal class DominionOfKings
	{
		//Create a program that allows the users to enter how manyu provinces, duchies, and estates they have.
		//Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
		//Display the point total to the user.

		public static void CalculateKingdomScore(int estates = 0, int duchies = 0, string _state = "Estate")
		{
			switch (_state)
			{
				case "Estate":
					Console.Write("Estates: ");
					if (!int.TryParse(Console.ReadLine(), out estates))
					{
						Console.WriteLine("Enter only whole numbers.");
						CalculateKingdomScore();
					}
					else
					{
						CalculateKingdomScore(estates, 0, "Duchy");
					}
					break;
				case "Duchy":
					Console.Write("Duchies: ");
					if (!int.TryParse(Console.ReadLine(), out duchies))
					{
						Console.WriteLine("Enter only whole numbers.");
						CalculateKingdomScore(estates, 0, "Duchy");
					}
					else
					{
						CalculateKingdomScore(estates, duchies, "Province");
					}
					break;
				case "Province":
					Console.Write("Provinces: ");
					if (!int.TryParse(Console.ReadLine(), out int provinces))
					{
						Console.WriteLine("Enter only whole numbers.");
						CalculateKingdomScore(estates, duchies, "Province");
					}
					else
					{
						int totalScore = (estates * 1) + (duchies * 3) + (provinces * 6);
						Console.WriteLine("Total Kingdom Points: {0}", totalScore);
						CalculateKingdomScore();
					}
					break;

				default:
					CalculateKingdomScore();
					break;
			}
		}
	}
}
