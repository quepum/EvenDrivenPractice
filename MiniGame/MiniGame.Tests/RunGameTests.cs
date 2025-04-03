namespace MiniGame.Tests;

public class Tests
{
    [Test]
    public void LoadMap_ValidFile_CorrectlyLoadsMap()
    {
        const string mapContent = """
                                  #####
                                  #   #
                                  #####
                                  """;
        string tempFilePath = Path.GetTempFileName();
        File.WriteAllText(tempFilePath, mapContent);

        try
        {
            var game = new Game(tempFilePath);
            char[,] map = game.GetMap();

            Assert.Multiple(() =>
            {
                Assert.That(map[0, 0], Is.EqualTo('#'));
                Assert.That(map[1, 1], Is.EqualTo(' '));
                Assert.That(map[2, 4], Is.EqualTo('#'));
            });
        }
        finally
        {
            File.Delete(tempFilePath);
        }
    }

    [Test]
    public void IsValidPosition_ValidAndInvalidPositions_ReturnsCorrectResult()
    {
        const string mapContent = """
                                  #####
                                  #   #
                                  #####
                                  """;
        string tempFilePath = Path.GetTempFileName();
        File.WriteAllText(tempFilePath, mapContent);

        try
        {
            var game = new Game(tempFilePath);

            Assert.Multiple(() =>
            {
                Assert.That(game.IsValidPosition(1, 1), Is.True);
                Assert.That(game.IsValidPosition(0, 0), Is.False); 
                Assert.That(game.IsValidPosition(-1, 1), Is.False); 
                Assert.That(game.IsValidPosition(5, 2), Is.False);
            });
        }
        finally
        {
            File.Delete(tempFilePath);
        }
    }
}