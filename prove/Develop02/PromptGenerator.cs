public class PromptGenerator
{
  List<string> _prompts = new List<string>{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What is the most important thing I learned today?",
    "How did I express love and kindness today?",
    "What was the most challenging part of my day?",
    "What is one thing I can do tomorrow to make it better than today?",
    "What is one thing I did today that I am proud of?",
  };

  public string GetRandomPrompt()
  {
    Random random = new Random();
    int randomIndex = random.Next(0, _prompts.Count);
    return _prompts[randomIndex];
  }
}