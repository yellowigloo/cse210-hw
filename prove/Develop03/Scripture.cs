class Scripture
{
    private Reference _reference = new Reference();
    private string _text;
    public Scripture(Reference refer, string text){
        _reference = refer;
        _text = text;
    }
    public void DisplayScripture(){
        
        Console.WriteLine($"{_reference.GetRefFormat()}\n{_text}");
    }
}