using InheritanceLab.Problem4.RadioExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Problem4
{
    internal static class SongHelper
    {
        public static Stack<Song> ComposePlaylist()
        {
            int.TryParse(Console.ReadLine(), out int songsCount);
            var songs = new Stack<Song>(songsCount);

            while (songsCount > 0)
            {
                var songInfo = Console.ReadLine().Split(';');

                try
                {
                    var minutesSecondsSeparator = songInfo[2].IndexOf(':');

                    if (songInfo.Length < 3 || minutesSecondsSeparator < 1 || minutesSecondsSeparator > songInfo[2].Length - 2)
                        throw new InvalidSongException();

                    var artist = songInfo[0];
                    var songName = songInfo[1];
                    var minutes = int.Parse(songInfo[2].Substring(0, minutesSecondsSeparator));
                    var seconds = int.Parse(songInfo[2].Substring(minutesSecondsSeparator + 1));

                    songs.Push(new Song(artist, songName, minutes, seconds));
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine("Invalid song length.");
                }

                songsCount--;
            }

            return songs;
            
        }

        public static void PrintPlaylistSummary(Stack<Song> playlist)
        {
            Console.WriteLine($"Songs added: {playlist.Count}");

            var totalSeconds = playlist.Select(s => s.Seconds).Sum();
            var secondsToMinutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            var totalMinutes = playlist.Select(s => s.Minutes).Sum() + secondsToMinutes;
            var minutesToHours = totalMinutes / 60;
            var minutes = totalMinutes % 60;

            var hours = minutesToHours;

            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
