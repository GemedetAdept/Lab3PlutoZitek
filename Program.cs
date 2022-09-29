selectionMenu:
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

		int menuSelection = 0;
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
				goto selectionMenu;
		}

		int firstInputNumber = 0;
		int secondInputNumber = 0; 

		Console.WriteLine($"Enter two numbers to {printSelection}:");
			Console.Write("First number >");
			firstInputNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("");
			Console.Write("Second number >");
			secondInputNumber = int.Parse(Console.ReadLine());


	}

bool loopBool = true;

		string loopSelector = "for";

string moduloResult = "";
int moduloDivisor = 0;
int lowerBound = 0;
int upperBound = 0;

string userInput = "";

// While Loop
if (loopSelector == "while" && loopBool == true) {

	while (loopBool)  {

		// Reset the console's background color
		Console.ResetColor();
		Console.Clear();

		lowerBound = 10;
		upperBound = 99;
		moduloDivisor = 23;

		Console.Write($"Enter a number between {10} and {99} or \"exit\" to Quit \n> ");
		userInput = Console.ReadLine();

		// Exit program if user types "exit"
		if (userInput == "exit") {
			loopBool = false;
			continue;
		}

		else {

			// Convert input value to integer if not "exit"
			int inputNumber = 0;
			inputNumber = int.Parse(userInput);


			if (inputNumber < lowerBound || inputNumber > upperBound) {
				Console.Clear();

				Console.WriteLine($"{inputNumber} is not within the range of {lowerBound}–{upperBound}.");
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();

				continue;
			}

			if (inputNumber % moduloDivisor == 0) {
				Console.BackgroundColor = ConsoleColor.Green;
				moduloResult = "is";
			}

			else {
				Console.BackgroundColor = ConsoleColor.Red;
				moduloResult = "is not";
			}

			Console.Clear();
			Console.WriteLine($"{inputNumber} {moduloResult} divisible by {moduloDivisor}.");

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}

}


// Do While loop
while (loopSelector == "do while" && loopBool == true) {

	// Reset the console's background color
	Console.ResetColor();
	Console.Clear();

	lowerBound = 10;
	upperBound = 99;
	moduloDivisor = 34;

	Console.Write($"Enter a number between {10} and {99} or \"exit\" to Quit \n> ");
	userInput = Console.ReadLine();

	// Exit program if user types "exit"
	if (userInput == "exit") {
		loopBool = false;
		continue;
	}

	// Convert input value to integer if not "exit"
	int inputNumber = 0;
	inputNumber = int.Parse(userInput);

	if (inputNumber < lowerBound || inputNumber > upperBound) {
		Console.Clear();

		Console.WriteLine($"{inputNumber} is not within the range of {lowerBound}–{upperBound}.");
		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
		continue;
	}

	else {

		do {
			if (inputNumber % moduloDivisor == 0 ) {
				Console.BackgroundColor = ConsoleColor.Green;
				moduloResult = "is";
			}
			break;
		}
		while (loopBool == true);

		do {
			if (inputNumber % moduloDivisor != 0){
				Console.BackgroundColor = ConsoleColor.Red;
				moduloResult = "is not";
			}
			break;
		}
		while (loopBool == true);

		Console.Clear();
		Console.WriteLine($"{inputNumber} {moduloResult} divisible by {moduloDivisor}.");

		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
	}
}

// For Loop
while (loopSelector == "for" && loopBool == true) {

	// Reset the console's background color
	Console.ResetColor();
	Console.Clear();

	lowerBound = 10;
	upperBound = 99;
	moduloDivisor = 33;

	Console.Write($"Enter a number between {10} and {99} or \"exit\" to Quit \n> ");
	userInput = Console.ReadLine();

	// Exit program if user types "exit"
	if (userInput == "exit") {
		loopBool = false;
		continue;
	}

	// Convert input value to integer if not "exit"
	int inputNumber = 0;
	inputNumber = int.Parse(userInput);

	if (inputNumber < lowerBound || inputNumber > upperBound) {
		Console.Clear();

		Console.WriteLine($"{inputNumber} is not within the range of {lowerBound}–{upperBound}.");
		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
		continue;
	}

	else {

		for (int i; loopBool == true;) {

			if (inputNumber % moduloDivisor == 0) {
				Console.BackgroundColor = ConsoleColor.Green;
				moduloResult = "is";
				break;
			}

			if (inputNumber % moduloDivisor != 0) {
				Console.BackgroundColor = ConsoleColor.Red;
				moduloResult = "is not";
				break;
			}
		}

		Console.Clear();
		Console.WriteLine($"{inputNumber} {moduloResult} divisible by {moduloDivisor}.");

		Console.WriteLine("Press any key to continue...");
		Console.ReadKey();
	}
}


// Exit Program
if (loopBool == false) {
	Console.Clear();
	Console.WriteLine("Thanks for playing!");

	Console.ReadKey();
	Environment.Exit(0);
}

exitProgram:
	Console.Clear();
	Console.WriteLine("Thanks for playing!");

	Console.ReadKey();
	Environment.Exit(0);