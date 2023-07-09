using ChristmasLights.App;

namespace ChristmasLights.Tests;

public class LightTests
{
    [Fact]
    public void TestStep1()
    {
        var christmasLights = new Lights();

        christmasLights.ChangeLightStatus(887, 9, 959, 629, true);
        christmasLights.ChangeLightStatus(454, 398, 844, 448, true);
        christmasLights.ChangeLightStatus(539, 243, 559, 965, false);
        christmasLights.ChangeLightStatus(370, 819, 676, 868, false);
        christmasLights.ChangeLightStatus(145, 40, 370, 997, false);
        christmasLights.ChangeLightStatus(301, 3, 808, 453, false);
        christmasLights.ChangeLightStatus(351, 678, 951, 908, true);
        christmasLights.ToggleLightStatus(720, 196, 897, 994);
        christmasLights.ToggleLightStatus(831, 394, 904, 860);

        var turnedOnLights = christmasLights.TurnedOnLights();

        Assert.Equal(230022, turnedOnLights);
    }

    [Fact]
    public void TestStep2()
    {
        var christmasLights = new Lights();

        christmasLights.ChangeLightBrightness(887, 9, 959, 629, true);
        christmasLights.ChangeLightBrightness(454, 398, 844, 448, true);
        christmasLights.ChangeLightBrightness(539, 243, 559, 965, false);
        christmasLights.ChangeLightBrightness(370, 819, 676, 868, false);
        christmasLights.ChangeLightBrightness(145, 40, 370, 997, false);
        christmasLights.ChangeLightBrightness(301, 3, 808, 453, false);
        christmasLights.ChangeLightBrightness(351, 678, 951, 908, true);
        christmasLights.ToggleLightBrightness(720, 196, 897, 994);
        christmasLights.ToggleLightBrightness(831, 394, 904, 860);

        var totalBrightness = christmasLights.GetTotalBrightness();

        Assert.Equal(539560, totalBrightness);
    }
}
