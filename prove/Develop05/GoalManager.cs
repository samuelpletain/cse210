public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    while (true)
    {
      displayPlayerInfo();

      Console.WriteLine("Menu Options:");
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List goals");
      Console.WriteLine("  3. Save goals");
      Console.WriteLine("  4. Load goals");
      Console.WriteLine("  5. Record Event");
      Console.WriteLine("  6. Quit");
      Console.Write("Select a choice from the menu: ");
      string input = Console.ReadLine();
      if (input == "1")
      {
        CreateGoal();
      }
      else if (input == "2")
      {
        ListGoalDetails();
      }
      else if (input == "3")
      {
        SaveGoals();
      }
      else if (input == "4")
      {
        LoadGoals();
      }
      else if (input == "5")
      {
        RecordEvent();
      }
      else if (input == "6")
      {
        break;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input");
        Console.ResetColor();
      }
    }
  }

  public void displayPlayerInfo()
  {
    Console.WriteLine();
    Console.WriteLine($"Score: {_score}");
    Console.WriteLine();
  }

  public void ListGoalNames()
  {
    for(int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"  {i + 1}. {_goals[i].GetShortName()}");
    }
  }

  public void ListGoalDetails()
  {
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{_goals[i].GetDetailsString()}");
    }
  }

  public void CreateGoal()
  {
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");

    Console.Write("Which type of goal would you like to create? ");
    string input = Console.ReadLine();
    if (input != "1" && input != "2" && input != "3")
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid input");
      Console.ResetColor();
      return;
    }


    Console.Write("What is the name of your goal? ");
    string shortName = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());

    if (input == "1")
    {
      _goals.Add(new SimpleGoal(shortName, description, points));
    }
    else if (input == "2")
    {
      _goals.Add(new EternalGoal(shortName, description, points));
    }
    else if (input == "3")
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      int target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for completing it that many times? ");
      int bonus = int.Parse(Console.ReadLine());
      _goals.Add(new CheckListGoal(shortName, description, points, target, bonus));
    }
  }

  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(fileName))
    {
      writer.WriteLine(_score);

      foreach (Goal goal in _goals)
      {
        writer.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();
    
    using (StreamReader reader = new StreamReader(fileName))
    {
      string line;
      line = reader.ReadLine();
      _score = int.Parse(line);
      while ((line = reader.ReadLine()) != null)
      {
        string[] parts = line.Split(':');
        if (parts[0] == "SimpleGoal")
        {
          string[] details = parts[1].Split('~');
          _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
        }
        else if (parts[0] == "CheckListGoal")
        {
          string[] details = parts[1].Split('~');
          CheckListGoal checkListGoal = new CheckListGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]));
          checkListGoal.setAmountCompleted(int.Parse(details[5]));
          _goals.Add(checkListGoal);
        }
        else if (parts[0] == "EternalGoal")
        {
          string[] details = parts[1].Split('~');
          _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
        }
      }
    }
  }

  public void RecordEvent()
  {
    Console.WriteLine("Select a goal to record an event for:");
    ListGoalNames();
    string input = Console.ReadLine();
    if (int.Parse(input) < 1 || int.Parse(input) > _goals.Count)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid goal");
      Console.ResetColor();
      return;
    }
    Goal goal = _goals[int.Parse(input) - 1];
    _score += goal.RecordEvent();
  }
}