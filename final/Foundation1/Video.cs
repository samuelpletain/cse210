public class Video
{
  private string _title;
  private string _author;
  private int _length;
  List<Comment> _comments;

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    _comments = new List<Comment>();
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }

  public int GetNumberOfComments()
  {
    return _comments.Count;
  }

  public void DisplayMetadata()
  {
    Console.WriteLine($"Title: {_title} - Author: {_author} - Length: {_length}");
    Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
    Console.WriteLine();
  }

  public void DisplayComments()
  {
    foreach (Comment comment in _comments)
    {
      comment.DisplayComment();
    }
  }
}