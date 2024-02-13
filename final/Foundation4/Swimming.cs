public class Swimming : Activity
{
  private int _laps;

  public Swimming(int minutes, DateOnly date, int laps) : base(minutes, date)
  {
    _laps = laps;
    SetActivityType("Swimming");
  }

  public override double GetDistance()
  {
    return _laps * 50 / 1000;
  }
}