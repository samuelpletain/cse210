using System.Text.Json;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      entry.Display();
      Console.WriteLine();
    }
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter writer = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine(entry._date);
        writer.WriteLine(entry._promptText);
        writer.WriteLine(entry._entryText);
        writer.WriteLine();
      }
    }
  }

  public void SaveToJSON(string file)
  {
    string json = JsonSerializer.Serialize(_entries);
    File.WriteAllText(file, json);
  }

  public void LoadFromFile(string file)
  {
    _entries.Clear();

    using (StreamReader reader = new StreamReader(file))
    {
      while (!reader.EndOfStream)
      {
        string dateText = reader.ReadLine();
        string promptText = reader.ReadLine();
        string entryText = reader.ReadLine();

        DateTime date = DateTime.Parse(dateText);
        
        Entry entry = new Entry
        {
            _date = date,
            _promptText = promptText,
            _entryText = entryText
        };

        _entries.Add(entry);
      }
    }
  }

  public void LoadFromJSON(string file)
  {
    using (StreamReader r = new StreamReader(file))
        {
            string json = r.ReadToEnd();
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
  }
}