class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    public Reference(){
        _book = "";
        _chapter = "";
        _verse = "";
    }
    public Reference(string book, string chapter, string verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string GetRefFormat(){
        return _book + " " + _chapter + ":" + _verse;
    }
}