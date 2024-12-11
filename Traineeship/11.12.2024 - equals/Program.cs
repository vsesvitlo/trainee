/*
 * Задача 2: Метод Equals для класу
Розширте попередню задачу, перевизначивши метод Equals для класу Person, 
щоб він також порівнював значення полів FirstName і LastName.
 */namespace _11._12._2024___equals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public static bool Checking(Person person1, Person person2)
        {
            if (person1.FirstName == person2.FirstName && person1.LastName == person2.LastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool Equals(Person person)
        {
            if (this.FirstName == person.FirstName && this.LastName == person.LastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person example = new Person("Ann", "Stuart");
            Person example1 = new Person("Annet", "Stuart");
            Person.Checking(example1, example1);
            Console.WriteLine(Person.Checking(example1, example1));
            Console.WriteLine(example.Equals(example1));
            Console.WriteLine(example.Equals(example));
        }
    }
}
