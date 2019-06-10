
namespace _03.Articles2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Conten = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Conten { get; set; }

        public string Author { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            var articleRegister = new List<Article>();

            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                string[] articleDetails = Console.ReadLine().Split(", ").ToArray();

                string title = articleDetails[0];
                string content = articleDetails[1];
                string author = articleDetails[2];

                Article article = new Article(title, content, author);

                articleRegister.Add(article);

            }

            string criteria = Console.ReadLine();

            var sortedArticle = new List<Article>();

            if (criteria == "title")
            {
                sortedArticle = articleRegister.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "content")
            {
                sortedArticle = articleRegister.OrderBy(a => a.Conten).ToList();
            }
            else
            {
                sortedArticle = articleRegister.OrderBy(a => a.Author).ToList();
            }

            foreach (Article article in sortedArticle)
            {
                
                Console.WriteLine(ToString(article));
            }
        }

        public static string ToString(Article article)
        {
            return $"{article.Title} - {article.Conten}: {article.Author}";
        }
    }
}
