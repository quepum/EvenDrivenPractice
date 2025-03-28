namespace MiniGame;

public class Game
{
    private static char[,] map;
    private static int playerX, playerY;
    private static int mapWidth, mapHeight;
    
    public Game(string filePath) {
        ReadMap(filePath);
        FindPlayerPosition();
    }
    
      /// <summary>
      /// Read.
      /// </summary>
      /// <param name="filename">Name of file.</param>
      /// <returns>Array element of maze.</returns>
    public char[][] ReadMap(string filename)
      {
            string[] line = File.ReadAllLines(filename);
            char[][] maze = new char[line.Length][];
            for (int i = 0; i < line.Length; ++i)
            {
                  maze[i] = line[i].ToCharArray();
            }

            return maze;
      }

    public void RunGame(char direction)
    {
        Console.Clear();

        while (true)
        {
            int oldX = playerX, oldY = playerY;

            switch (direction)
            {
                case 'U':
                    if (playerX > 0 && map[playerY - 1, playerX] != '#')
                    {
                        playerY--;
                    }
                    break;

                case 'D':
                    if (playerX < mapWidth - 1 && map[playerY + 1, playerX] != '#')
                    {
                        playerY++;
                    }
                    break;

                case 'L':
                    if (playerX > 0 && map[playerY, playerX - 1] != '#')
                    {
                        playerX--;
                    }
                    break;

                case 'R':
                    if (playerX < mapHeight - 1 && map[playerY, playerX + 1] != '#')
                    {
                        playerX++;
                    }
                    break;
            }
            Console.SetCursorPosition(oldX, oldY);
            Console.Write(map[oldY, oldX]);
            
            Console.SetCursorPosition(playerX, playerY);
            Console.Write('@');
        }
    }

    static void FindPlayerPosition()
    {
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                if (map[x, y] == '@')
                {
                    playerX = x;
                    playerY = y;
                    return;
                }

                playerX = 1;
                playerY = 1;

                return;
            }
        }
    }

    public void Start()
    {
        DrawMap();

        Console.SetCursorPosition(playerX, playerY);
        Console.Write('@');
    }

    public void DrawMap()
    {
        Console.Clear();
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                Console.Write(map[y, x]);
            }

            Console.WriteLine();
        }
    }
}