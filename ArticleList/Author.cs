using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    class Author
    {
        private string name;
        private DateTime birthday;
        private string gender;
        private string nationality;
        private int numberOfPublications;

        public Author(string name, DateTime birthday, string gender, string nationality)
        {
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.nationality = nationality;
            numberOfPublications = 0;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public int NumberOfPublications { get => numberOfPublications; set => numberOfPublications = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
