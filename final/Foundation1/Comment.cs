public class Comment
{
  private string _author;
  private string _content;

  public Comment(string author, string content)
  {
    _author = author;
    _content = content;
  }

  public void DisplayComment()
  {
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Content: {_content}");
    Console.WriteLine();
  }
}