namespace Practice
{
	class MainProgram
	{
		static void Main()
		{
			CustomConsole.StartupSound();
			CustomConsole.CustomConsoleColors();

			Operations Operation = new Operations();

			while (true)
			{                               
				if (!Operation.RunSubroutine)
				{
					Operation.ChooseSubroutine();
				}
				else
				{
					Operation.RunSelectedSubroutine();
				}
			}
		}
	}
}

