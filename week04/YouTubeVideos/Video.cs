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
    
    public void GetVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length(in seconds): {_lengthInSeconds}");
        Console.WriteLine($"Comments ({GetNumberOfComments()} comments):");

        foreach (Comment c in _comments)
        {
            Console.WriteLine($"{c.GetName()} commented: ");
            Console.WriteLine($"{c.GetCommentText()}");
            Console.WriteLine();
        }
        
    }
}