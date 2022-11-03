using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfSongs = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();
            for (int i = 0; i < countOfSongs; i++)
            {
                List<string> songInfo = Console.ReadLine().Split('_').ToList();
                Song song = new Song(songInfo[0], songInfo[1], songInfo[2]);
                songsList.Add(song);
            }
            string type = Console.ReadLine();
            if (type == "all")
            {
                foreach (var song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songsList)
                {
                    if (song.TypeList == type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
