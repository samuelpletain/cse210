using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("A Funny Video", "pewpew123", 120);
        video1.AddComment(new Comment("LaughTrackLarry", "Haven't laughed this hard in weeks! The part with the cat and the vacuum cleaner had me in tears. 😂"));
        video1.AddComment(new Comment("JoyfulJenny", "This is pure gold! Please make a sequel; we need more of this joy in our lives."));
        video1.AddComment(new Comment("FamilyFunFrank", "Shared this with my entire family, and now it's an inside joke. Thanks for the laughs!"));
        
        Video video2 = new Video("A Sports Video", "I<3NFL", 1500);
        video2.AddComment(new Comment("StrategySteve", "Incredible analysis on the playoff strategies. Really opened my eyes to the game's nuances."));
        video2.AddComment(new Comment("HighlightHank", "That highlight reel was epic! Caught all the key moments perfectly. 🏈"));
        video2.AddComment(new Comment("StatsSamantha", "Great breakdown of the stats and performance. Helps me appreciate the players even more."));

        Video video3 = new Video("An Instructive Video", "The Math Teacher", 506);
        video3.AddComment(new Comment("MathMagicMike", "Finally, a teacher who makes quadratic equations easy to understand! Thank you!"));
        video3.AddComment(new Comment("StudyBuddyBea", "Your teaching style is so engaging. I've watched this video three times already for my exam prep."));
        video3.AddComment(new Comment("PracticalPat", "Loved the practical examples! They really helped the concepts click for me."));
        Video video4 = new Video("A Kids Video", "BabyBearRyhmes", 65);
        video4.AddComment(new Comment("ToddlerMomTina", "My toddler asks to watch this on repeat. Safe to say, it's a hit in our house!"));
        video4.AddComment(new Comment("CatchyCarol", "So adorable and catchy! Even I find myself humming along."));
        video4.AddComment(new Comment("CreativeCasey", "The animations are so vibrant and fun. Great job on making learning entertaining!"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine("==================================");
            video.GetMetadata();
            video.DisplayComments();
        }
    }
}