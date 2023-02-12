public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse = "0";

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void Display()
    {
        if(_endVerse != "0"){
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }else{
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
        
    }
}