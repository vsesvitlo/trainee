/*Збережіть назви мов світу,
 * які вводяться в одному рядку через пропуск, у списку.
 * Виведіть елементи списку в зворотному порядку в рядку через пропуск.

Вхідні дані:

Ukrainian French Bulgarian Norwegian Latvian
Вихідні дані:

Latvian Norwegian Bulgarian French Ukrainian*/
namespace _09._11._2024___409
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Ukrainian", "French", "Bulgarian", "Norwegian", "Latvian" };
            List<string> listExample = new List<string>(input);
            int count = listExample.Count;
        }
    }
}
