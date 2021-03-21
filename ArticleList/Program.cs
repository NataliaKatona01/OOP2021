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
            Author a1 = new Author("Ion Creanga", new DateTime(1837, 12, 31), "M", "roman");
            Author a2 = new Author("Valeriu V.", new DateTime(1914, 6, 10), "F", "moldovean");

           // Console.WriteLine(a1);
            Author[] c1 = { a1, a2 };
            Author[] c2 = { a1 };
            Article b1 = new Article("Cum sa inveti OOP", c1, "Simplu si usor. Easy peasy, lemon squeezy", new DateTime(1999, 1, 1), new DateTime(2001, 2, 3), 12, 12345);
            Article b2 = new Article("Cum sa inveti fp", c2, "Simplu si usor. .....Easy peasy, lemon squeezy", new DateTime(2021, 3, 21), new DateTime(2021, 2, 3), 12, 12345);
            Article b3 = new Article("Cum sa faci bani", c1, "Simplu si usor. Easy peasy, lemon squeezy", new DateTime(2010, 1, 1), new DateTime(2011, 2, 3), 12, 12345);
            Article[] art = { b1, b2, b3 };
            // Engine.AuthorFilter(art, a1);
            //Engine.DateFilter(art, new DateTime(2000, 1, 1), new DateTime(2028, 1, 1));
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
