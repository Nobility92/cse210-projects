public class Videos
{
    public string _vidTitle;
    public string _vidAuthor;
    public int _vidLengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public Videos(string title, string author, int lengthInSeconds)
    {
        _vidTitle = title;
        _vidAuthor = author;
        _vidLengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public  override string ToString()
    {
        return $"Title: {_vidTitle} Author: {_vidAuthor} Length: {_vidLengthInSeconds} seconds Number of comments: {GetNumberOfComments()}";
    }
}