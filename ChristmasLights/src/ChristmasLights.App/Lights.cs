namespace ChristmasLights.App;

public class Lights
{
    private readonly Light[,] _lightChain = new Light[1000, 1000];

    public Lights()
    {
        for (var i = 0; i < _lightChain.GetLength(0); i++)
        {
            for (var j = 0; j < _lightChain.GetLength(1); j++)
            {
                _lightChain[i, j] = new Light();
            }
        }
    }

    public int TurnedOnLights()
    {
        var turnedOnLights = from Light light in _lightChain where light.Status select light;

        return turnedOnLights.Count();
    }

    public long GetTotalBrightness()
    {
        var totB = from Light light in _lightChain select light.Brightness;
        return totB.Sum();
    }

    public void ChangeLightStatus(int x1, int y1, int x2, int y2, bool status)
    {
        for (var i = x1; i < x2 + 1; i++)
        {
            for (var j = y1; j < y2 + 1; j++)
            {
                _lightChain[i, j].Status = status;
            }
        }
    }

    public void ChangeLightBrightness(int x1, int y1, int x2, int y2, bool status)
    {
        for (var i = x1; i < x2 + 1; i++)
        {
            for (var j = y1; j < y2 + 1; j++)
            {
                if (status)
                {
                    _lightChain[i, j].IncreaseBrightness();
                }
                else
                {
                    _lightChain[i, j].DecreaseBrightness();
                }
            }
        }
    }

    public void ToggleLightStatus(int x1, int y1, int x2, int y2)
    {
        for (var i = x1; i < x2 + 1; i++)
        {
            for (var j = y1; j < y2 + 1; j++)
            {
                _lightChain[i, j].Status = !_lightChain[i, j].Status;
            }
        }
    }

    public void ToggleLightBrightness(int x1, int y1, int x2, int y2)
    {
        for (var i = x1; i < x2 + 1; i++)
        {
            for (var j = y1; j < y2 + 1; j++)
            {
                _lightChain[i, j].DoubleIncreaseBrightness();
            }
        }
    }
}
