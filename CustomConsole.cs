namespace Practice
{
	internal class CustomConsole
	{
		//TODO: prompt user at startup to select color and sound option
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
}
