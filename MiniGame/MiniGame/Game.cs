namespace MiniGame;

public class Game
{
    private static char[,] map;
    private static int playerX, playerY;
    private static int mapWidth, mapHeight;

    public Game(string filePath)
    {
        this.ReadMap(filePath);
    }

    /// <summary>
    /// Read.
    /// </summary>
    /// <param name="filename">Name of file.</param>
    public void ReadMap(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        mapWidth = lines.Length;
        mapHeight = lines[0].Length;
        map = new char[mapWidth, mapHeight];
        for (int i = 0; i < mapWidth; i++)
        {
            for (int j = 0; j < mapHeight; j++)
            {
                map[i, j] = lines[i][j];
            }
        }
    }

    private void InitializePlayer()
    {
        playerX = 1;
        playerY = 1;

        while (map[playerY, playerX] == '#')
        {
            playerX++;
            if (playerX >= mapHeight)
            {
                playerX = 1;
                playerY++;
            }
        }
    }

    public static void RunGame(char direction)
    {
        Console.Clear();

        while (true)
        {
            int newX = playerX, newY = playerY;

            char key = Console.ReadKey().KeyChar;
            switch (key)
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