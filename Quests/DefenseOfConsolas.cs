namespace Practice.Quests
{
	internal class DefenseOfConsolas
	{
		//Ask the user for the target row and column.
		//Compute the neighboring rows and columns of where to deploy the squad.
		//Display the deployment instructions in a different color of your choosing.
		//Change the window title to be "Defense of Consolas".
		//Play a sound with Console.Beep when the results have been computed and displayed.
		//TODO: **Not within requirements, but could check to see if target rows/columns are outside of grid and handle.**

		public static void DeployDefense(int _row = 0, string _state = "Row")
		{
			CustomConsole.CustomConsoleTitle("Defense of Consolas");
			switch (_state)
			{
				case "Row":
					Console.Write("Target Row? ");
					if (!int.TryParse(Console.ReadLine(), out _row) && _row < 0 && _row > 9)
					{
						Console.WriteLine("Enter only whole numbers numbers ranging 1-8.");
						DeployDefense();
					}
					else
					{
						DeployDefense(_row, "Column");
					}
					break;
				case "Column":
					Console.Write("Target Column? ");
					if (!int.TryParse(Console.ReadLine(), out int _column) && _column < 0 && _column > 9)
					{
						Console.WriteLine("Enter only whole numbers ranging 1-8.");
						DeployDefense(_row, "Column");
					}
					else
					{
						Console.WriteLine("Deploy to:");
						//int[,] coordinates = new int[4, 4]; <- Might write an alternate version using a 2d array for fun
						int _targetRow;
						int _targetColumn;
						for (int i = 0; i < 4; i++)
						{
							switch (i)
							{
								case 0:
									_targetRow = _row;
									_targetColumn = _column - 1;
									Console.WriteLine($"({_targetRow}, {_targetColumn})");
									break;
								case 1:
									_targetRow = _row - 1;
									_targetColumn = _column;
									Console.WriteLine($"({_targetRow}, {_targetColumn})");
									break;
								case 2:
									_targetRow = _row;
									_targetColumn = _column + 1;
									Console.WriteLine($"({_targetRow}, {_targetColumn})");
									break;
								case 3:
									_targetRow = _row + 1;
									_targetColumn = _column;
									Console.WriteLine($"({_targetRow}, {_targetColumn})");
									break;
								default: return;
							}
						}

						Console.Beep();
						DeployDefense();
					}
					break;
				default:
					DeployDefense();
					break;
			}
		}
	}
}
