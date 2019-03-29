using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeTube_Statistics
{
    public class Program
    {
        public static void Main()
        {
            List<Video> videos = new List<Video>();

            while (true)
            {
                string input = Console.ReadLine();
                string[] data = new string[2];

                if (input == "stats time")
                {
                    break;
                }

                if (input.Contains('-'))
                {
                    data = input.Split('-');

                    string name = data[0];
                    int views = int.Parse(data[1]);

                    if (!videos.Any(x => x.Name == name))
                    {
                        videos.Add(new Video(name, views));
                    }
                    else
                    {
                        foreach (var video in videos)
                        {
                            if (video.Name == name)
                            {
                                video.Views += views;
                                break;
                            }
                        }
                    }
                }
                else if (input.Contains(':'))
                {
                    data = input.Split(':');

                    string command = data[0];
                    string name = data[1];

                    if (command == "like")
                    {
                        foreach (var video in videos)
                        {
                            if (video.Name == name)
                            {
                                video.Likes++;
                                break;
                            }
                        }
                    }
                    else if (command == "dislike")
                    {
                        foreach (var video in videos)
                        {
                            if (video.Name == name)
                            {
                                video.Likes--;
                                break;
                            }
                        }
                    }
                }
            }

            string sortBy = Console.ReadLine();

            if (sortBy == "by views")
            {
                foreach (var video in videos.OrderByDescending(x => x.Views))
                {
                    Console.WriteLine($"{video.Name} - {video.Views} views - {video.Likes} likes");
                }
            }
            else if (sortBy == "by likes")
            {
                foreach (var video in videos.OrderByDescending(x => x.Likes))
                {
                    Console.WriteLine($"{video.Name} - {video.Views} views - {video.Likes} likes");
                }
            }
        }
    }

    public class Video
    {
        public string Name { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }

        public Video(string name, int views)
        {
            Name = name;
            Views = views;
            Likes = 0;
        }
    }
}
