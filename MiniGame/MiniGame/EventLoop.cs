// <copyright file="EventLoop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MiniGame;

/// <summary>
/// Handling keystrokes in a console application.
/// </summary>
public static class EventLoop
{
    /// <summary>
    /// Processing keystrokes.
    /// </summary>
    /// <param name="onKeyPress">The pressed key.</param>
    public static void Run(Action<ConsoleKey> onKeyPress)
    {
        while (true)
        {
            var key = Console.ReadKey(intercept: true);
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }

            onKeyPress(key.Key);
        }
    }
}