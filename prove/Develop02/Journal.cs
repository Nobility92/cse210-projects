using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry Added");
    }

    public void DisplayAll()
    {
        if(_entries.Count == 0)
        {
            Console.WriteLine("Your Journal is Empty");
            return;
        }
            Console.WriteLine("Your Journal Entries");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFile());
            }
             Console.WriteLine("Journal is Saved");
        }
       
        
    }

    public void LoadFromFile(string file)
    {
        
    }
}