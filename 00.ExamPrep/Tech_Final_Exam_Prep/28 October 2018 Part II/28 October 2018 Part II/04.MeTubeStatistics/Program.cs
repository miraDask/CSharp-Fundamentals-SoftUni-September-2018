using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04.MeTubeStatistics
{
    public class Video
    {
        public Video(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }

        public int Views { get; set; } = 0;

        public int Likes { get; set; } = 0;

    }


    public class Program
    {

        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stats time")
                {
                    break;
                }



                if (input.Contains('-'))
                {
                    string[] videoViews = input.Split('-');

                    string title = videoViews[0];

                    int views = int.Parse(videoViews[1]);



                    if (!videos.Any(x => x.Title == title))
                    {
                        Video currentVideo = new Video(title);
                        currentVideo.Views += views;
                        videos.Add(currentVideo);
                    }
                    else
                    {
                        int indexOfVideo = videos.FindIndex(x => x.Title == title);
                        videos[indexOfVideo].Views += views;
                    }

                }
                else
                {
                    string[] videoLikeOrNot = input.Split(':');

                    string title = videoLikeOrNot[1];

                    int indexOfVideo = videos.FindIndex(x => x.Title == title);

                    if (indexOfVideo < 0)
                    {
                        continue;
                    }

                    if (videoLikeOrNot[0] == "like")
                    {
                        videos[indexOfVideo].Likes++;
                    }
                    else
                    {

                        videos[indexOfVideo].Likes--;

                    }
                }
            }

            string[] orderOfPrinting = Console.ReadLine().Split();

            if (orderOfPrinting[1] == "views")
            {
                videos = videos.OrderByDescending(x => x.Views).ToList();
            }
            else
            {
                videos = videos.OrderByDescending(x => x.Likes).ToList();
            }

            foreach (var video in videos)
            {
                Console.WriteLine($"{video.Title} - {video.Views} views - {video.Likes} likes");
            }
        }
    }
}

