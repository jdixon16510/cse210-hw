using System;

class Program
{
    static void Main()
    {
        // Creating videos
        var video1 = new Video("Learning C# for Beginners", "John Doe", 300);
        var video2 = new Video("C# Advanced Topics", "Jane Smith", 600);
        var video3 = new Video("Introduction to Algorithms", "Alan Turing", 500);

        // Adding comments to video1
        video1.AddComment(new Comment("Alice", "Great video, really helped me understand C#!"));
        video1.AddComment(new Comment("Bob", "Very informative! Thanks for the content."));
        video1.AddComment(new Comment("Charlie", "Can you cover LINQ in the next video?"));

        // Adding comments to video2
        video2.AddComment(new Comment("David", "This was a bit too advanced for me."));
        video2.AddComment(new Comment("Eve", "The explanation of delegates was excellent."));
        video2.AddComment(new Comment("Frank", "Looking forward to more advanced C# topics!"));

        // Adding comments to video3
        video3.AddComment(new Comment("Grace", "This video on algorithms was great, more examples please!"));
        video3.AddComment(new Comment("Heidi", "Can you explain the divide and conquer strategy in more detail?"));
        video3.AddComment(new Comment("Ivan", "I wish there was a breakdown of each algorithm's time complexity."));

        // Storing all videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Displaying details for each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength() / 60} minutes");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"\t{comment.GetName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}