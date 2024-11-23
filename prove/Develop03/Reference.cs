/*
    Reference Class
        Has four attributes
            private string _book stores the scripture book
            private int _chapter stores the scripture chapter
            private int _startVerse stores the scripture first verse
            private int? _endVerse stores the scripture last verse or NULL if none exists
        Has one methods
            GetDisplayText() returns the scripture reference for either a single or multiple verses
        Has one Constructor
            Reference(string book, int chapter, int startVerse, int? endVerse = null) gets the scripture reference parts
*/

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
         return _endVerse.HasValue 
            ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}" 
            : $"{_book} {_chapter}:{_startVerse}";
    }

}