using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> vidOneComments = new List<Comment>();
        Comment comment1 = new Comment("Meghan", "That's so awesome! I'm so glad I saw this video. Very helpful.");
        Comment comment2 = new Comment("Darwin", "I am a fish. And Yes, I am from the Amazing World of Gumball.");
        Comment comment3 = new Comment("Meowy", "My cat loves this types of videos. She's always watching very intently when I watch your videos.");
        vidOneComments.Add(comment1);
        vidOneComments.Add(comment2);
        vidOneComments.Add(comment3);

        List<Comment> vidTwoComments = new List<Comment>();
        comment1 = new Comment("Gumball", "I just know that girlfriend would much appreciate me knowing these things to make her happy. Thank you so much for these gift ideas!");
        comment2 = new Comment("Natasha", "You are so Hilarious! This made my day");
        comment3 = new Comment("Ms.Piggy", "I should send Kermit this video. He should know this! ");
        vidTwoComments.Add(comment1);
        vidTwoComments.Add(comment2);
        vidTwoComments.Add(comment3);

        List<Comment> vidThreeComments = new List<Comment>();
        comment1 = new Comment("Kermit The Frog", "Love the musicality! Would love to have a collab sometime with you!");
        comment2 = new Comment("Cloud", "I don't know how to sing, but I know you have a really nice voice!. Do you do weddings?");
        comment3 = new Comment("Mickey Mouse", "I'm quite a singer myself, but you are not just a singer! You're and artist! Would you like to join me and Goofy for a collaboration in the future?");
        vidThreeComments.Add(comment1);
        vidThreeComments.Add(comment2);
        vidThreeComments.Add(comment3);

        Video video1 = new Video("How to make lasagna the easy way", "HowToMan", 900, vidOneComments);
        Video video2 = new Video("Cute Gifts to give your Girlfriend!", "Shaye The Crafter", 600, vidTwoComments);
        Video video3 = new Video("'Rainbow Connection'Cover by Rosie", "Rosieee", 225, vidThreeComments);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.GetVideoDetails();
        }

    }
}