

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}