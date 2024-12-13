// See https://aka.ms/new-console-template for more information
String userInput;
String userClass = "";
String classDamageOrigin = "";
Console.WriteLine("Welcome to HelloWorld. We hope you enjoy your stay.");
// Until the userClass is set to a valid value, continue asking for the user to select a class
while (userClass != "Fighter" && userClass != "Archer" && userClass != "Mage")
{
    Console.WriteLine($"userClass = {userClass}");
    userInput = AskForClass();
    // check if input is valid, then set the user's selected class and where their damage comes from
    // TODO create an object for each class type (Fighter, Archer, and Mage)
    if ((userInput == "Fighter" || userInput == "Archer" || userInput == "Mage"))
    {
        userClass = userInput;
        switch (userClass)
        {
            case "Fighter":
                classDamageOrigin = "weapon";
                break;
            case "Archer":
                classDamageOrigin = "weapon";
                break;
            case "Mage":
                classDamageOrigin = "spell";
                break;
        }
        Console.WriteLine($"You have selected {userInput} as your character class");
    }
    else if (userInput == "class info")
    {
        Console.WriteLine("You have entered \"class info\"");
        Console.WriteLine("Fighter: Uses melee weapons such as swords, axes, and hammers. Cannot use ranged weapons or cast spells. High HP.");
        Console.WriteLine("Archer: Uses ranged weapons such as bows and crossbows. Cannot use melee weapons or cast spells. Medium HP.");
        Console.WriteLine("Mage: Uses staves. Can cast spells. Low HP.");
    }
    else
    {
        Console.WriteLine($"You entered \"{userInput}\", which is not a valid entry. Try again.");
    }
}
Console.WriteLine($"The next step in character creation is selecting your first {classDamageOrigin}.");
Console.ReadKey();



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


