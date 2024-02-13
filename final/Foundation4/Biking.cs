public class Biking : Activity
{
  private double _speed;

  public Biking(int minutes, DateOnly date, double speed) : base(minutes, date)
  {
    _speed = speed;
    SetActivityType("Biking");
  }

  public override double GetSpeed()
  {
    return _speed;
  }
}