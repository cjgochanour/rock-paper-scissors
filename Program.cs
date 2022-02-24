using System;
using System.Collections.Generic;

int PlayerScore = 0;
int ComputerScore = 0;

Console.WriteLine(@$"-----------------------------
| Player: {PlayerScore}  |  Computer: {ComputerScore} |
-----------------------------");

Console.WriteLine("What would you like to throw?");
Console.WriteLine("1) Rock");
Console.WriteLine("2) Paper");
Console.WriteLine("3) Scissors");

int PlayerChoice = int.Parse (Console.ReadLine()) - 1;

List<string> Throws = new List<string>() {
    @"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)",
@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)",
@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)"
};

Console.WriteLine($"{Throws[PlayerChoice]}");