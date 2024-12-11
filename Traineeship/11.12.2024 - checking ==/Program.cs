/*
 Задача 1: Оператор == для класу
Створіть клас Person, який має два поля: FirstName та LastName.
Перевизначте оператор ==, щоб перевіряти, 
чи два об'єкти Person мають однакові значення полів.*/
namespace _11._12._2024___checking___
{
    public class Person {
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person example = new Person("Ann", "Stuart");
            Person example1 = new Person("Annet", "Stuart");
            Person.Checking(example1, example1);
            Console.WriteLine(Person.Checking(example1, example1));
           
        }
    }
}
