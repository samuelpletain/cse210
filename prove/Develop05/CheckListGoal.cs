public class CheckListGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
  {
    _amountCompleted = 0;
    _target = target;
    _bonus = bonus;
  }

  public void setAmountCompleted(int amountCompleted)
  {
    _amountCompleted = amountCompleted;
  }

  public override int RecordEvent()
  {
    _amountCompleted++;
    if (_amountCompleted == _target)
    {
      return GetPoints() + _bonus;
    } else if (_amountCompleted > _target)
    {
      Console.WriteLine("You have already completed this goal.");
      return 0;
    } else
    {
      return GetPoints();
    }
  }

  public override bool IsComplete()
  {
    return _amountCompleted == _target;
  }

  public override string GetStringRepresentation()
  {
    return $"CheckListGoal:{GetShortName()}~{GetDescription()}~{GetPoints()}~{_bonus}~{_target}~{_amountCompleted}";
  }

  public override string GetDetailsString()
  {
    string detailsString = base.GetDetailsString();
    return $"{detailsString} -- Currently Completed: {_amountCompleted}/{_target}";
  }
}