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
    class Temperature
    {
        public double Celsuis;

        public Temperature(double celsuis)
        {
            Celsuis = celsuis;
        }

        public static double ConvertFar(double temp)
        {
            double result = (temp * 9 / 5) + 32;

            return result;
        }

        public static explicit operator double(Temperature c)
        {
            return c.Celsuis; 
        }
        public override string ToString()
        {
            return .ToString();
        }

    }
}
    public class Fahrenheit
    {
        public double Fahr;

    public Fahrenheit(double fahrenheit)
    {
        Fahr = fahrenheit;
    }
    public static double ConvertCelcius(double far)
    {
        double result = ( far - 32) * 5 / 9;

        return result;
    }
   
    
    public static implicit operator double(Fahrenheit f)

    {
       return f.Fahr;
    }
}
    
    internal class Program
    {
        static void Main(string[] args)
        {
        Temperature temperature = new Temperature(32);
        Fahrenheit fahrenheit = new Fahrenheit(89.6);
        double result1 = ConvertFar(fahrenheit);
        Console.WriteLine(temperature.
            );
        }
    }
}
