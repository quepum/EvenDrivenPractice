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
            int newX = playerX, newY = playerY;

            switch (direction)
            {
                case 'U':
                    newY--;
                    break;
                case 'D':
                    newY++;
                    break;
                case 'L':
                    newX--;
                    break;
                case 'R':
                    newX++;
                    break;
                default:
                    continue;
            } 
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