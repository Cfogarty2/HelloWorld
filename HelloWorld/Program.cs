// See https://aka.ms/new-console-template for more information
String userInput;
Console.WriteLine("Welcome to HelloWorld. We hope you enjoy your stay.");
userInput = AskForClass();
if ((userInput == "Fighter" || userInput == "Archer" || userInput == "Mage"))
{
    Console.WriteLine($"You have selected {userInput} as your character class");
    Console.ReadKey();
}
else if (userInput == "class info")
{
    Console.WriteLine("You have entered \"class info\"");
    Console.WriteLine("Fighter: Uses melee weapons such as swords, axes, and hammers. Cannot use ranged weapons or cast spells. High HP.");
    Console.WriteLine("Archer: Uses ranged weapons such as bows and crossbows. Cannot use melee weapons or cast spells. Medium HP.");
    Console.WriteLine("Mage: Uses staves. Can cast spells. Low HP.");
    Console.ReadKey();
}
else {
    Console.WriteLine($"You entered {userInput}, which is not a valid entry. Try again.");
    Console.ReadKey();
}

//methods
static string AskForClass()
{
    Console.WriteLine("Please select from the following classes. Or type \"class info\" for details about each class.");
    Console.WriteLine("Fighter");
    Console.WriteLine("Archer");
    Console.WriteLine("Mage");
    String userInput = Console.ReadLine();
    return userInput;
}


