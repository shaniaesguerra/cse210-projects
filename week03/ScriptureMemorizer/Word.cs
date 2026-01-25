public class Word
{
    private string _text;
    private bool _isHidden = false;

    //Constructor
    public Word(string text)
    {
        _text = text;
    }

    //Methods
    private void Hide()
    {

    }
    private void Show()
    {

    }
    private bool isHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return "";
    }
}