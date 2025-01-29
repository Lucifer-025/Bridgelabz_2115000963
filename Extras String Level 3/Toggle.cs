	using System;

	class Toggle
	{
		static string ToggleCase(string input)
		{
			char[] toggled = input.ToCharArray();
			for (int i = 0; i < toggled.Length; i++)
			{
				if (char.IsUpper(toggled[i]))
					toggled[i] = char.ToLower(toggled[i]);
				else if (char.IsLower(toggled[i]))
					toggled[i] = char.ToUpper(toggled[i]);
			}
			return new string(toggled);
		}

		static void Main()
		{
			Console.Write("Enter a string: ");
			string input = Console.ReadLine();

			Console.WriteLine("Toggled Case: " + ToggleCase(input));
		}
	}
