public class ListingActivity : Activity
{
  private int _count = 0;
  private List<string> _prompts;

  public ListingActivity()
  {
    SetName("Listing");
    SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    _prompts = new List<string>(){
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine("List as many responses as you can to the following prompt:");
    GetRandomPrompt();

    Console.Write("You may begin in: ");
    ShowCountDown(5);

    List<string> responses = GetListFromUser();
    
    _count = responses.Count;

    if (_count == 0)
    {
      Console.WriteLine("You didn't list anything!");
    }
    else if (_count == 1)
    {
      Console.WriteLine("You listed 1 item!");
    }
    else
    {
      Console.WriteLine($"You listed {_count} items!");
    }

    Console.WriteLine();

    _count = 0;

    DisplayEndingMessage();
  }

  public void GetRandomPrompt()
  {
    int index = new Random().Next(_prompts.Count);
    Console.WriteLine($" --- {_prompts[index]} ---");
  }

  public List<string> GetListFromUser()
  {
    List<string> responses = new List<string>();
    
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string input = Console.ReadLine();

      if (input != "")
      {
        responses.Add(input);
      }
    }

    return responses;
  }
}