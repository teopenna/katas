namespace ChristmasLights.App;

public class LightService
{
  private readonly Lights _christmasLights;

  public LightService()
  {
    _christmasLights = new Lights();

    _christmasLights.ChangeLightStatus(887, 959, 9, 629, true);
    _christmasLights.ChangeLightStatus(454, 844, 398, 448, true);
  }
}
