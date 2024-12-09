/*завдання на оператори перетворення типів(explicit, implicit):
Створіть програму для моделювання перетворення між двома класами: 
Temperature (температура в градусах Цельсія) і Fahrenheit (температура в градусах Фаренгейта).

 Реалізуйте клас Temperature, який зберігає значення температури у градусах Цельсія.
Реалізуйте клас Fahrenheit, який зберігає значення температури у Фаренгейтах.
Реалізуйте:
Оператор explicit для явного перетворення між Temperature та Fahrenheit.
Оператор implicit для неявного перетворення між Fahrenheit та Temperature.
Додайте методи для виводу значень температури в обох форматах.*/

using _01._12._2024___explicit__implicit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _01._12._2024___explicit__implicit
{
    public class Temperature
    {
        public double temperature;

        public Temperature(double temperature)
        {
            temperature = this.temperature;
        }

        public static double ConvertFar(double temp)
        {
            double result = (temp * 9 / 5) + 32;

            return result;
        }
        public static double ConvertCelsius(double far)
        {
            double result = (far - 32) * 5 / 9;

            return result;
        }


    }

    public class Celsuis : Temperature
    {
        public Celsuis() : base(0)
        {
            ConvertFar(0);
        }
        public static explicit operator double(Celsuis c)
        {
            return c.temperature;
        }
        /*public override string ToString()
        {
            return Celsuis.ToString();
        }*/
    }
    public class Fahrenheit : Temperature
    {
        public Fahrenheit() : base(0)
        {
            ConvertCelsius(0);
        }
        public static implicit operator double(Fahrenheit f)

        {
            return f.temperature;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Temperature temperature = new Temperature(32);
            Celsuis celsuis = new Celsuis();
            Fahrenheit fahrenheit = new Fahrenheit();
            double cel = 89.6;
            double cel2 = 0;
            double far = 0;
            Console.WriteLine(Celsuis.ConvertFar(cel));
            Console.WriteLine(Celsuis.ConvertFar(cel2));
            Console.WriteLine(Fahrenheit.ConvertCelsius(far));
        }
    }

}