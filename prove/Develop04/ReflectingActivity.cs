public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>(){
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };
  private List<string> _questions = new List<string>(){
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  public ReflectingActivity()
  {
    SetName("Reflecting");
    SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
  }

  public void Run()
  {
    DisplayStartingMessage();

    DisplayPrompt();

    DisplayQuestions();

    DisplayEndingMessage();
  }

  public string getRandomPrompt()
  {
    int index = new Random().Next(_prompts.Count);
    return _prompts[index];
  }

  public string getRandomQuestion()
  {
    int index = new Random().Next(_questions.Count);
    return _questions[index];
  }

  public void DisplayPrompt()
  {
    string prompt = getRandomPrompt();
    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($" --- {prompt} ---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    string input = Console.ReadLine();
    if (input == "")
    {
      Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
      Console.Write("You may begin in: ");
      ShowCountDown(5);
      Console.Clear();
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid input. Please try again.");
      Console.ResetColor();
    }
  }

  public void DisplayQuestions()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      string question = getRandomQuestion();
      Console.Write($"> {question}  ");
      ShowSpinner(10);
    }
    Console.WriteLine("");
  }
}