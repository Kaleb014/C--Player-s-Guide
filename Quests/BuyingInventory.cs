namespace Practice.Quests
{
	internal class BuyingInventory
	{
		//Build a program that will show the menu illustrated above.
		//As the user to enter a number from the menu.
		//Using the information above, use a switch (either type) to show the item's cost.
		public static void BuySwitchExpression()
		{
			CustomConsole.CustomConsoleTitle("Buying Inventory");
			Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n" +
					"3 - Climing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n");

			string input = TakingANumber.AskForNumber("What number do you want to see the price of? ").ToString();

			string item = input switch
			{
				"1" => "Rope cost ",
				"2" => "Torches cost ",
				"3" => "Climbing Equipment cost ",
				"4" => "Clean Water cost ",
				"5" => "Machete cost ",
				"6" => "Canoe cost ",
				_ => "Sorry, we don't have that item"
			};

			string cost = input switch
			{
				"1" => "10 gold",
				"2" => "15 gold",
				"3" => "25 gold",
				"4" => "1 gold",
				"5" => "20 gold",
				"6" => "200 gold",
				_ => ""
			};

			Console.WriteLine($"{item}{cost}.\n");

			BuySwitchExpression();
		}

		public static void BuySwitchStatment()
		{
			CustomConsole.CustomConsoleTitle("Buying Inventory");

			Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n" +
					"3 - Climing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n");

			string item;
			string cost;

			string input = TakingANumber.AskForNumber("What number do you want to see the price of? ").ToString();

			switch (input)
			{
				case "1":
					item = "Rope cost "; cost = "10 gold";
					break;
				case "2":
					item = "Torches cost "; cost = "15 gold";
					break;
				case "3":
					item = "Climbing Equipment cost "; cost = "25 gold";
					break;
				case "4":
					item = "Clean Water cost "; cost = "1 gold";
					break;
				case "5":
					item = "Machete cost "; cost = "20 gold";
					break;
				case "6":
					item = "Canoe cost "; cost = "200 gold";
					break;
				default:
					; item = "Sorry, we don't have that item"; cost = "";
					break;
			}

			Console.WriteLine($"{item}{cost}.\n");

			BuySwitchStatment();
		}
	}
}
