/*Створіть список на основі введеної послідовності цілих чисел і
 * надрукуйте другу половину списку як у вихідних даних.

Вхідні дані:

7 2 1 0 4 2 5
7 2 1 0 4 2

 Вихідні дані:

0 4 2 5
0 4 2*/
namespace _09._11._2024___405
{
    public class ListAverage
    {
        public List<int> lists;

        public ListAverage(List<int> lists)
        {
            this.lists = lists;
        }
        public void Cutting()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] input1 = { 7, 2, 1, 0, 4, 2, 5 };

            List<int> listExample1 = new List<int>(input1);

            int[] input2 = { 7, 2, 1, 0, 4, 2 };

            List<int> listExample2 = new List<int>(input2);
        }
    }
}
