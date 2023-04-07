using System;

class Program
{
    static void Main(string[] args)
    {
        Comment vid1Comment1 = new Comment();
        vid1Comment1._commenter = "Abe";
        vid1Comment1._commentText = "First";
        Comment vid1Comment2 = new Comment();
        vid1Comment2._commenter = "Ben";
        vid1Comment2._commentText = "Second :(";
        Comment vid1Comment3 = new Comment();
        vid1Comment3._commenter = "Caden";
        vid1Comment3._commentText = "Thrid is the best!!!";
        
        Comment vid2Comment1 = new Comment();
        vid2Comment1._commenter = "Dan";
        vid2Comment1._commentText = "Hi again";
        Comment vid2Comment2 = new Comment();
        vid2Comment2._commenter = "Ellen";
        vid2Comment2._commentText = "How did I get here?";
        Comment vid2Comment3 = new Comment();
        vid2Comment3._commenter = "Fred";
        vid2Comment3._commentText = "All our names are generic";
        
        Comment vid3Comment1 = new Comment();
        vid3Comment1._commenter = "Gary";
        vid3Comment1._commentText = "Like the snail";
        Comment vid3Comment2 = new Comment();
        vid3Comment2._commenter = "Harry";
        vid3Comment2._commentText = "I have alopecia";
        Comment vid3Comment3 = new Comment();
        vid3Comment3._commenter = "Ian";
        vid3Comment3._commentText = "I did not stop to ask if I should";
        
        Video vid1 = new Video();
        vid1._title = "Jarom's Revenge";
        vid1._author = "Jarom";
        vid1._length = 14;
        vid1._comments.Add(vid1Comment1);
        vid1._comments.Add(vid1Comment2);
        vid1._comments.Add(vid1Comment3);
        vid1._commentCount = vid1._comments.Count();
        
        Video vid2 = new Video();
        vid2._title = "Kim's Amazing Adventures";
        vid2._author = "Kim";
        vid2._length = 10;
        vid2._comments.Add(vid2Comment1);
        vid2._comments.Add(vid2Comment2);
        vid2._comments.Add(vid2Comment3);
        vid2._commentCount = vid2._comments.Count();
       
        Video vid3 = new Video();
        vid3._title = "Larry's Boring Life";
        vid3._author = "Larry";
        vid3._length = 200;
        vid3._comments.Add(vid3Comment1);
        vid3._comments.Add(vid3Comment2);
        vid3._comments.Add(vid3Comment3);
        vid3._commentCount = vid3._comments.Count();
       
        List<Video> vids = new List<Video>();
        vids.Add(vid1);
        vids.Add(vid2);
        vids.Add(vid3);
        foreach (Video vid in vids){
            vid.DisplayVideoInfo();
        }

    }
}