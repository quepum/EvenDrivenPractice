namespace MiniGame;

public class EventLoop
{
    private readonly Game game;

    public EventLoop(Game game)
    {
        this.game = game;
    }

    public void Run()
    {
        while (true)
        {
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    this.game.RunGame('L');
                    break;
                case ConsoleKey.RightArrow:
                    this.game.RunGame('R');
                    break;
                case ConsoleKey.UpArrow:
                    this.game.RunGame('U');
                    break;
                case ConsoleKey.DownArrow:
                    this.game.RunGame('D');
                    break;
                case ConsoleKey.Escape:
                    return;
            }
        }
    }
}