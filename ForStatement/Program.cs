﻿for (int i = 1; i <= 100; i++)
{
    Console.Write(i);

    bool divisibleBy3 = i % 3 == 0;
    bool divisibleBy5 = i % 5 == 0;

    if (divisibleBy3 && divisibleBy5)
        Console.WriteLine(" - FizzBuzz");
    else if (divisibleBy3)
        Console.WriteLine(" - Fizz");
    else if (divisibleBy5)
        Console.WriteLine(" - Buzz");
    else
        Console.WriteLine("");
}