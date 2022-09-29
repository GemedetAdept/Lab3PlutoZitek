// While Loop

bool loopBool = true;
int moduloDivisor = 23;
string userInput = "";

while (loopBool)  {

	// Reset the console's background color
	Console.ResetColor();
	Console.Clear();

	Console.Write("Enter a number between 10 and 99 or \"exit\" to Quit \n> ");
	userInput = Console.ReadLine();

	// Exit loop if user types "exit"
	if  (userInput == "exit") {
		loopBool = false;
	}

	else {

		// Convert input value to integer if not "exit"
		int inputNumber = 0;
		inputNumber = int.Parse(userInput);

		string moduloResult = "";

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

if (loopBool == false && userInput == "exit") {

	Console.Clear();
	Console.WriteLine("Thanks for playing!");

	Console.ReadKey();
	Environment.Exit(0);
}

