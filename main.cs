using System;

public class Twitter
{
    public string PostMessage(string message)
    {
        if (message.Length <= 140)
        {
            return "Posted";
        }
        else
        {
            return "Rejected";
        }
    }
}

// Unit Tests
public class TwitterTests
{
    public static void Main(string[] args)
    {
        Twitter twitter = new Twitter();

        // Unit Test #1
        string message1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        string result1 = twitter.PostMessage(message1);
        Console.WriteLine($"Test 1:\nRequired Inputs: {message1}\nExpected Outcome: {result1}\n");

        // Unit Test #2
        string message2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper  risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas.";
        string result2 = twitter.PostMessage(message2);
        Console.WriteLine($"Test 2:\nRequired Inputs: {message2}\nExpected Outcome: {result2}\n");

        // Unit Test #3
        string message3 = "Massa vitae tortor condimentum lacinia quis vel eros donec ac.";
        string result3 = twitter.PostMessage(message3);
        Console.WriteLine($"Test 3:\nRequired Inputs: {message3}\nExpected Outcome: {result3}\n");

        // Unit Test #4
        string message4 = "Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.";
        string result4 = twitter.PostMessage(message4);
        Console.WriteLine($"Test 4:\nRequired Inputs: {message4}\nExpected Outcome: {result4}\n");
    }
}
