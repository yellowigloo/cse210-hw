class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public int _commentCount;
    public int CommentCounter(List<Comment> comments){
        _commentCount = comments.Count();
        return _commentCount;
    }
    public void DisplayVideoInfo(){
        Console.WriteLine($"{_title}: by {_author}. {_length} seconds. {_commentCount} comments");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments){
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}