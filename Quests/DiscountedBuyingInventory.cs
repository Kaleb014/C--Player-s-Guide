namespace Practice.Quests
{
	internal class DiscountedBuyingInventory
	{
		//Modify your program from before to also ask the user for their name.
		//If their name equals your name, divide the cost in half.
		public static void BuyDiscount()
		{
			CustomConsole.CustomConsoleTitle("Discounted Inventory");

			string item;
			double cost = -1;
			string myName = ("Name");

			Console.Write("Lo' there, traveler- what's thy name? ");
			string userName = Console.ReadLine()!;

			Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n" +
					"3 - Climing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n");

			string input = TakingANumber.AskForNumber("What number do you want to see the price of? ").ToString();

			switch (input)
			{
				case "1":
					item = "Rope cost "; cost = 10;
					break;
				case "2":
					item = "Torches cost "; cost = 15;
					break;
				case "3":
					item = "Climbing Equipment cost "; cost = 25;
					break;
				case "4":
					item = "Clean Water cost "; cost = 1;
					break;
				case "5":
					item = "Machete cost "; cost = 20;
					break;
				case "6":
					item = "Canoe cost "; cost = 200;
					break;
				default:
					item = "Sorry, we don't have that item";
					break;
			}

			if (userName.ToLower() == myName.ToLower())
			{
				cost = cost * 0.5;
			}

			string message = cost != -1 ? $"{item}{cost} gold." : $"{item}";
			Console.WriteLine($"{message}\n");

			BuyDiscount();
		}
	}
}
