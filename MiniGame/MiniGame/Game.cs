// <copyright file="Game.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MiniGame;

/// <summary>
/// Implementation of game logic.
/// </summary>
public class Game
{
    private char[,] map;
    private int playerX;
    private int playerY;
    private int width;
    private int height;

    /// <summary>
    /// Initializes a new instance of the <see cref="Game"/> class.
    /// </summary>
    /// <param name="mapFilePath">Input file path.</param>
    public Game(string mapFilePath)
    {
        this.ReadMap(mapFilePath);
        this.playerX = 1;
        this.playerY = 1;
    }

    /// <summary>
    /// Start game.
    /// </summary>
    public void Start()
    {
        this.DrawMap();
        this.PlacePlayer();

        EventLoop.Run(key =>
        {
            int newX = this.playerX;
            int newY = this.playerY;

            switch (key)
            {
                case ConsoleKey.UpArrow: newY--; break; // Вверх
                case ConsoleKey.DownArrow: newY++; break; // Вниз
                case ConsoleKey.LeftArrow: newX--; break; // Влево
                case ConsoleKey.RightArrow: newX++; break;
            }

            if (this.IsValidPosition(newX, newY))
            {
                this.ClearPlayer();
                this.playerX = newX;
                this.playerY = newY;
                this.PlacePlayer();
            }
        });
    }

    /// <summary>
    /// Return current map.
    /// </summary>
    /// <returns>Map.</returns>
    public char[,] GetMap() => this.map;

    /// <summary>
    /// Checks whether the specified position is acceptable for the player to move.
    /// </summary>
    /// <param name="x">The first coordinate of the position.</param>
    /// <param name="y">The second coordinate of the position.</param>
    /// <returns><c>true</c> if the position is within the map and is not a wall ('#').
    /// Otherwise, returns <c>false</c>.</returns>
    public bool IsValidPosition(int x, int y)
    {
        return x >= 0 && x < this.width && y >= 0 && y < this.height && this.map[y, x] != '#';
    }

    private void DrawMap()
    {
        Console.WriteLine();
        Console.Clear();
        for (int y = 0; y < this.height; y++)
        {
            for (int x = 0; x < this.width; x++)
            {
                Console.Write(this.map[y, x]);
            }

            Console.WriteLine();
        }
    }

    private void PlacePlayer()
    {
        Console.SetCursorPosition(this.playerX, this.playerY);
        Console.Write('@');
    }

    private void ClearPlayer()
    {
        Console.SetCursorPosition(this.playerX, this.playerY);
        Console.Write(' ');
    }

    private void ReadMap(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        this.height = lines.Length;
        this.width = lines[0].Length;

        this.map = new char[this.height, this.width];
        for (int y = 0; y < this.height; y++)
        {
            for (int x = 0; x < this.width; x++)
            {
                this.map[y, x] = lines[y][x];
            }
        }
    }
}