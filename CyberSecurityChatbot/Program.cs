//Program starts here

using System;

class Program
{
    static void Main(string[] args)
    {
        // show logo first
        Chatbot.ShowLogo();

        // play audio after logo
        AudioHelper.PlayGreeting();

        Console.WriteLine();

        // ask for name AFTER audio
        string name = Chatbot.GetUserName();
        // welcome message
        Console.WriteLine("Hello " + name + ". Welcome to the Cybersecurity Awareness Bot.");
        Console.WriteLine("You can ask me about passwords, phishing, and safe browsing.");
        Console.WriteLine("Type exit to quit the program.");

        // start guided chat
        Chatbot.StartChat(name);
    }
}
