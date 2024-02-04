public class FiveSensesActivity : Activity 
{
  private List<string> _senses;

  public FiveSensesActivity() {
    SetName("Five Senses");
    SetDescription("This activity will help you focus on your five senses to help you relax and clear your mind. This will help you become more present and aware of your surroundings.");
    _senses = new List<string>(){
      "see",
      "feel",
      "hear",
      "smell",
      "taste"
    };
  }

  public void Run() {
    DisplayStartingMessage();

    int activityDuration = GetDuration();

    if (activityDuration < 50) {
      Console.WriteLine("This activity is designed to be at least 50 seconds long. Taking you back to the main menu.");
      ShowCountDown(5);
      return;
    }

    int senseDuration = GetDuration() / _senses.Count;

    for (int i = 0; i < _senses.Count; i++) {
      DisplayPrompt(_senses[i], _senses.Count - i, senseDuration);
    }  

    DisplayEndingMessage();
  }

  public void DisplayPrompt(string sense, int numberOfThings, int duration) {
    Console.Write($"Notice { numberOfThings } things that you can { sense }. ");
    ShowCountDown(duration);
    Console.WriteLine();
  }
}