// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MiniGame;

try
{
    const string filename = @"C:\Users\peche\source\repos\EvenDrivenPractice\MiniGame\MiniGame\file.txt";
    var game = new Game(filename);
    game.Start();
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}