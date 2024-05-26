using System;

class Lyrics
{
    public static void Main()
    {
      //Unit Test #1
      Console.WriteLine("Unit Test #1");
      DisplaySongLyrics("Oh, well imagine", "As I'm pacing the pews in a church corridor", "And I can't help but to hear", "No, I can't help but to hear an exchanging of words...");

      //Unit Test #2
      Console.WriteLine("Unit Test #2");
      DisplaySongLyrics("Oh-oh-oh-oh-oh", "oh-oh-oh-oh", "oh-oh-oh", "Caught in a bad romance...");

      //Unit Test #3
      Console.WriteLine("Unit Test #3");
      DisplaySongLyrics("Coming out of my cage", "And I've been doing just fine", "Gotta gotta be down", "Because I want it all");

      //Unit Test #4
      Console.WriteLine("Unit Test #4");
      DisplaySongLyrics("Now, this is a story all about how", "My life got flipped-turned upside down", "And I'd like to take a minute", "Just sit right there", "I'll tell you how I became the prince of a town called Bel-Air");

    }

    
    static void DisplaySongLyrics(params string [] lyrics)
    {
        foreach (var line in lyrics)
        {
            Console.WriteLine(line);
        }
    }
}