using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef Emma", 300);
        video1.AddComment(new Comment("Alice", "Great tips!"));
        video1.AddComment(new Comment("Bob", "I tried this and it worked well."));
        video1.AddComment(new Comment("Charlie", "Yummy!"));

        // Video 2
        Video video2 = new Video("C# Basics Tutorial", "Tech Guru", 600);
        video2.AddComment(new Comment("Dan", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Eva", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Subbed!"));

        // Video 3
        Video video3 = new Video("BYU-Idaho Campus Tour", "BYU-I Official", 450);
        video3.AddComment(new Comment("Grace", "Brings back memories."));
        video3.AddComment(new Comment("Hank", "Looking forward to visiting."));
        video3.AddComment(new Comment("Ivy", "Beautiful campus!"));

        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display info for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
