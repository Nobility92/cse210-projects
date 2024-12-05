using System;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> _videos = new List<Videos>();

        Videos video1 = new Videos("House Mate", "Bovi", 300);
        video1.AddComment(new Comment("Henry", "Great video! Learned a lot."));
        video1.AddComment(new Comment("Wendy", "I love Prosper, great video!"));
        video1.AddComment(new Comment("David", "I like the character of Barrister, he is amazing!"));
        _videos.Add(video1);

        
        Videos video2 = new Videos("Web Development", "ZTM", 700);
        video2.AddComment(new Comment("James", "This tutorial is awesome!"));
        video2.AddComment(new Comment("Adebisi", "Very clear, thank you!"));
        video2.AddComment(new Comment("Queen", "I am new to JavaScript, but this helped alot"));
        _videos.Add(video2);

        
        Videos video3 = new Videos("GoogleSheet for beginners", "The Guru", 920);
        video3.AddComment(new Comment("Emeka", "This is educating, thank you!"));
        video3.AddComment(new Comment("Uchenna", "Whats the difference btw Google sheet and Excel?"));
        video3.AddComment(new Comment("Famosa", "This is inspiring, thank you for sharing."));
        video3.AddComment(new Comment("Destiny", "I have learned alot, great video."));
        _videos.Add(video3);

        // Display the details for each video
        foreach (Videos video in _videos)
        {
            Console.WriteLine(video);  // Print video title, author, and number of comments
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment);  // Print each comment for the video
            }
            Console.WriteLine("\n" + new string('-', 40) + "\n");  // Separate each video with a line
        }
    }
    }
