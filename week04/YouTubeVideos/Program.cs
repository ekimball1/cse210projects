using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Easy Stylish Mom Outfits", "Mom On the Go", 225);
        video1.AddComment(new Comment("Sarah","LOVE the jean jacket combo!"));
        video1.AddComment(new Comment("Katy","I have the same dress! I'll be wearing this outfit idea to church,thanks!"));
        video1.AddComment(new Comment("Emma","I absolutely LOVE your styling tips, they're practical and level up my outfits!"));

        Video video2 = new Video("Fun Mommy and Me Workout","Fit Momma",958);
        video2.AddComment(new Comment("Chelsea","My toddler loves this fun simple routine!"));
        video2.AddComment(new Comment("Anne", "This is simple yet effective, thank YOU!"));
        video2.AddComment(new Comment("Cassie", "My kids ask for this workout every morning!"));

        Video video3= new Video("Quick Daily Meditation"," BetterYou", 243);
        video3.AddComment(new Comment("Jake", "I listen to this on my lunch break, super effective reset!"));
        video3.AddComment(new Comment("Ximena", "Great little vid, thanks!"));
        video3.AddComment(new Comment("Areli", "Use it 3x a day, thanks for sharing!"));

        Video video4 = new Video("No Added Sugar Toddler Cookies","Mommas helping Mommas", 735);
        video4.AddComment(new Comment("Millie", "I make these for my niece and she LOVES them, so do I!"));
        video4.AddComment(new Comment("Jacob","Easy recipe and made with ingredients we usually have on hand."));
        video4.AddComment(new Comment("Lori", "I added peanut butter and they're even better!"));
        video4.AddComment(new Comment("Aria", "Such a great guiltless treat, thanks for sharing!"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}