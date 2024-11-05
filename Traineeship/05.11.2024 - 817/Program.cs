/*Напишіть клас Car, який надає для створених екземплярів такі атрибути даних автомобіля:
 * марку виготовлення автомобіля, модель автомобіля, рік автомобіля, 
 * швидкість (початкове значення 0). Клас також повинен мати наступні методи: 
 * accelerate (метод повинен щоразу додавати 5 до значення атрибуту даних про швидкість), 
 * brake (метод повинен віднімати 5 від значення атрибута даних швидкості кожного разу, 
 * коли він викликається), 
 * get_speed (метод повинен повернути поточну швидкість). 
 * Створіть екземпляр класу Car і викличте метод accelerate п’ять разів. 
 * Після кожного виклику методу accelerate отримайте поточну швидкість автомобіля і 
 * надрукуйте її значення. Потім викличте метод brake п’ять разів.
 * Після кожного виклику методу brake отримайте поточну швидкість автомобіля та надрукуйте її значення.
Вихідні дані:

Characteristics of the car:
Citroen c3 2018
Car accelerates:
Current speed: 5
Current speed: 10
Current speed: 15
Current speed: 20
Current speed: 25
Car slows down:
Current speed: 20
Current speed: 15
Current speed: 10
Current speed: 5
Current speed: 0
Car stopped
*/

namespace _05._11._2024___817
{
    public class Car
    {
        public string type_brand;
        public string model;
        public int year;
        public double speed;

        public Car(string type_brand, string model, int year, double speed = 0)
        {
            this.type_brand = type_brand;
            this.model = model;
            this.year = year;
            this.speed = speed;
        }

        public string Characteristics()
        {
            return "Characteristics of the car:\r\n " + this.type_brand + " " + this.model + " " + this.year;
        }
        public void Accelerate() {
            speed =  this.speed + 5;
        }
        public void Brake()
        {
            speed = this.speed - 5;
        }
        public string GetSpeed()
        {
            return "Current speed: " + this.speed;
        }
    }

    internal class Program
    {
        
            static void Main(string[] args)
            {
                Car newCar = new Car("Citroen", "c3", 2018);
                Console.WriteLine(newCar.Characteristics());

                newCar.Accelerate();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Accelerate();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Accelerate();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Accelerate();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Accelerate();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Brake();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Brake();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Brake();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Brake();
                Console.WriteLine(newCar.GetSpeed());
                newCar.Brake();
                Console.WriteLine(newCar.GetSpeed());

            }
        
    }
}
