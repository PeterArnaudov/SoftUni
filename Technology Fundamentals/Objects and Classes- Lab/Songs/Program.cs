using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Program
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_');

                songs.Add(ReadSong(input));
            }

            string outputType = Console.ReadLine();

            if (outputType == "all")
            {
                songs.ForEach(x => Console.WriteLine(x.Name));
            }
            else
            {
                songs.Where(x => x.TypeList == outputType).ToList().ForEach(x => Console.WriteLine(x.Name));
            }
        }

        public static Song ReadSong(string[] information)
        {
            return new Song
            {
                TypeList = information[0],
                Name = information[1],
                Time = information[2]
            };
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
