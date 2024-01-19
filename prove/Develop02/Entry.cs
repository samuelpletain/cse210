using System;

public class Entry
{
  public string _entryText {get; set;} 
  public string _promptText {get; set;}
  public DateTime _date {get; set;}

  public void Display()
  {
    string formattedDate = _date.ToShortDateString();
    Console.WriteLine($"Date: {formattedDate} - Prompt : {_promptText}");
    Console.WriteLine($"{_entryText}");
  }
}