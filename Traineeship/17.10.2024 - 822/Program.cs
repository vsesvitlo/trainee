/*Напишіть клас Animal, який при створенні екземпляру надає йому атрибут виду тварини species.
 * Клас має містити метод, який виводить інформацію про вид тварини, і метод,
 * який виводить характерний звук для даного виду тварини. Створіть два класи Dog і Cat, 
 * які успадковуються від класу Animal (є підкласами для Animal). 
 * 
 * У кожному з підкласів 
 * реалізуйте виклик конструктора надкласу з передачею йому назви виду тварини. 
 * 
 * 
 * Також, у підкласах реалізуйте методи, які перевизначають метод надкласу для відтворення
 * характерного звуку для конкретного виду тварини. 
 * 
 * Визначте окрему функцію show_animal_info, яка приймає об’єкт (екземпляр класу) 
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
        public string Show_species() { 

            return this.species;
                }
        public string Make_sound()
        {

            return this.sound;
        }

        public string Show_animal_info(Animal animal)
        {
            if (animal.species != "animal")
            {
                Console.WriteLine("It is not an animal");
            }
            Show_species();
            Make_sound();
            return "It is animal";
                }
        /*public virtual void animalSound()  
  {
    Console.WriteLine("The animal makes a sound");
  }*/

    }

    public class Dog : Animal
    {
        public Dog(string species, string sound) : base(species, sound)
        {
            Show_species();
            
    }
        static void DogSound()
        {
            Console.WriteLine("woof");
        }
        /* public override void InfoSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }*/
    }
    public class Cat : Animal
    {
        public Cat(string species, string sound) : base(species, sound)
        {
            Show_species();
            
        }
        static void CatSound()
        {
            Console.WriteLine("muau");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal example = new Animal("animal", "sound");
            Dog puppy = new Dog("animal", "woof");
            Cat kitten = new Cat("animal", "muau");
            Console.WriteLine(puppy.Show_animal_info(puppy));
            Console.WriteLine(kitten.Show_animal_info(kitten));
        }
    }
}
