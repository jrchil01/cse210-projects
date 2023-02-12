//jacob 3:12-34

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string passage)
    {
        _reference = reference;
        string[] parts = passage.Split(" ");

        foreach(string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void Display()
    {
        _reference.Display();

        foreach(Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }
    }

    public bool IsCompleteHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, _words.Count);

        for(int i = 0; i < 4;)
        {
            if(!_words[num].IsHidden())
            {
                _words[num].Hide();
                i++;
            }
            num = rnd.Next(0, _words.Count);
            
            if(IsCompleteHidden()){
                break;
            }
        }
    }


}