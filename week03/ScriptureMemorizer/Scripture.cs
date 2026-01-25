public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //Constructors
    public Scripture(Reference reference, string text)
    {
        Word word = new Word(text);
        _reference = reference;
        _words.Add(word);
    }

    //Methods
    private void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}