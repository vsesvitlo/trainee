/*Завдання 1: Транспортні засоби Створіть базовий клас Vehicle,
 * який містить властивості для швидкості та моделі. 
 * Створіть два похідні класи: Car та Bicycle.
 * У класі Car додайте властивість для кількості дверей,
 * а в класі Bicycle — для кількості передач. 
 * Реалізуйте метод DisplayInfo(), який виводить інформацію про транспортний засіб.
*/

namespace _19._10._2024___1
{
    public class Vechicle
    {
        double speed;
        string model;


        public Vechicle(double speed, string model)
        {
            this.speed = speed;
            this.model = model;

        }
        public virtual string DisplayInfo()
        {

            return this.speed.ToString() + " " + this.model;
        }
        public override string ToString()
         {
             return this.speed + " " + this.model;
         }

    }
        public class Car : Vechicle
        {
            int quantityDoors;


            public Car(int doors) : base(0, "model")
            {
                DisplayInfo();
                this.quantityDoors = doors;
            }

        public override string DisplayInfo()
        {
            return this.quantityDoors.ToString();// + this.speed.ToString() + " " + this.model; 
        }

    }

        public class Bicycle : Vechicle
        {
            int speedVariations;


            public Bicycle(int variations) : base(0, "brand")
            {
                DisplayInfo();
                this.speedVariations = variations;
            }

        public override string DisplayInfo()
        {

            return this.speedVariations.ToString();
        }
        }
    

        internal class Program
        {
            static void Main(string[] args)
            {
                Vechicle example = new Vechicle(0, "vechicle");
                Car car = new Car(4); //200, "Nissan X-Trail",
                Bicycle bicycle = new Bicycle(3);
                Console.WriteLine(car.DisplayInfo());
                Console.WriteLine(bicycle.DisplayInfo());


            }
        }
    }
