public class Running : Activity
{
  private double _distance;

  public Running(int minutes, DateOnly date, double distance) : base(minutes, date)
  {
    _distance = distance;
    SetActivityType("Running");
  }

  public override double GetDistance()
  {
    return _distance;
  }
}