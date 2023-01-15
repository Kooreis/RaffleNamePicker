# Python Documentation

# Raffle Name Picker

This Python script is a simple raffle name picker. It allows users to add participants to a raffle and then randomly selects a winner from the list of participants. The script continues to run until the user chooses to exit.

## How it works

The script presents the user with three options:

1. Add participant
2. Pick a winner
3. Exit

The user can add as many participants as they want. When the user chooses to pick a winner, the script randomly selects a name from the list of participants. If no participants have been added, the script informs the user that no participants have been added yet. The script continues to run until the user chooses to exit.

## Imported Libraries

### random

The `random` library is a built-in Python library that implements pseudo-random number generators for various distributions. In this script, it is used to randomly select a winner from the list of participants. The `random.choice()` function returns a random element from the non-empty sequence that we pass to it. In this case, the sequence is the list of participants.

## Usage

To use this script, simply run it in your Python environment. You will be presented with the three options. Enter '1' to add a participant, '2' to pick a winner, or '3' to exit the script. If you choose to add a participant, you will be prompted to enter the participant's name. If you choose to pick a winner, the script will either print the name of the winner or inform you that no participants have been added yet, depending on whether any participants have been added.

---

# C# Documentation

# CSharp Random Name Picker

This is a simple console application written in CSharp that allows users to enter names into a list and randomly pick a winner from the list.

## Script Explanation

The script starts by creating an empty list of strings to store the names. It then enters an infinite loop where it prompts the user to enter a name or the word 'draw'. If the user enters a name, it is added to the list. If the user enters 'draw', the script checks if there are any names in the list. If the list is empty, it informs the user and continues to the next iteration of the loop. If there are names in the list, it randomly selects a name, announces it as the winner, and removes it from the list.

## Imported Libraries

The script imports two libraries:

- `System`: This is a fundamental library in CSharp that provides classes for handling primitive types, dates, math operations, console I/O, and other basic functionality. In this script, it is used for console input/output and generating random numbers.

- `System.Collections.Generic`: This library provides classes for handling collections of objects. In this script, it is used for the `List<string>` class, which represents a dynamically-sized array of strings.

## Code

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

This script is a fun and simple way to randomly select a winner from a list of names. It could be used in a variety of contexts, such as a raffle or a game.

---

# Java Documentation

# Raffle Name Picker

This is a simple Java program that picks a random name from a list of names. The names are inputted by the user and the program continues to accept names until the user types 'end'. Once 'end' is typed, the program randomly selects a name from the list and prints it out as the winner.

## Imported Libraries

The following libraries are imported in this script:

- `java.util.ArrayList`: This library is used to create a dynamic array that can hold the names inputted by the user. The ArrayList class gives us methods like add(), remove(), and size() that are used in this script.

- `java.util.Random`: This library is used to generate a random integer which is used as an index to pick a random name from the ArrayList of names.

- `java.util.Scanner`: This library is used to read the user's input. In this script, it's used to read the names inputted by the user and the 'end' command to stop the input process.

## Code Explanation

The script starts by creating an ArrayList to hold the names and a Scanner to read the user's input. It then enters a loop where it continually asks the user to input a name or type 'end' to finish. If the input is not 'end', it adds the input to the ArrayList of names. If the input is 'end', it breaks the loop.

After the loop, it creates a Random object and uses it to generate a random index within the range of the ArrayList's size. It then uses this index to get a random name from the ArrayList and prints it out as the winner.

---
