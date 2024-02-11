public class Reception : Event
{
  private string _email;

  public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
  {
    _email = email;
  }

  public string GetFullDetails()
  {
    return $"{GetStandardDetails()}\nReception\nRSVP at: {_email}";
  }

  public new string GetShortDescription()
  {
    return $"Reception - {base.GetShortDescription()}";
  }
}