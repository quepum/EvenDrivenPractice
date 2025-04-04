namespace WinFormsMiniGame;

public partial class Form1 : Form
{
    private char[,] map;
    private int playerX;
    private int playerY;
    private float cellSize;
    private Bitmap shrekImage;
    
    private int moveSpeed = 1;

    public Form1(string filePath)
    {
        InitializeComponent();
        ReadMap(filePath);
        playerX = 1;
        playerY = 1;
        
        shrekImage = new Bitmap(@"C:\Users\ASUS\RiderProjects\EvenDrivenPractice\MiniGame\WinFormsMiniGame\20.png");
        
        this.KeyDown += GameForm_KeyDown;
        this.KeyPreview = true;
        this.Resize += GameForm_Resize;

        button4.Click += (s, e) => MovePlayer(ConsoleKey.UpArrow);
        button1.Click += (s, e) => MovePlayer(ConsoleKey.LeftArrow);
        button2.Click += (s, e) => MovePlayer(ConsoleKey.DownArrow);
        button3.Click += (s, e) => MovePlayer(ConsoleKey.RightArrow);

        CalculateCellSize();
    }

    private void ReadMap(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        int height = lines.Length;
        int width = lines[0].Length;

        this.map = new char[height, width];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                this.map[y, x] = lines[y][x];
            }
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;

        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                var cellRect = new Rectangle((int)(x * cellSize), (int)(y * cellSize), (int)cellSize + 1,
                    (int)cellSize + 1);

                if (map[y, x] == '#')
                {
                    g.FillRectangle(Brushes.Red, cellRect);
                }
            }
        }

        var playerRect = new Rectangle((int)(playerX * cellSize), (int)(playerY * cellSize ), (int)cellSize,
            (int)cellSize);
        g.DrawImage(shrekImage, playerRect);
    }

    private void MovePlayer(ConsoleKey key)
    {
        int newX = playerX;
        int newY = playerY;

        switch (key)
        {
            case ConsoleKey.UpArrow: newY--; break;
            case ConsoleKey.DownArrow: newY++; break;
            case ConsoleKey.LeftArrow: newX--; break;
            case ConsoleKey.RightArrow: newX++; break;
        }

        if (IsValidPosition(newX, newY))
        {
            playerX = newX;
            playerY = newY;
            this.Invalidate();
        }
    }

    private void CalculateCellSize()
    {
        int mapWidth = map.GetLength(1);
        int mapHeight = map.GetLength(0);

        float widthRatio = (float)this.ClientSize.Width / mapWidth;
        float heightRatio = (float)this.ClientSize.Height / mapHeight;

        cellSize = Math.Min(widthRatio, heightRatio);
    }

    private bool IsValidPosition(int x, int y)
    {
        return x >= 0 && x < map.GetLength(1) && y >= 0 && y < map.GetLength(0) && map[y, x] != '#';
    }

    private void GameForm_KeyDown(object sender, KeyEventArgs e)
    {
        MovePlayer((ConsoleKey)e.KeyCode);
    }

    private void GameForm_Resize(object sender, EventArgs e)
    {
        CalculateCellSize();
        this.Invalidate();
    }
}