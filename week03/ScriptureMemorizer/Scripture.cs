using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //Constructors
    public Scripture(Reference reference, string text)
    {
        string[] wordsInText = text.Split(" "); //split verse into words

        //add words to the list
        foreach (string wordText in wordsInText)
        {
            Word wordToAdd = new Word(wordText);
            //add word in list
            _words.Add(wordToAdd);
        }

        //Assign reference
        _reference = reference;
    }

    //Methods
    public void HideRandomWords(int numberToHide)
    {
        Word wordToHide = _words[numberToHide];
        wordToHide.Hide();
    }

    public int GetVerseLength()
    {
        return _words.Count();
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += $"{word.GetDisplayText()} ";
        }

        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        int hiddenWordCount = 0;
        foreach (Word wordText in _words)
        {
            if (wordText.isHidden() == true)
            {
                hiddenWordCount += 1;
            }
        }

        if (hiddenWordCount == _words.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}