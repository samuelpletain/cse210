public class OutdoorGathering : Event
{
  private string _weather;

  public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
  {
    _weather = weather;
    SetEventType("Outdoor Gathering");
  }

  public string GetFullDetails()
  {
    return $"{GetStandardDetails()}\n{GetEventType()}\nThe weather will be {_weather}.";
  }

  public new string GetShortDescription()
  {
    return $"Outdoor Gathering - {base.GetShortDescription()}";
  }
}