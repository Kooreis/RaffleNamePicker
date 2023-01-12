```CSharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        string input = "";
        while (true)
        {
            Console.WriteLine("Enter a name (or 'draw' to pick a winner):");
            input = Console.ReadLine();
            if (input.ToLower() == "draw")
            {
                if (names.Count == 0)
                {
                    Console.WriteLine("No names entered yet.");
                    continue;
                }
                Random rand = new Random();
                int index = rand.Next(names.Count);
                Console.WriteLine("The winner is: " + names[index]);
                names.RemoveAt(index);
            }
            else
            {
                names.Add(input);
            }
        }
    }
}
```