using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Video video1 = new Video("how to create a youtube-like program in c#", "coder 101", 600);
        Video video2 = new Video("making a video program that tracks youtube videos", "devmaster", 450);
        Video video3 = new Video("building your own youtube: step-by-step guide", "programmingpro", 720);

        video1.AddComment(new Comment("alice", "this is like watching a tutorial on making a tutorial!"));
        video1.AddComment(new Comment("bob", "i learned so much! now i can make my own youtube clone."));
        video1.AddComment(new Comment("charlie", "a program about programs... mind blown!"));

        video2.AddComment(new Comment("eve", "i can't believe i'm watching a video about creating a video program."));
        video2.AddComment(new Comment("mallory", "what’s next, a tutorial on making a tutorial on this?"));
        
        video3.AddComment(new Comment("trudy", "who knew watching a video could be so meta?"));
        video3.AddComment(new Comment("oscar", "i feel like i’m in an endless loop of programming tutorials."));
        video3.AddComment(new Comment("peggy", "i need a break from all these tutorials!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"title: {video.Title}");
            Console.WriteLine($"author: {video.Author}");
            Console.WriteLine($"length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
