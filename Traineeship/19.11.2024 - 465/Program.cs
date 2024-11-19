/*Дано список з чисел та індекс елемента в списку k.
 * Видаліть зі списку елемент з індексом k, зсунувши вліво всі елементи, 
 * що стоять правіше елемента з індексом k. Програма отримує на вхід список, 
 * потім число k. Програма повинна здійснювати зміщення безпосередньо в списку,
 * а не робити це при виведенні елементів. Також не можна використовувати додатковий список.

Вхідні дані:

5 7 9 0 3 11
3
Вихідні дані:

5 7 9 3 11*/
namespace _19._11._2024___465
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int [] input = { 5, 7, 9, 0, 3, 11 };
            List<int> listExample = new List<int>(input);

            for (int i = 0; i < input.Length; i++)
            {
                listExample.Remove(input[k]);

            }
                string result = string.Join(" ", listExample);

                Console.WriteLine(result);

        }
    }
}
