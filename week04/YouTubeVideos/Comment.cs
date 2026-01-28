public class Comment
{
    private string _nameOfPerson;
    private string _commentText;

    public Comment(string nameOfPerson, string comment)
    {
        _nameOfPerson = nameOfPerson;
        _commentText = comment;
    }

    public string GetName()
    {
        return _nameOfPerson;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}