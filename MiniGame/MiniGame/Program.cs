// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MiniGame;

try
{
    const string filePath = @"C:\Users\Алина\RiderProjects\EvenDrivenPractice\MiniGame\MiniGame\file.txt";
    var game = new Game(filePath);
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