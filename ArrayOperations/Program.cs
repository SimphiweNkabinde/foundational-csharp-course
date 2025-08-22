/* string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */


/* // Explore Clear() and Resize()
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

/* // Exercise - Discover Split() and Join()
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
} */


/* // Exercise - Complete a challenge to reverse words in a sentence
string pangram = "The quick brown fox jumps over the lazy dog";
string result = "";

foreach (string word in pangram.Split(" "))
{
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    result += string.Join("", wordArray) + " ";
}

Console.WriteLine(result); */


// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);
foreach (var orderID in orderIDs)
{
    Console.WriteLine($"{orderID}{(orderID.Length != 4 ? "\t- Error" : "")}");
}