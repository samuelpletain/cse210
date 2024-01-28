public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity()
  {
  }

  public void SetName(string name)
  {
    _name = name;
  }

  public void SetDescription(string description)
  {
    _description = description;
  }

  public int GetDuration()
  {
    return _duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity.");
    Console.WriteLine();

    Console.WriteLine(_description);
    Console.WriteLine();

    Console.Write("How long, in seconds, would you like for you session to last? ");
    _duration = int.Parse(Console.ReadLine());

    Console.Clear();
    
    Console.WriteLine("Get ready...");
    ShowSpinner(5);
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine($"Well done!!");
    ShowSpinner(5);

    Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    ShowSpinner(5);
  }

  public void ShowSpinner(int seconds)
  {
    for (int i = 0; i < seconds; i++)
    {
      Console.Write("\b\\");
      Thread.Sleep(250);

      Console.Write("\b|");
      Thread.Sleep(250);

      Console.Write("\b/");
      Thread.Sleep(250);

      Console.Write("\b-");
      Thread.Sleep(250);
    }
    Console.WriteLine("\b ");
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write($"{i}");
      Thread.Sleep(1000);
      Console.Write("\b");
    }
    Console.WriteLine(" ");
  }
}