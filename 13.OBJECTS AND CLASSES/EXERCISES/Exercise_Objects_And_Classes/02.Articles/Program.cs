

namespace _02.Articles
{
    using System;
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

        public void EditNewContent(string newContent, Article article)
        {
            article.Conten = newContent;
        }

        public void ChangeAuthor(string newAuthor, Article article)
        {
            article.Author = newAuthor;
        }

        public void RenameAtrickle(string newTitle, Article article)
        {
            article.Title = newTitle;
        }
    }
    public class Program
    {
        public static void Main()
        {
            string[] articleDetails = Console.ReadLine().Split(", ").ToArray();

            string title = articleDetails[0];
            string content = articleDetails[1];
            string author = articleDetails[2];

            Article article = new Article(title, content, author);

            int limit = int.Parse(Console.ReadLine());

            for (int i = 0; i < limit; i++)
            {
                string[] input = Console.ReadLine().Split(": ").ToArray();

                string command = input[0];
                string newData = input[1].TrimStart(' ');

                if (command == "Edit")
                {
                   article.EditNewContent(newData, article);
                }
                else if(command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newData, article);
                }
                else
                {
                    article.RenameAtrickle(newData, article);
                }
            }

            Console.WriteLine(ToString(article));
        }

        public static string ToString(Article article)
        {
            return $"{article.Title} - {article.Conten}: {article.Author}";
        }
    }
}
