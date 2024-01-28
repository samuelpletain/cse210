public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    SetName("Breathing");
    SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
  }

  public void Run()
  {
    DisplayStartingMessage();
    
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      Console.Write("Breathe in...");
      ShowCountDown(3);
      Console.Write("Now breathe out...");
      ShowCountDown(3);
      Console.WriteLine();
    }

    DisplayEndingMessage();
  }
}