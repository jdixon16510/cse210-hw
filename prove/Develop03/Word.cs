/*
    Word Class
        Has two attributes
            _text is the single word string to hide 
            _isHidden tells if the word is hidden
        Has four methods
            Hide() sets the word staus as hidden
            Show() sets the word status as visable
            IsHidden() returns the word status
            GetDisplayText() returns the word if not hidden and ___ if hidden
        Has one Constructor
            Word(string text) gets the _word and sets the _isHidden the false
*/


public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden 
            ? new string('_', _text.Length) 
            : _text;
    }

}