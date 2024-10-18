/*Напишіть клас Dog, який має три атрибути класу: mammal (ссавець), nature (характер) і breed (порода),
 * та два атрибути ексземпляра: name (кличка) і age (вік). 
 * 
 * Створіть екземпляри трьох нових собак, 
 * кожна з яких різного віку.
 * 
 * Визначте у класі Dog метод для виведення значень атрибутів екземпляру -
 * імені та віку конкретної собаки. 
 * 
 * За потреби, додайте кілька інших методів, які визначають поведінку собаки
 * (подавання голосу тощо). 
 * 
 * Напишіть кілька класів, які унаслідуються від батьківського класу Dog, 
 * що описують конкретні породи собак.
 * 
 * Визначте для цих класів атрибути nature і breed відповідно, 
 * включіть у класи по одному методу, що визначає поведінку конкретної породи собаки.
 * 
 * 
 * Створіть батьківський клас Pets, що створює список ваших домашніх улюбленців. 
 * 
 * У підсумку, надрукуйте інформацію про ваших домашніх тварин, на зразок, як у вихідних даних.
 
 Вхідні дані:

Немає
Вихідні дані:

I have 3 dogs.
Toby is 4. Kind Golden Retriever breed dog.
Charlie is 6. Tireless Jack Russell Terrier breed dog.
Rocky is 7. Obedient ordinary breed dog.
And they're all mammals, of course*/
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _17._10___819
{
    public class Dog
    {
        public string mammal;
        public string nature;
        public string breed;
        public string name;
        public int age;

        public Dog(string mammal, string nature, string breed, string name, int age)
        {
            this.mammal = mammal;
            this.nature = nature;
            this.breed = breed;
            this.name = name;
            this.age = age;
        }
        /* public string Indrodusing()
         {

             string First = name + age.ToString();
             return First;
         }*/
        public string Introdusing()
        {
            return this.name + " " + this.age.ToString();
        }

        public string DogSound() {
            return this.nature;

        }
        public Dog newPuppy ()
        {
            Dog Puppy = new Dog(this.mammal, this.nature, this.breed, this.name, this.age);
            return Puppy;
        }
        public Dog BreedDescription (Dog Check, string breed)
        {
            if (this.breed != breed) {

                Console.WriteLine("They are not the same breed");
             }
            return Check;
        }


        public string NameDescription(Dog Check)
        {

            return this.name;
        }

        public int AgeDescription(Dog Check)
        {

            return this.age;
        }

        public string NatureDescription()
        {

            return this.nature;
        }

        public string BreedDescription1()
        {
            return this.breed;
        }

        public override string ToString()
        {
            return this.mammal + " " + this.nature + " " + this.breed + " " + this.name + " " + this.age;
        }

    }
    public class Pets
    {
        Dog[] family;

        public Pets(Dog[] family)
        {
            this.family = family;
        }
        public int Calc()
        {
            return family.Length;
        }
    }
    internal class Program
        {
            static void Main(string[] args)
            {
                Dog Phild = new Dog("mammal", "Queit", "metis", "Phild", 7);
                Dog Anica = new Dog("mammal", "Loud", "akita", "Anica", 2);
                Dog Pudge = new Dog("mammal", "Kind", "terrier", "Pudge", 10);
                Console.WriteLine(Phild.Introdusing());
                Console.WriteLine(Anica.DogSound());
                Dog newBorn = Anica.newPuppy();
                Console.WriteLine(newBorn);
                Console.WriteLine(Pudge.BreedDescription(Pudge, "terrier"));
                Console.WriteLine(Pudge.BreedDescription1());
                Console.WriteLine(Pudge.NatureDescription());
                Dog[] family = { Phild,Anica,Pudge };
                Pets first = new Pets(family);
                Console.WriteLine(first.Calc());

            Console.WriteLine($"I have {first.Calc()} dogs.{Phild.name} is {Phild.age}. {Phild.nature} {Phild.breed} breed dog. " +
                $"{Anica.NameDescription(Anica)} is {Anica.AgeDescription(Anica)}. {Anica.NatureDescription()} {Anica.BreedDescription1()} breed dog" +
                $"{Pudge.NameDescription(Pudge)} is {Pudge.AgeDescription(Pudge)}. {Pudge.NatureDescription()} {Pudge.BreedDescription1()} " +
                $"breed dog" +
                $"\"And they're all mammals, of course.");
            /*I have 3 dogs.
Toby is 4. Kind Golden Retriever breed dog.
Charlie is 6. Tireless Jack Russell Terrier breed dog.
Rocky is 7. Obedient ordinary breed dog.
And they're all mammals, of course*/
            

        }
    }

    }
