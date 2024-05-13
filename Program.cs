namespace Practice
{
    class MainProgram
    {
        static void Main()
        {
            CustomConsole.StartupSound();
            CustomConsole.CustomConsoleColors();

            //------Quests------//

            //TheMagicCannon.CalculateBlastType();
            //ThePrototype.GuessShipLocation();
            //DiscountedBuyingInventory.BuyDiscount();
            //BuyingInventory.BuySwitchStatment();
            //BuyingInventory.BuySwitchExpression();
            //Watchtower.GetEnemyDirection();
            //RepairingTheClocktower.TickTockOnTheClock();
            //DefenseOfConsolas.DeployDefense();
            //DominionOfKings.CalculateKingdomScore();
            //Duckbear.GatherEggs();
        }
    }
    class CustomConsole
    {
        //TODO: promp user at startup to select color and sound option
        public static void CustomConsoleColors()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }

        public static void CustomConsoleTitle(string _title)
        {
            Console.Title = _title;
        }

        public static void StartupSound()
        {
            byte duration = 100;

#pragma warning disable CA1416 // Validate platform compatibility
            Console.Beep(4500, duration);
            Console.Beep(3000, duration * 2);
#pragma warning restore CA1416 // Validate platform compatibility
        }    
    }



    //class TheMagicCannon
    //{
    //    //Every third turn of a crank, the fire gem activates, and the cannon produces a fire blast.
    //    //Every fifth turn of the crank, an electric gem activates, and the cannon produces an electric blast.
    //    //When the two line up, it generates a potent combined blast.
    //    //Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect.
    //    //Change the color of the output based on the type of blast. (Red for fire, yellow for electric, and blue for electric and fire).
    //    public static void CalculateBlastType()
    //    {
    //        for(int i = 1; i <= 100; i++)
    //        {
    //            if(i % 5 == 0 && i % 3 == 0)
    //            {
    //                Console.ForegroundColor = ConsoleColor.Yellow;
    //                Console.WriteLine($"{i}: Electric & Fire.");
    //                continue;
    //            }
    //            else if (i % 5 == 0 )
    //            {
    //                Console.ForegroundColor = ConsoleColor.Blue;
    //                Console.WriteLine($"{i}: Electric.");
    //                continue;
    //            }

    //            else if (i % 3 == 0 )
    //            {
    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.WriteLine($"{i}: Fire.");
    //                continue;
    //            }

    //            Console.ForegroundColor = ConsoleColor.Green;
    //            Console.WriteLine($"{i}: Normal.");
    //        }
    //    }
    //}

    //class ThePrototype
    //{
    //    //Build a program that will allow a user, the pilot, to enter a number.
    //    //If the number is above 100 or less than 0, keep asking.
    //    //Clear the screen once the program has collected a good number.
    //    //Ask a second user, the hunter, to guess numbers.
    //    //Indicate whether the user guessed too high, too low, or guessed right.
    //    //Loop until they get it right, then end the program.
    //    public static void GuessShipLocation()
    //    {
    //        int maxValue = 100;
    //        int minValue = 0;
    //        int pilotValue = -1;
    //        int hunterValue = -1;


    //        Console.WriteLine("'Lo there, Pilot! Where will ye be flying the Uncoded One's airship?");
    //        while (pilotValue < minValue || pilotValue > maxValue) 
    //        {
    //            Console.Write("Enter a whole value ranging from 0 - 100: ");
    //            if (int.TryParse(Console.ReadLine(), out int _pilotValue))
    //            {
    //                pilotValue = _pilotValue;
    //            }
    //        }


    //        Console.WriteLine("Hunter, where do you think the Uncoded One's airship pilot is navigating his vessel?");
    //        while (hunterValue < minValue || hunterValue > maxValue)
    //        {
    //            Console.Write("Enter a whole value ranging from 0 - 100: ");
    //            if (int.TryParse(Console.ReadLine(), out int _hunterValue))
    //            {
    //                hunterValue = _hunterValue;

    //                if(hunterValue > pilotValue)
    //                {
    //                    Console.WriteLine("You guessed too high! Try again.");
    //                    hunterValue = -1;
    //                    continue;
    //                }

    //                else if (hunterValue < pilotValue)
    //                {
    //                    Console.WriteLine("You guessed too low! Try again.");
    //                    hunterValue = -1;
    //                    continue;
    //                }

    //                else
    //                {
    //                    Console.WriteLine("That's correct, excellent job!");
    //                }
    //            }
    //        }
    //    }
    //}

    //class DiscountedBuyingInventory
    //{
    //    //Modify your program from before to also ask the user for their name.
    //    //If their name equals your name, divide the cost in half.
    //    public static void BuyDiscount()
    //    {
    //        CustomConsole.CustomConsoleTitle("Discounted Inventory");

    //        string item;
    //        double cost = -1;
    //        string myName = ("Name");

    //        Console.Write("Lo' there, traveler- what's thy name? ");
    //        string userName = Console.ReadLine()!;

    //        Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n" +
    //            "3 - Climing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n" +
    //            "What number do you want to see the price of? ");

    //        string input = Console.ReadLine()!;
            
    //        switch (input)
    //        {
    //            case "1":
    //                item = "Rope cost "; cost = 10;
    //                break;
    //            case "2":
    //                item = "Torches cost "; cost = 15;
    //                break;
    //            case "3":
    //                item = "Climbing Equipment cost "; cost = 25;
    //                break;
    //            case "4":
    //                item = "Clean Water cost "; cost = 1;
    //                break;
    //            case "5":
    //                item = "Machete cost "; cost = 20;
    //                break;
    //            case "6":
    //                item = "Canoe cost "; cost = 200;
    //                break;
    //            default:
    //                item = "Sorry, we don't have that item";
    //                break;
    //        }

    //        if(userName.ToLower() == myName.ToLower())
    //        {
    //            cost = cost * 0.5;
    //        }

    //        string message = cost != -1 ? $"{item}{cost} gold." : $"{item}";
    //        Console.WriteLine($"{message}\n");

    //        BuyDiscount();
    //    }
    //}

    //class BuyingInventory
    //{
    //    //Build a program that will show the menu illustrated above.
    //    //As the user to enter a number from the menu.
    //    //Using the information above, use a switch (either type) to show the item's cost.
    //    public static void BuySwitchExpression()
    //    {
    //        CustomConsole.CustomConsoleTitle("Buying Inventory");
    //        Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n" +
    //            "3 - Climing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n" +
    //            "What number do you want to see the price of? ");

    //        string input = Console.ReadLine()!;
            
    //        string item = input switch
    //        {
    //            "1" => "Rope cost ",
    //            "2" => "Torches cost ",
    //            "3" => "Climbing Equipment cost ",
    //            "4" => "Clean Water cost ",
    //            "5" => "Machete cost ",
    //            "6" => "Canoe cost ",
    //            _ => "Sorry, we don't have that item"
    //        };

    //        string cost = input switch
    //        {
    //            "1" => "10 gold",
    //            "2" => "15 gold",
    //            "3" => "25 gold",
    //            "4" => "1 gold",
    //            "5" => "20 gold",
    //            "6" => "200 gold",
    //            _ => ""
    //        };

    //        Console.WriteLine($"{item}{cost}.\n");

    //        BuySwitchExpression();
    //    }

    //    public static void BuySwitchStatment()
    //    {
    //        CustomConsole.CustomConsoleTitle("Buying Inventory");

    //        Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n" +
    //            "3 - Climing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n" +
    //            "What number do you want to see the price of? ");

    //        string item;
    //        string cost;
    //        string input = Console.ReadLine()!;

    //        switch(input)
    //        {
    //            case "1": item = "Rope cost "; cost = "10 gold";
    //                break;
    //            case "2": item = "Torches cost "; cost = "15 gold";
    //                break;
    //            case "3": item = "Climbing Equipment cost "; cost = "25 gold";
    //                break;
    //            case "4": item = "Clean Water cost "; cost = "1 gold";
    //                break;
    //            case "5": item = "Machete cost "; cost = "20 gold";
    //                break;
    //            case "6": item = "Canoe cost "; cost = "200 gold";
    //                break;
    //            default: ; item = "Sorry, we don't have that item"; cost = "";
    //                break;
    //        }

    //        Console.WriteLine($"{item}{cost}.\n");

    //        BuySwitchStatment();
    //    }
    //}

    //class Watchtower
    //{
    //    //Ask the user for an x value and a y value. These are coodinated of the enemy relative to the watchtower's location.
    //    //Using the image on the right, if statements, and relational operators, display a message about what direction the enemy is coming from.
    //    public static void GetEnemyDirection() 
    //    {
    //        Console.Write("Enemy x? ");
    //        if (!int.TryParse(Console.ReadLine(), out int enemyX))
    //        {
    //            Console.WriteLine("Enter only whole numbers.");
    //            GetEnemyDirection();
    //            return;
    //        }

    //        Console.Write("Enemy y? ");
    //        if (!int.TryParse(Console.ReadLine(), out int enemyY))
    //        {
    //            Console.WriteLine("Enter only whole numbers.");
    //            GetEnemyDirection();
    //            return;
    //        }

    //        if (enemyX == 0 && enemyY == 0)
    //            Console.WriteLine("The enemy is here!");

    //        else if (enemyX == 0 && enemyY > 0)
    //            Console.WriteLine("The enemy is to the north!");

    //        else if (enemyX == 0 && enemyY < 0)
    //            Console.WriteLine("The enemy is to the south!");

    //        else if (enemyX > 0 && enemyY == 0)
    //            Console.WriteLine("The enemy is to the east!");

    //        else if (enemyX < 0 && enemyY == 0)
    //            Console.WriteLine("The enemy is to the west!");

    //        else if (enemyX > 0 && enemyY > 0)
    //            Console.WriteLine("The enemy is to the northeast!");

    //        else if (enemyX < 0 && enemyY < 0)
    //            Console.WriteLine("The enemy is to the southwest!");

    //        else if (enemyX > 0 && enemyY < 0)
    //            Console.WriteLine("The enemy is to the southeast!");

    //        else if (enemyX < 0 && enemyY > 0)
    //            Console.WriteLine("The enemy is to the northwest!");

    //        GetEnemyDirection();
    //    }
    //}

    //class RepairingTheClocktower
    //{
    //    //Take a number as input from the console.
    //    //Display the word "Tick" if the number is even.
    //    //Display the word "Tock" if the number is odd.

    //    public static void TickTockOnTheClock()
    //    {
    //        Console.Write("Clock Value? ");
    //        if(!int.TryParse(Console.ReadLine(), out int _tickOrTock))
    //        {
    //            Console.WriteLine("Enter a value ranging from -2,147,483,647 to 2,147,483,647.");
    //        }
    //        else
    //        {
    //            switch(_tickOrTock % 2)
    //            {
    //                case 0: Console.WriteLine("Tick");
    //                    break;
    //                default: Console.WriteLine("Tock");
    //                    break;
    //            }
    //        }
    //        TickTockOnTheClock();
    //    }
    //}

    //class DefenseOfConsolas
    //{
    //    //Ask the user for the target row and column.
    //    //Compute the neighboring rows and columns of where to deploy the squad.
    //    //Display the deployment instructions in a different color of your choosing.
    //    //Change the window title to be "Defense of Consolas".
    //    //Play a sound with Console.Beep when the results have been computed and displayed.
    //    //TODO: **Not within requirements, but could check to see if target rows/columns are outside of grid and handle.**

    //    public static void DeployDefense(int _row = 0, string _state = "Row")
    //    {
    //        CustomConsole.CustomConsoleTitle("Defense of Consolas");
    //        switch (_state)
    //        {
    //            case "Row":
    //                Console.Write("Target Row? ");
    //                if (!int.TryParse(Console.ReadLine(), out _row) && _row < 0 && _row > 9)
    //                {
    //                    Console.WriteLine("Enter only whole numbers numbers ranging 1-8.");
    //                    DeployDefense();
    //                }
    //                else
    //                {
    //                    DeployDefense(_row, "Column");
    //                }
    //                break;
    //            case "Column":
    //                Console.Write("Target Column? ");
    //                if (!int.TryParse(Console.ReadLine(), out int _column) && _column < 0 && _column > 9)
    //                {
    //                    Console.WriteLine("Enter only whole numbers ranging 1-8.");
    //                    DeployDefense(_row, "Column");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Deploy to:");
    //                    //int[,] coordinates = new int[4, 4]; <- Might write an alternate version using a 2d array for fun
    //                    int _targetRow;
    //                    int _targetColumn;
    //                    for (int i = 0; i < 4; i++)
    //                    {
    //                        switch (i)
    //                        {
    //                            case 0:
    //                                _targetRow = _row;
    //                                _targetColumn = _column-1;
    //                                Console.WriteLine($"({_targetRow}, {_targetColumn})");
    //                                break;
    //                            case 1:
    //                                _targetRow = _row-1;
    //                                _targetColumn = _column;
    //                                Console.WriteLine($"({_targetRow}, {_targetColumn})");
    //                                break;
    //                            case 2:
    //                                _targetRow = _row;
    //                                _targetColumn = _column+1;
    //                                Console.WriteLine($"({_targetRow}, {_targetColumn})");
    //                                break;
    //                            case 3:
    //                                _targetRow = _row+1;
    //                                _targetColumn = _column;
    //                                Console.WriteLine($"({_targetRow}, {_targetColumn})");
    //                                break;
    //                            default: return;
    //                        }
    //                    }

    //                    Console.Beep();
    //                    DeployDefense();
    //                }
    //                break;
    //            default:
    //                DeployDefense();
    //                break;
    //        }
    //    }
    //}

    //class Duckbear
    //{
    //    //Create a program that lets the user enter the number of chocolate eggs gathered that day.
    //    //Using / and %, compute how many eggs each sister should get and how many are left over for the duckbear.

    //    public static void GatherEggs()
    //    {
    //        if (!int.TryParse(Console.ReadLine(), out int chocolateEggs))
    //        {
    //            Console.WriteLine("Cannot gather a fraction of an egg. (Enter a whole number.)");
    //            GatherEggs();
    //        }
    //        else
    //        {
    //            if (chocolateEggs > 0)
    //            {
    //                int sistersEggs = chocolateEggs / 4;
    //                int remainingEggs = chocolateEggs % 4;

    //                Console.WriteLine("Eggs Gathered: {0}\nSisters' Eggs: {1}\nDuckbear's Eggs: {2}", chocolateEggs, sistersEggs, remainingEggs);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Cannot gather less than zero eggs.");
    //            }
    //            GatherEggs();
    //        }
    //    }
    //}

    //class DominionOfKings
    //{
    //    //Create a program that allows the users to enter how manyu provinces, duchies, and estates they have.
    //    //Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province.
    //    //Display the point total to the user.

    //    public static void CalculateKingdomScore(int estates = 0, int duchies = 0, string _state = "Estate")
    //    {
    //        switch (_state)
    //        {
    //            case "Estate":
    //                Console.Write("Estates: ");
    //                if (!int.TryParse(Console.ReadLine(), out estates))
    //                {
    //                    Console.WriteLine("Enter only whole numbers.");
    //                    CalculateKingdomScore();
    //                }
    //                else
    //                {
    //                    CalculateKingdomScore(estates, 0, "Duchy");
    //                }
    //                break;
    //            case "Duchy":
    //                Console.Write("Duchies: ");
    //                if (!int.TryParse(Console.ReadLine(), out duchies))
    //                {
    //                    Console.WriteLine("Enter only whole numbers.");
    //                    CalculateKingdomScore(estates, 0, "Duchy");
    //                }
    //                else
    //                {
    //                    CalculateKingdomScore(estates, duchies, "Province");
    //                }
    //                break;
    //            case "Province":
    //                Console.Write("Provinces: ");
    //                if (!int.TryParse(Console.ReadLine(), out int provinces))
    //                {
    //                    Console.WriteLine("Enter only whole numbers.");
    //                    CalculateKingdomScore(estates, duchies, "Province");
    //                }
    //                else
    //                {
    //                    int totalScore = (estates*1) + (duchies*3) + (provinces*6);
    //                    Console.WriteLine("Total Kingdom Points: {0}", totalScore);
    //                    CalculateKingdomScore();
    //                }
    //                break;

    //            default:
    //                CalculateKingdomScore();
    //                break;
    //        }
    //    }
    //}


}

