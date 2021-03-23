using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    static class Engine
    {
        public static void AuthorFilter(Article[] articles, Author author)
        {

            Article[] a = Array.FindAll(articles, element => element.Author.Contains(author));
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "\n");
            }
        }
        public static void DateFilter(Article[] articles, DateTime start, DateTime finish)
        {
            
            Article[] a = Array.FindAll(articles, element => element.Date.CompareTo(start) >= 0 && element.Date.CompareTo(finish) <= 0);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "\n");
            }
        }
        public static void WeekendFilter(Article[] articles)
        {
            Article[] a = Array.FindAll(articles, element => element.Date.DayOfWeek == DayOfWeek.Saturday || element.Date.DayOfWeek == DayOfWeek.Sunday);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "\n");
            }
        }
        public static void TagsFilter(Article[] articles, string Tag)
        {
            Article[] a = Array.FindAll(articles, element => element.Tag.Contains(Tag));
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "\n");
            }
        }

        public static void CronologicSort(Article[] art)
        {
            for (int i = 0; i < art.Length - 1; i++)
            {
                for (int j = i + 1; j < art.Length; j++)
                {
                   if( art[i].Date.CompareTo(art[j].Date) == 1)
                    {
                        Article aux = art[i];
                        art[i] = art[j];
                        art[j] = aux;
                    }
                }
            }
        }
        public static void LikesSort(Article[] art)
        {
            for (int i = 0; i < art.Length - 1; i++)
            {
                for (int j = i + 1; j < art.Length; j++)
                {
                    if (art[i].Likes > art[j].Likes)
                    {
                        Article aux = art[i];
                        art[i] = art[j];
                        art[j] = aux;
                    }
                }
            }
        }
        public static void DislikesSort(Article[] art)
        {
            for (int i = 0; i < art.Length - 1; i++)
            {
                for (int j = i + 1; j < art.Length; j++)
                {
                    if (art[i].Dislikes > art[j].Dislikes)
                    {
                        Article aux = art[i];
                        art[i] = art[j];
                        art[j] = aux;
                    }
                }
            }
        }

        public static void NumberOfPublicationSort(Author[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].NumberOfPublications < a[j].NumberOfPublications)
                    {
                        Author aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
            }
        }
        public static void NumberOfPublication(Author[] a)
        {
            foreach(Author author in a)
                Console.WriteLine($"Numarul de publicatii a lui {author} este {author.NumberOfPublications}");
        }

        public static void NrPub(Article[] art, DateTime start, DateTime finish)
        {
            Article[] a = Array.FindAll(art, element => element.Date.CompareTo(start) >= 0 && element.Date.CompareTo(finish) <= 0);
            Console.WriteLine(a.Length); 
        }
    }
}
