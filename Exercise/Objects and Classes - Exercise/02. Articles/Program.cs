using System;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currentArticle = Console.ReadLine().Split(", ");

            var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);

            int countOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfChanges; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");

                string command = lines[0];

                string argument = lines[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void ChangeAuthor(string author) => Author = author;
        public void Edit(string content) => Content = content;
        public void Rename(string title) => Title = title;
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
