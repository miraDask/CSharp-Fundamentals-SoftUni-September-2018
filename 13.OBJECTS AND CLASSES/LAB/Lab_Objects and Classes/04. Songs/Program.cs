
namespace _04.Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
    public class Program
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] currentSongData = Console.ReadLine().Split('_').ToArray();

                string typeList = currentSongData[0];
                string name = currentSongData[1];
                string time = currentSongData[2];

                Song currentSong = new Song();

                currentSong.TypeList = typeList;
                currentSong.Name = name;
                currentSong.Time = time;

                songs.Add(currentSong);
            }

            string type = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                string resultSong = string.Empty;

                if (songs[i].TypeList == type)
                {
                    Console.WriteLine(songs[i].Name);
                }
                else if (type == "all")
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
        }
    }
}
