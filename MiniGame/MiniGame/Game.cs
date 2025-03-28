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
}