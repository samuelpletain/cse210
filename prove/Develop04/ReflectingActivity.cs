public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>();
  private List<string> _questions = new List<string>();

  public ReflectingActivity(string name, string description, string duration, List<String> prompts, List<string> questions) : base(name, description, duration)
  {
    _prompts = prompts;
    _questions = questions;
  }

  public void Run()
  {

  }

  public string getRandomPrompt()
  {
    return "";
  }

  public string getRandomQuestion()
  {
    return "";
  }

  public void DisplayPrompt()
  {

  }

  public void DisplayQuestions()
  {
    
  }
}