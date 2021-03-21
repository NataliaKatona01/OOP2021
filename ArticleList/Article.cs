using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    class Article
    {
        private string title;
        private Author[] author;
        private string content;
        private DateTime date;
        private DateTime update;
        private int likes;
        private int dislikes;

        public Article(string title, Author[] author, string content, DateTime date, DateTime update, int likes, int dislikes)
        {
            Title = title;
            Author = author;
            for (int i = 0; i < Author.Length; i++)
                Author[i].NumberOfPublications++;
            Content = content;
            Date = date;
            Update = update;
            Likes = likes;
            Dislikes = dislikes;
        }

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Update { get => update; set => update = value; }
        public int Likes { get => likes; set => likes = value; }
        public int Dislikes { get => dislikes; set => dislikes = value; }
        public Author[] Author { get => author; set => author = value; }

        public override string ToString()
        {
            string authors = "";
            for (int i = 0; i < Author.Length; i++)
                authors += Author[i] + "; ";
            return Title + "\n" + authors + "\n" + Content + "\n" + Date;
        }
    }
    
}
