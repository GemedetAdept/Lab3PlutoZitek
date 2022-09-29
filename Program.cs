bool loopBool = true;

		string loopSelector = "do while";

string moduloResult = "";
int moduloDivisor = 0;
int lowerBound = 0;
int upperBound = 0;

string userInput = "";

// While Loop
if (loopSelector == "while") {

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

			Console.Clear();
			Console.WriteLine("Thanks for playing!");

			Console.ReadKey();
			Environment.Exit(0);
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
while (loopSelector == "do while") {

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

		Console.Clear();
		Console.WriteLine("Thanks for playing!");

		Console.ReadKey();
		Environment.Exit(0);
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