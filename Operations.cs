namespace Practice
{
	internal class Operations
	{
		private bool runSubroutine;
		private string[] propgramList;
		private Action selectedSubroutine;

		public bool RunSubroutine
		{
			get { return runSubroutine; }
			set { runSubroutine = value; }
		}

		public string[] ProgramList
		{
			get { return propgramList; }
			set { propgramList = value; }
		}

		public Action SelectedSubroutine
		{
			get { return selectedSubroutine; }
			set { selectedSubroutine = value; }
		}

		public Operations()
		{
			RunSubroutine = false;
			ProgramList = new string[]
			{
				"The Magic Cannon",
				"The Prototype",
				"Discounted Buying Inventory",
				"Buying Inventory",
				"Watchtower",
				"Repairing the Clocktower",
				"Defense of Consolas",
				"Dominion of Kings",
				"Duckbear",
				"The Replicator of D'To",
				"The Laws of Freach - Compute Minimum and Average",
				"Countdown from 10 to 1"
			};
		}

		public void ChooseSubroutine()
		{
			Console.WriteLine("Which program do you wish to run? (Input corresponding list number for the program.)");

			for (int i = 0; i < ProgramList.Length; i++)
			{
				Console.WriteLine($"{i+1}. {ProgramList[i]}");
			}

			string userInput = Console.ReadLine();

			switch (userInput)
			{
				case "1":
					SelectedSubroutine = Quests.TheMagicCannon.CalculateBlastType;
					RunSubroutine = true;
					break;
				case "2":
					SelectedSubroutine = Quests.ThePrototype.GuessShipLocation;
					RunSubroutine = true;
					break;
				case "3":
					SelectedSubroutine = Quests.DiscountedBuyingInventory.BuyDiscount;
					RunSubroutine = true;
					break;
				case "4":
					SelectedSubroutine = Quests.BuyingInventory.BuySwitchStatment;
					RunSubroutine = true;
					break;
				case "5":
					SelectedSubroutine = Quests.Watchtower.GetEnemyDirection;
					RunSubroutine = true;
					break;
				case "6":
					SelectedSubroutine = Quests.RepairingTheClocktower.TickTockOnTheClock;
					RunSubroutine = true;
					break;
				case "7":
					SelectedSubroutine = () => Quests.DefenseOfConsolas.DeployDefense();
					RunSubroutine = true;
					break;
				case "8":
					SelectedSubroutine = () => Quests.DominionOfKings.CalculateKingdomScore();
					RunSubroutine = true;
					break;
				case "9":
					SelectedSubroutine = Quests.Duckbear.GatherEggs;
					RunSubroutine = true;
					break;
				case "10":
					SelectedSubroutine = Quests.TheReplicatorOfDTo.ReplicateDTo;
					RunSubroutine = true;
					break;
				case "11":
					SelectedSubroutine = Quests.TheLawsOfFreach.ComputeMinimumAndAverageValuesForeachLoop;
					RunSubroutine = true;
					break;
				case "12":
					SelectedSubroutine = () => Quests.TheLawsOfFreach.CountDownFromTenToOne();
					RunSubroutine = true;
					break;
				default:
					break;
			}
		}

		public void RunSelectedSubroutine()
		{
			bool checkRerun = false;
			while (RunSubroutine)
			{
				SelectedSubroutine();
				checkRerun = true;

				while (checkRerun)
				{
					Console.WriteLine("Type 'EXIT' to exit the subroutine or press [ENTER] to run it again.");
					string input = Console.ReadLine().ToLower();

					if (input == "")
					{
						checkRerun = false;
					}
					else
					{
						checkRerun = ExitSubroutine(input);
					}
				}
			}
		}

		public bool ExitSubroutine(string input)
		{
			if (input == "exit")
			{
				RunSubroutine = false;
				return RunSubroutine;
			}

			return true;
		}
	}
}
