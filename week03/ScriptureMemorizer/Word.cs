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
    public void Hide()
    {
        //Turns letters in text into underscores
        string hiddenText = "";
        foreach (char letters in _text)
        {
            hiddenText += "_";
        }
        _text = hiddenText;

        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;               
    }
    public bool isHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}