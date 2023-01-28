namespace BowlingGame;

public class Game
{
    private readonly int[] _rolls = new int[21];
    private int _currentRoll;

    public void Roll(int knockedPins)
    {
        _rolls[_currentRoll++] = knockedPins;
    }

    public int Score()
    {
        var score = 0;
        var roll = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsSpare(roll))
            {
                score +=  10 + _rolls[roll + 2];
                roll += 2;
            }
            else if (IsStrike(roll))
            {
                score += 10 + _rolls[roll + 1] + _rolls[roll + 2];
                roll += 1;
            }
            else
            {
                score += _rolls[roll] + _rolls[roll + 1];
                roll += 2;
            }                  
        }

        return score;
    }

    private bool IsSpare(int roll)
    {
        return _rolls[roll] + _rolls[roll + 1] == 10;
    }

    private bool IsStrike(int roll)
    {
        return _rolls[roll] == 10;
    }
}