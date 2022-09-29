// There is probably a more programmatic approach to ALL of this, but I'm doing my best to just make it work.

bool loopBool = true;

int menuSelection = 0;
int firstInputNumber = 0;
int secondInputNumber = 0;
int userInputResult = 0;

string moduloResult = "";
int moduloDivisor = 0;

// Select which arithmetic operation to use on two inputted numbers
arithmeticSelectionMenu:
	Console.ResetColor();
	Console.Clear();

	bool menuBool = true;

	while (menuBool) {

		Console.WriteLine("Select an option below:");
			Console.WriteLine("[1] > Add");
			Console.WriteLine("[2] > Subtract");
			Console.WriteLine("[3] > Multiply");
			Console.WriteLine("[4] > Divide");
			Console.WriteLine("[5] > [Exit Program]");
		Console.WriteLine("");

		Console.Write("Enter the number of the desired option > ");
		menuSelection = int.Parse(Console.ReadLine());

		string printSelection = "";
		Console.WriteLine("");

		switch (menuSelection) {

			case 1:
				printSelection = "add";
				break;
			case 2:
				printSelection = "subtract";
				break;
			case 3:
				printSelection = "multiply";
				break;
			case 4:
				printSelection = "divide";
				break;
			case 5:
				goto exitProgram;

			default:
				Console.Clear();
				Console.WriteLine($"{menuSelection} is an invalid option.");
				Console.Write("Press any key to return to menu...");
				Console.ReadKey();
				goto arithmeticSelectionMenu;
		}

		Console.WriteLine($"Enter two numbers to {printSelection}:");
			Console.Write("First number > ");
			firstInputNumber = int.Parse(Console.ReadLine());
			Console.Write("Second number > ");
			secondInputNumber = int.Parse(Console.ReadLine());

		// Check for division by 0
		if (menuSelection == 4 && secondInputNumber == 0) {
			Console.Clear();
			Console.WriteLine("Error: Cannot divide by zero.");
			Console.Write("Press any key to return to menu...");
			Console.ReadKey();
			goto arithmeticSelectionMenu;
		}


		// Calculating output number
		if (menuSelection == 1) {
			userInputResult = firstInputNumber + secondInputNumber;
		}

		else if (menuSelection == 2) {
			userInputResult = firstInputNumber - secondInputNumber;
		}

		else if (menuSelection == 3) {
			userInputResult = firstInputNumber * secondInputNumber;
		}

		else if (menuSelection == 4) {
			userInputResult = firstInputNumber / secondInputNumber;
		}

		Console.WriteLine($"> {userInputResult}");

		goto moduloSelectionMenu;
	}

// Select which of the loops below to use
moduloSelectionMenu:
	Console.Clear();
	menuBool = true;

	int moduloSelection = 0;

	while (menuBool) {
		Console.WriteLine($"Check if {userInputResult} is evenly divisible by:");
			Console.WriteLine("[1] > 23");
			Console.WriteLine("[2] > 34");
			Console.WriteLine("[3] > 33");
			Console.WriteLine("[4] > [Exit Program]");
		Console.WriteLine("");

		Console.Write("Enter the number of the desired option > ");
		moduloSelection = int.Parse(Console.ReadLine());

		switch (moduloSelection) {

			case 1:
				goto moduloTwentyThree;
				break;
			case 2:
				goto moduloThirtyFour;
				break;
			case 3:
				goto moduloThirtyThree;
				break;
			case 4:
				goto exitProgram;

			default:
				Console.Clear();
				Console.WriteLine($"{menuSelection} is an invalid option.");
				Console.Write("Press any key to return to menu...");
				Console.ReadKey();
				goto moduloSelectionMenu;
		}
	}


// While Loop
moduloTwentyThree:
	if (loopBool == true) {

		while (loopBool)  {

			// Reset the console's background color
			Console.ResetColor();
			Console.Clear();

			moduloDivisor = 23;

			if (userInputResult % moduloDivisor == 0) {
				Console.BackgroundColor = ConsoleColor.Green;
				moduloResult = "is";
			}

			else {
				Console.BackgroundColor = ConsoleColor.Red;
				moduloResult = "is not";
			}

			Console.Clear();
			Console.WriteLine($"{userInputResult} {moduloResult} divisible by {moduloDivisor}.");

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();

			goto arithmeticSelectionMenu;
		}

	}


// Do While loop
moduloThirtyFour:
	while (loopBool == true) {

		// Reset the console's background color
		Console.ResetColor();
		Console.Clear();

		moduloDivisor = 34;

		do {
			if (userInputResult % moduloDivisor == 0 ) {
				Console.BackgroundColor = ConsoleColor.Green;
				moduloResult = "is";
			}
			break;
		}
		while (loopBool == true);

		do {
			if (userInputResult % moduloDivisor != 0){
				Console.BackgroundColor = ConsoleColor.Red;
				moduloResult = "is not";
			}
			break;
		}
		while (loopBool == true);

		Console.Clear();
		Console.WriteLine($"{userInputResult} {moduloResult} divisible by {moduloDivisor}.");

		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();

		goto arithmeticSelectionMenu;
	}


// For Loop
moduloThirtyThree:
	while (loopBool == true) {

		// Reset the console's background color
		Console.ResetColor();
		Console.Clear();

		moduloDivisor = 33;

		for (int i; loopBool == true;) {

			if (userInputResult % moduloDivisor == 0) {
				Console.BackgroundColor = ConsoleColor.Green;
				moduloResult = "is";
				break;
			}

			if (userInputResult % moduloDivisor != 0) {
				Console.BackgroundColor = ConsoleColor.Red;
				moduloResult = "is not";
				break;
			}
		}

		Console.Clear();
		Console.WriteLine($"{userInputResult} {moduloResult} divisible by {moduloDivisor}.");

		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();

		goto arithmeticSelectionMenu;
		
	}


// Exit Program
exitProgram:
	Console.Clear();
	Console.WriteLine("Thanks for playing!");

	Console.ReadKey();
	Console.Clear();
	Environment.Exit(0);