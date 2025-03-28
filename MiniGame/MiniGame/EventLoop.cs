namespace MiniGame;

public class EventLoop
{
    private readonly Game game;

    public EventLoop(Game game)
    {
        game = game;
    }

    public void Run()
    {
        while (true)
        {
            var key = Console.ReadKey();
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    game.RunGame('L');
                    break;
                case ConsoleKey.RightArrow:
                    game.RunGame('R');
                    break;
                case ConsoleKey.UpArrow:
                    game.RunGame('U');
                    break;
                case ConsoleKey.DownArrow:
                    game.RunGame('D');
                    break;
                case ConsoleKey.Escape:
                    return;
            }
        }
    }
}