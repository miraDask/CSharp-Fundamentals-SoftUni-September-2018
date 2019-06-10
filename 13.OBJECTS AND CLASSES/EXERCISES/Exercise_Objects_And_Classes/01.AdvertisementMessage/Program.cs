

namespace _01.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;

    public class AdvertisementMessage
    {
        public string Phrase { get; set; }

        public string Event { get; set; }

        public string Author { get; set; }

        public string City { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            Random random = new Random();

            List<string> phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            List<string> events = new List<string>
            {
                 "Now I feel good.",
                 "I have succeeded with this product.",
                 "Makes miracles. I am happy of the results!",
                 "I cannot believe but now I feel awesome.",
                 "Try it yourself, I am very satisfied.",
                 "I feel great!"

            };

            List<string> authors = new List<string>
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            List<string> cities = new List<string>
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int index = -1;

            for (int i = 0; i < limit; i++)
            {
                AdvertisementMessage message = new AdvertisementMessage();

                index = random.Next(0, phrases.Count);
                message.Phrase = phrases[index];

                index = random.Next(0, events.Count);
                message.Event = events[index];

                index = random.Next(0, authors.Count);
                message.Author = authors[index];

                index = random.Next(0, cities.Count);
                message.City = cities[index];

                Console.WriteLine($"{message.Phrase} {message.Event} {message.Author} – {message.City}");
            }
        }
    }
}
