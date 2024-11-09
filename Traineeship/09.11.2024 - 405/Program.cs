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
        public void Cut1()
        {
            int count = lists.Count;
            if (count % 2 == 1)
            {
                count++;
            }
            int index = count / 2;

            lists.Slice(0, index - 1);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 7, 2, 1, 0, 4, 2, 5 };
            List<int> listExample1 = new List<int>(input1);
            ListAverage listAverage1 = new ListAverage(listExample1);
         
                int count = listExample1.Count;
                if (count % 2 == 1)
                {
                    count++;
                }
                int index = count / 2;

                listExample1 = listExample1.Slice(index - 1, index);
            
            //listAverage1.Cut1();

            foreach (int item in listExample1)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(listExample1.LongCount());
           // Console.WriteLine(listAverage1);

            int[] input2 = { 7, 2, 1, 0, 4, 2 };
            List<int> listExample2 = new List<int>(input2);
            ListAverage listAverage2 = new ListAverage(listExample2);

            int count2 = listExample2.Count;
            if (count2 % 2 == 1)
            {
                count2 ++;
            }
            int index2 = count2 / 2;

            listExample2 = listExample2.Slice(index2, index2);//??
            foreach (int item in listExample2)
            {
                Console.WriteLine(item);
            }
            // Console.WriteLine(listExample2.LongCount());
        }
    }
}
