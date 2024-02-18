public abstract class Activity
{
  private int _minutes;
  private DateOnly _date;
  private string _activityType;

  public Activity(int minutes, DateOnly date)
  {
    _minutes = minutes;
    _date = date;
    _activityType = "Activity";
  }

  public void SetActivityType(string activityType)
  {
    _activityType = activityType;
  }

  public int GetMinutes()
  {
    return _minutes;
  }

  public DateOnly GetDate()
  {
    return _date;
  }

  public string GetActivityType()
  {
    return _activityType;
  } 

  public virtual double GetDistance(){
    return GetSpeed() / 60 * GetMinutes();
  }

  public virtual double GetSpeed()
  {
    return GetDistance() / GetMinutes() * 60;
  }

  public virtual double GetPace()
  {
    return GetMinutes() / GetDistance();
  }

  public string GetSummary()
  {
    return $"{GetDate():dd MMM yyyy} {GetActivityType()} ({GetMinutes()} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
  } 
}