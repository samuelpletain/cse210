public class Scripture
{
  private Reference _reference;
  private List<Word> _words = new List<Word>();

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    List<string> wordsList = text.Split(' ').ToList();
    foreach (string word in wordsList)
    {
      _words.Add(new Word(word));
    }
  }

  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();
    for (int i = 0; i < numberToHide; i++)
    {
      if (isCompletelyHidden())
      {
        break;
      }
      int randomIndex = random.Next(0, _words.Count);
      if (_words[randomIndex].IsHidden())
      {
        i--;
        continue;
      }
      else {
        _words[randomIndex].Hide();
      }
    }
  }

  public string GetDisplayText()
  {
    string displayText = _reference.GetDisplayText() + " ";
    foreach (Word word in _words)
    {
      displayText += word.GetDisplayText() + " ";
    }
    return displayText;
  }

  public bool isCompletelyHidden()
  {
    foreach (Word word in _words)
    {
      if (!word.IsHidden())
      {
        return false;
      }
    }
    return true;
  }
}