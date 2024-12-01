/*завдання на оператори перетворення типів(explicit, implicit):
Створіть програму для моделювання перетворення між двома класами: 
Temperature (температура в градусах Цельсія) і Fahrenheit (температура в градусах Фаренгейта).

 Реалізуйте клас Temperature, який зберігає значення температури у градусах Цельсія.
Реалізуйте клас Fahrenheit, який зберігає значення температури у Фаренгейтах.
Реалізуйте:
Оператор explicit для явного перетворення між Temperature та Fahrenheit.
Оператор implicit для неявного перетворення між Fahrenheit та Temperature.
Додайте методи для виводу значень температури в обох форматах.*/

namespace _01._12._2024___explicit__implicit
{
    class Temperature
    {
        public double Celsuis;

        public Temperature(double celsuis)
        {
            Celsuis = celsuis;
        }
    }
    public class Fahrenheit
    {
        public double Fahr;

        public Fahrenheit(double fahrenheit)
        {
            Fahr = fahrenheit;
        }
    }
    public static explicit operator double Temperature () { return ; }
    public static implicit operator double (исходный_тип v) { return значение; }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
