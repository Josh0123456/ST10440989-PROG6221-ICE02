using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ST10440989ICE02
{
    class Program
    {
        static void Main()
        {
            string[] soundFiles =
                    {
            "C:\\Users\\joshs\\source\\repos\\ST10440989ICE02\\wav\\guitarloop.wav",
            "C:\\Users\\joshs\\source\\repos\\ST10440989ICE02\\wav\\drumloop.wav",
            "C:\\Users\\joshs\\source\\repos\\ST10440989ICE02\\wav\\piano.wav"
        };

            Console.WriteLine("Select a sound to play:");
            Console.WriteLine("1 - Guitar");
            Console.WriteLine("2 - Drums");
            Console.WriteLine("3 - Piano");
            Console.Write("Enter your choice (1-3): ");

            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 3) //Make sure the input is an int between 0 and 4
            {
                string selectedFile = soundFiles[choice - 1];

                try
                {
                    using (SoundPlayer player = new SoundPlayer(selectedFile))
                    {
                        player.Load();
                        Console.WriteLine($"Playing {selectedFile}...");
                        player.PlaySync(); // Use Play() for asynchronous playback
                        Console.WriteLine("Playback finished.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error playing sound: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}

