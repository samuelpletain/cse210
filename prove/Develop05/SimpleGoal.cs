public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
  {
    _isComplete = false;
  }

  public void setIsComplete(bool isComplete)
  {
    _isComplete = isComplete;
  }

  public override int RecordEvent()
  {
    if (_isComplete)
    {
      Console.WriteLine("You have already completed this goal.");
      return 0;
    }

    _isComplete = true;
    return GetPoints();
  }

  public override bool IsComplete()
  {
    return _isComplete;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{GetShortName()}~{GetDescription()}~{GetPoints()}~{IsComplete()}";
  }
}