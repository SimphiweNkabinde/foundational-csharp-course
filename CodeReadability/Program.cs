/*
    This code reverses message, counts the number of O's in the message
    and prints the results to the console window
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] messageCharacters = originalMessage.ToCharArray();
Array.Reverse(messageCharacters);

int letterCount = 0;

foreach (char character in messageCharacters)
{
    if (character == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(messageCharacters);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");