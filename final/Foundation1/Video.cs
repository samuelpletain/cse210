public class Video
{
  private string title;
  private string author;
  private int length;
  List<Comment> comments;

  public Video(string title, string author, int length)
  {
    this.title = title;
    this.author = author;
    this.length = length;
    comments = new List<Comment>();
  }

  public void AddComment(Comment comment)
  {
    comments.Add(comment);
  }

  public int GetNumberOfComments()
  {
    return comments.Count;
  }

  public void GetMetadata()
  {
    Console.WriteLine($"Title: {title} - Author: {author} - Length: {length}");
    Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
    Console.WriteLine();
  }

  public void DisplayComments()
  {
    foreach (Comment comment in comments)
    {
      comment.DisplayComment();
    }
  }
}