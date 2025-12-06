using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video studyVideo = new Video("Study Tips for Finals", "StudentLife", 420);
        studyVideo.AddComment(new Comment("Megan", "Taking notes like this really helps."));
        studyVideo.AddComment(new Comment("Tyler", "Watching this the night before my exam lol."));
        studyVideo.AddComment(new Comment("Luis", "I wish I knew this last semester."));

        Video gameVideo = new Video("First Time Playing Elden Ring", "BryceGames", 900);
        gameVideo.AddComment(new Comment("Jake", "You rolled straight off the cliff haha."));
        gameVideo.AddComment(new Comment("Anna", "This made me want to try the game."));
        gameVideo.AddComment(new Comment("Noah", "I felt that first boss pain."));

        Video vlogVideo = new Video("Day in the Life of a CS Major", "CodeVlog", 600);
        vlogVideo.AddComment(new Comment("Sarah", "This looks exactly like my schedule."));
        vlogVideo.AddComment(new Comment("Ben", "The 2 AM debugging hits too close."));
        vlogVideo.AddComment(new Comment("Kara", "Now I’m scared for this major."));

        videos.Add(studyVideo);
        videos.Add(gameVideo);
        videos.Add(vlogVideo);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }

     
    }
}
