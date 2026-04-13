// this method plays the greeting sound
using System.Media;
using System.IO;

class AudioHelper
{
    public static void PlayGreeting()
    {
        try
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "greeting.wav");

            SoundPlayer player = new SoundPlayer(path);
            player.Load();
            player.PlaySync(); // waits until audio finishes
        }
        catch
        {
            Console.WriteLine("Could not play audio.");
        }
    }
}