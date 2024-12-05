public class Comment
{
    public string commenterName;
    public string commenterText;

    public Comment(string name, string text)
    {
        commenterName = name;
        commenterText = text;
    }

    public override string ToString()
    {
        return $"Comment by {commenterName}: {commenterText}";
    }
}