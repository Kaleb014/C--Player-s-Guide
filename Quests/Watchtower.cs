namespace Practice.Quests
{
	internal class Watchtower
	{
		//Ask the user for an x value and a y value. These are coodinated of the enemy relative to the watchtower's location.
		//Using the image on the right, if statements, and relational operators, display a message about what direction the enemy is coming from.
		public static void GetEnemyDirection()
		{
			Console.Write("Enemy x? ");
			if (!int.TryParse(Console.ReadLine(), out int enemyX))
			{
				Console.WriteLine("Enter only whole numbers.");
				GetEnemyDirection();
				return;
			}

			Console.Write("Enemy y? ");
			if (!int.TryParse(Console.ReadLine(), out int enemyY))
			{
				Console.WriteLine("Enter only whole numbers.");
				GetEnemyDirection();
				return;
			}

			if (enemyX == 0 && enemyY == 0)
				Console.WriteLine("The enemy is here!");

			else if (enemyX == 0 && enemyY > 0)
				Console.WriteLine("The enemy is to the north!");

			else if (enemyX == 0 && enemyY < 0)
				Console.WriteLine("The enemy is to the south!");

			else if (enemyX > 0 && enemyY == 0)
				Console.WriteLine("The enemy is to the east!");

			else if (enemyX < 0 && enemyY == 0)
				Console.WriteLine("The enemy is to the west!");

			else if (enemyX > 0 && enemyY > 0)
				Console.WriteLine("The enemy is to the northeast!");

			else if (enemyX < 0 && enemyY < 0)
				Console.WriteLine("The enemy is to the southwest!");

			else if (enemyX > 0 && enemyY < 0)
				Console.WriteLine("The enemy is to the southeast!");

			else if (enemyX < 0 && enemyY > 0)
				Console.WriteLine("The enemy is to the northwest!");

			GetEnemyDirection();

		}
	}
}
