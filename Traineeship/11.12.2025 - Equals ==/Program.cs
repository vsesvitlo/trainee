/* Задача 3: Порівняння з Equals і ==
Створіть клас Car з полями Make та Model. 
Реалізуйте як перевизначення методу Equals, 
так і оператора ==, щоб правильно порівнювати два об'єкти Car.*/
namespace _11._12._2025___Equals___
{
    public class Car
    {
        public string Make;
        public string Model;

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }
        public static bool Checking(Car car1, Car car2)
        {
            if (car1.Make == car2.Make && car1.Model == car2.Make)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator == (Car car1, Car car2)
        {

            if (car1.Make == car2.Make && car1.Model == car2.Make)
            {
                return true;
            }
            return false;
        }
        public static bool operator != (Car car1, Car car2)
        {
            if (car1.Make != car2.Make || car1.Model != car2.Make)
            {
                return true;
            }
            return false;
        }

        public virtual bool Equals(Car car)
        {
            if (this.Make == car.Make && this.Model == car.Model)
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
              
        }
    }
}
