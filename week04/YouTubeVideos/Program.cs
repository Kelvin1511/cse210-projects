using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Exploring Provo Canyon in Utah", "Rich Kevin Panozo Vargas", 480);
        video1.AddComment(new Comment("Alejandra Oyola", "The mountain views look incredible!"));
        video1.AddComment(new Comment("Carlos Mendoza", "Great video, Utah is definitely on my travel list."));
        video1.AddComment(new Comment("Sarah Jenkins", "What camera did you use for the drone shots?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to Make Authentic Lomo Saltado at Home", "Peruvian Kitchen", 720);
        video2.AddComment(new Comment("Mateo Quispe", "That wok technique is the secret to the real flavor."));
        video2.AddComment(new Comment("Emily Clark", "Tried this recipe tonight and my family loved it!"));
        video2.AddComment(new Comment("Diego Rojas", "Nothing beats homemade Peruvian food."));
        video2.AddComment(new Comment("Laura Gomez", "Super clear instructions, thank you!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("C# Object-Oriented Programming Basics", "Code Academy", 950);
        video3.AddComment(new Comment("Lucas Silva", "Abstraction finally makes total sense now."));
        video3.AddComment(new Comment("Hannah Brooks", "This helped me so much with my CSE 210 homework."));
        video3.AddComment(new Comment("Andres Morales", "Cleanest explanation on YouTube."));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

        Console.WriteLine("--------------------------------------------------");
    }
}