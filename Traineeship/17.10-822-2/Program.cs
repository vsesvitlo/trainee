﻿/*Напишіть клас Animal, який при створенні екземпляру надає йому атрибут виду тварини species.
 * Клас має містити метод, який виводить інформацію про вид тварини, і метод,
 * який виводить характерний звук для даного виду тварини. Створіть два класи Dog і Cat, 
 * які успадковуються від класу Animal (є підкласами для Animal). У кожному з підкласів 
 * реалізуйте виклик конструктора надкласу з передачею йому назви виду тварини. 
 * Також, у підкласах реалізуйте методи, які перевизначають метод надкласу для відтворення
 * характерного звуку для конкретного виду тварини. Визначте окрему функцію show_animal_info, яка приймає об’єкт (екземпляр класу) 
 * як аргумент і викликає його методи show_species і make_sound, якщо це тварина, 
 * а інакше - виводиться відповідне повідомлення як у вихідних даних.*/
namespace _17._10._2024___822
{

    public class Animal
    {
        public string species;
        public string sound;

        public Animal(string species, string sound)
        {
            this.species = species;
            this.sound = sound;
        }
        public string InfoSpecies()
        {

            return this.species;
        }
        public string InfoSound()
        {

            return this.sound;
        }
        /*public virtual void animalSound()  
  {
    Console.WriteLine("The animal makes a sound");
  }*/

    }
    public class Dog
    {
        Dog: Animal
    }
    public class Cat
    {
        Cat : Animal
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
