namespace BowlingGame.Tests;

public class GameTest
{
    private readonly Game game;

    public GameTest()
    {
        game = new Game();
    }

    private void MultipleRolls(int rolls, int pins)
    {
        for (int i = 0; i < rolls; i++)
        {
            game.Roll(pins);
        }
    }

    [Fact]
    public void Game_Class_Should_Exists()
    {
        Assert.IsType<Game>(game);
    }

    [Fact]
    public void Gutter_Game_Should_Returns_Score_Zero()
    {
        MultipleRolls(20, 0);
        var expectedScore = 0;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void All_Ones_Should_Returns_Score_Twenty()
    {
        MultipleRolls(20, 1);
        var expectedScore = 20;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void One_Spare_Should_Return_Correct_Score()
    {
        game.Roll(5);
        game.Roll(5);
        game.Roll(3);
        MultipleRolls(17, 0);
        var expectedScore = 16;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void One_Strike_Should_Return_Correct_Score()
    {
        game.Roll(5);
        game.Roll(5);
        game.Roll(10);
        game.Roll(3);
        game.Roll(3);
        MultipleRolls(14, 0);
        var expectedScore = 42;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void Tenth_Frame_Spare_Test()
    {
        game.Roll(5);
        game.Roll(5);
        game.Roll(10);
        game.Roll(3);
        game.Roll(3);
        MultipleRolls(12, 0);
        game.Roll(4);
        game.Roll(6);
        game.Roll(5);
        var expectedScore = 57;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void Tenth_Frame_Spare_Test2()
    {
        game.Roll(5);
        game.Roll(5);
        game.Roll(4);
        game.Roll(3);
        game.Roll(3);
        game.Roll(3);
        MultipleRolls(12, 0);
        game.Roll(4);
        game.Roll(6);
        game.Roll(5);
        var expectedScore = 42;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void Tenth_Frame_Strike_Test()
    {
        game.Roll(5);
        game.Roll(5);
        game.Roll(4);
        game.Roll(3);
        game.Roll(3);
        game.Roll(3);
        MultipleRolls(12, 0);
        game.Roll(10);
        game.Roll(6);
        var expectedScore = 43;
        Assert.Equal(expectedScore, game.Score());
    }

    [Fact]
    public void Tenth_Frame_Spare_Test3()
    {
        game.Roll(5);
        game.Roll(5);
        game.Roll(4);
        game.Roll(3);
        game.Roll(3);
        game.Roll(3);
        MultipleRolls(12, 0);
        game.Roll(4);
        game.Roll(6);
        game.Roll(6);
        var expectedScore = 43;
        Assert.Equal(expectedScore, game.Score());
    }
}