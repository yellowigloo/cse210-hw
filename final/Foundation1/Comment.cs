class Comment{
    public string _commenter;
    public string _commentText;
    public void DisplayComment(){
        Console.Write($"{_commenter} - ");
        Console.WriteLine($"{_commentText}");
    }
}