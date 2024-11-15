/*Напишіть програму для підрахунку кількості днів, 
 * в яких температура була не нижче, ніж середня температура за весь період. 
 * У першому рядку вводиться список показників температури на кожен день.
 * У рядку виведення одне число - кількість днів, які відповідають умові.

Вхідні дані:

-3 -1 0 2 6 8 12 15
Вихідні дані:

4*/
namespace _15._11._2024___429
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { -3, -1, 0, 2, 6, 8, 12, 15 };
            List<int> listExample = new List<int>(input);
            int days = 0;
            int total = 0;
            for (int i = 0; i < listExample.Count; i++)
            {
                total += listExample[i];
                
            }
            int average = total/ listExample.Count;
            for (int j = 0; j < listExample.Count; j++)
            {
                if(listExample[j] > average)
                {
                    days++;
                }
            }
            Console.WriteLine(days);
        }
    }
}
