public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int videoLength, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = videoLength;
        _comments = comments;
    }
    
    public int GetNumberOfComments()
    {
        //Count total number of comments:
        return _comments.Count();
    }
}