class Word
{
    private string[] _brokeScripture;
    private int _len;
    public Word(string text){
        _brokeScripture = text.Split();
        _len = _brokeScripture.Count();
    }
    public void DisplayHiddenText(){
        int hideTimes = _len/4;
        Random rnd = new Random();
        for (int i = 0; i < hideTimes; i++){
            int randomWord = rnd.Next(_len);
            _brokeScripture[randomWord] = "_";
        }
        foreach (string hidenWord in _brokeScripture){
            Console.Write($"{hidenWord} ");
        }
    }

}