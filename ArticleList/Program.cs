using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Yvette Smith", new DateTime(1977, 12, 31), "F", "american");
            Author a2 = new Author("Kathryn Hansen", new DateTime(1980, 6, 10), "F", "american");

           // Console.WriteLine(a1);
            Author[] c1 = { a1 };
            Author[] c2 = { a2 };
            Article b1 = new Article("Vision of a Stellar Ending", c1, "More than 11,000 years ago, a massive, supergiant star came to the end of its life. The star's core collapsed to form" +
                " an incredibly dense ball of neutrons, and its exterior was blasted away in an immense release of energy astronomers call a supernova."
                , new DateTime(2021, 2, 23), new DateTime(2021, 3, 23), 157, 0, "Supernova");
            Article b2 = new Article("Exploring the Earth's Water", c2, "NASA has investigated humanity's impact on a number of our home planet's natural resources and recently explored our impact on " +
                "freshwater resources.", new DateTime(2021, 3, 8), new DateTime(2021, 3, 22), 1452, 3, "Earth");
            Article b3 = new Article("Antarctic Iceberg Breaks and Makes a New Berg", c2, "Antarctic iceberg A-68A, which broke from the Larsen C Ice Shelf in 2017, has been floating solo in recent years." +
                " Not anymore. The colossal iceberg finally fractured in late April 2020, spawning a new companion named A-68C.",
                new DateTime(2020, 5, 3), new DateTime(2020, 5, 4), 412, 12, "Iceberg");
            Article[] art = { b1, b2, b3 };
            Engine.TagsFilter(art, "Iceberg");
          //  Engine.DateFilter(art, new DateTime(2000, 1, 1), new DateTime(2028, 1, 1));
            //Engine.WeekendFilter(art);

            Engine.NumberOfPublicationSort(c1);
            for (int i = 0; i < c1.Length; i++)
            {
                Console.WriteLine(c1[i] + "\n");
            }
            Engine.NrPub(art, new DateTime(2000,1,1), new DateTime(2030,1,1));
        }
    }
}
