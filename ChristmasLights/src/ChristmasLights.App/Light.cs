namespace ChristmasLights.App;

public class Light
{
    public bool Status { get; set; }
    public int Brightness { get; private set; }

    public void IncreaseBrightness()
    {
        Brightness++;
    }

    public void DoubleIncreaseBrightness()
    {
        Brightness += 2;
    }

    public void DecreaseBrightness()
    {
        Brightness--;

        if (Brightness < 0)
        {
            Brightness = 0;
        }
    }
}
