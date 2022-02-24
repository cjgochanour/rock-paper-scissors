using System;

int PlayerScore = 0;
int ComputerScore = 0;

Console.WriteLine("-----------------------------");
Console.WriteLine($"| Player: {PlayerScore}  |  Computer: {ComputerScore} |");
Console.WriteLine("-----------------------------");

Console.WriteLine("What would you like to throw?");
Console.WriteLine("1) Rock");
Console.WriteLine("2) Paper");
Console.WriteLine("3) Scissors");

int PlayerChoice = int.Parse (Console.ReadLine());

Console.WriteLine($"You chose number {PlayerChoice}");