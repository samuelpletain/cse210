public abstract class Goal
{
  private string _shortName;
  private string _description;
  private int _points;

  public Goal(string shortName, string description, int points)
  {
    _shortName = shortName;
    _description = description;
    _points = points;
  }

  public string GetShortName()
  {
    return _shortName;
  }

  public string GetDescription()
  {
    return _description;
  }

  public int GetPoints()
  {
    return _points;
  }

  public void SetShortName(string shortName)
  {
    _shortName = shortName;
  }

  public void SetDescription(string description)
  {
    _description = description;
  }

  public void SetPoints(int points)
  {
    _points = points;
  }

  public abstract int RecordEvent();

  public abstract bool IsComplete();

  public string GetDetailsString(){
    string isComplete = IsComplete() ? "X" : " ";
    return $"[{isComplete}] {GetShortName()} ({GetDescription()})";
  }

  public abstract string GetStringRepresentation();
}