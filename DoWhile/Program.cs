/* //Code Project 1
bool validNumber = false;
int inputValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

while (!validNumber)
{
    string input = Console.ReadLine();
    bool isInteger = int.TryParse(input, out inputValue);

    if (!isInteger)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }

    if (inputValue <= 5 || inputValue >= 10)
        Console.WriteLine($"You entered {inputValue}. Please enter a number between 5 and 10.");
    else
        validNumber = true;
}

Console.WriteLine($"Your input value ({inputValue}) has been accepted."); */


/* // Code Project 2
string input;
bool validRoleName = false;

do
{

    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    input = Console.ReadLine();

    if (input.Trim().ToLower() == "administrator" || input.Trim().ToLower() == "manager" || input.Trim().ToLower() == "user")
        validRoleName = true;
    else
        Console.Write($"The role name that you entered, \"{input}\" is not valid. ");

} while (!validRoleName);

Console.WriteLine($"Your input value ({input}) has been accepted."); */


// Code Project 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}