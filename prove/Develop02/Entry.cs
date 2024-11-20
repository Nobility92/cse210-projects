public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
}
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Question: {_promptText} Response: {_entryText}");
    }

    public string ToFile(){
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }
}