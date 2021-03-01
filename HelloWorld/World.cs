namespace HelloWorld
{
    public class Person
    {
        internal int age;
        internal string FirstName;
        internal string LastName;

        Person()
        {
            age = 0;
            FirstName = "Unknown";
            LastName = null;
        }
        public Person(int age, string FirstName)
        {
            this.age = age;
            this.FirstName = FirstName;
        }
        public Person(int age, string FirstName, string LastName)
        {
            this.age = age;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string toString()
        {
            return "This person name is " + this.FirstName + this.LastName + "and he/she has " + this.age + "years old.";
        }
    }
}