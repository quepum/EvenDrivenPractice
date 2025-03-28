namespace MiniGame;

public class Game
{
      /// <summary>
      /// Read.
      /// </summary>
      /// <param name="filename">Name of file.</param>
      /// <returns>Array element of maze.</returns>
      public char[][] Read(string filename)
      {
            string[] line = File.ReadAllLines(filename);
            char[][] maze = new char[line.Length][];
            for (int i = 0; i < line.Length; ++i)
            {
                  maze[i] = line[i].ToCharArray();
            }

            return maze;
      }
    private static char[,] map;
    private static int playerX, playerY;
    private static int mapWidth, mapHeight;
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
            
            //вызов делегата для обработки движения 
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
}