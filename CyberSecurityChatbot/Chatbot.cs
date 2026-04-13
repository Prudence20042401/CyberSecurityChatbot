using System;
using System.Threading;

class Chatbot
{
    // show ASCII logo
    public static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("=======================================");
        Console.WriteLine("      CYBERSECURITY AWARENESS BOT");
        Console.WriteLine("=======================================");
        Console.WriteLine(@"
          _______
         /       \
        /         \
       |           | <SECURED!>
        \_________/
        |         |
        |   ___   |
        |  | o |  |
        |  |___|  |
        |         |
        |_________|

          *  *  *  *
          _  _  _  _
");

        Console.WriteLine("       Stay safe online!");
        Console.WriteLine();

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Loading");

        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(400);
            Console.Write(".");
        }

        Console.WriteLine();
        Console.ResetColor();
}

    // ask for user's name
    public static string GetUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Please enter a valid name: ");
            name = Console.ReadLine() ?? "";
        }

        return name;
    }

    // main chatbot loop
    public static void StartChat(string name)
    {
        string input = "";

        while (input != "exit")
        {
            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name + ": ");
            Console.ResetColor();

            input = Console.ReadLine() ?? "";

            if (input == null)
            {
                input = "";
            }
            else
            {
                input = input.ToLower();
            }

            // empty input
            if (input == "")
            {
                Console.WriteLine("Bot: Please type something.");
            }

            // responses
            else if (input.Contains("how are you"))
            {
                TypeText("I am fine. I am here to help you stay safe online.");
            }
            else if (input.Contains("purpose"))
            {
                TypeText("My purpose is to teach you about cybersecurity and online safety.");
            }
            else if (input.Contains("password"))
            {
                TypeText("Use strong passwords with letters, numbers and symbols. Do not share your password.");
            }
            else if (input.Contains("phishing"))
            {
                TypeText("Phishing is when scammers trick you into giving personal information through fake emails or links.");
            }
            else if (input.Contains("browsing"))
            {
                TypeText("Always use secure websites and avoid clicking unknown links.");
            }
            else if (input.Contains("what can i ask"))
            {
                TypeText("You can ask me about passwords, phishing or safe browsing.");
            }
            else if (input == "exit")
            {
                Console.WriteLine("Goodbye " + name + ". Stay safe online.");
            }
            else
            {
                TypeText("I did not understand that. Try asking about passwords or phishing.");
            }
        }
    }

    // typing effect
    public static void TypeText(string message)
    {
        int i = 0;

        while (i < message.Length)
        {
            Console.Write(message[i]);
            Thread.Sleep(20);
            i = i + 1;
        }

        Console.WriteLine();
    }
}