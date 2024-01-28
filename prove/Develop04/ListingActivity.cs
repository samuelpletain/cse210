public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>();

  public ListingActivity()
  {
  }

  public void Run()
  {
    DisplayStartingMessage();

    

    DisplayEndingMessage();
  }

  public void GetRandomPrompt()
  {
    
  }

  public List<string> GetListFromUser()
  {
    return new List<string>();
  }
}