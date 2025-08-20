Random coinFlip = new Random();
int result = coinFlip.Next(0, 2);

Console.WriteLine($"{(result == 0 ? "head" : "tails")}");