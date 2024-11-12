/*Виведіть всі елементи списку з парними індексами. 
 * Вводиться список чисел. Всі числа списку знаходяться на одному рядку.

Вхідні дані:

1 2 3 4 5
Вихідні дані:

1 3 5*/

namespace _12._11._2024___411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5 };
            List<int> listExample = new List<int>(input);
            foreach (int i in listExample)
            {
                listExample.Add(i);
            }
            string result = string.Join(" ", listExample);
            Console.WriteLine(result);
        }
    }
}
