public class Reception : Event
{
  private string _email;

  public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
  {
    _email = email;
    SetEventType("Reception");
  }

  public override string GetFullDetails()
  {
    return $"{GetStandardDetails()}\n{GetEventType()}\nRSVP at: {_email}";
  }
}