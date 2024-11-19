/*Для введеної послідовності цілих чисел обміняйте сусідні 
 * елементи у парах (A[0] з A[1], A[2] з A[3] і т. д.).
 * Надрукуйте отриманий список. Якщо в списку є непарне число елементів, залиште останній елемент на місці.

Вхідні дані:

1 4 5 3 7
4 2 10 5
2
Вихідні дані:

4 1 3 5 7
2 4 5 10
2*/

namespace _18._11._2024___448
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 4, 5, 3, 7 };
            int[] input2 = { 4, 2, 10, 5 };
            int[] input3 = { 2 };

            List<int> listExample1 = new List<int>(input1);
            List<int> listExample2 = new List<int>(input2);
            List<int> listExample3 = new List<int>(input3);

            List<int> listExampleNew1 = new List<int>();
            List<int> listExampleNew2 = new List<int>();
            List<int> listExampleNew3 = new List<int>();
            if (listExample1.Count %2 == 0){
                for (int i = 0; i < input1.Length-1; i+=2)
                {
                        int a = input1[i];
                        int b = input1[i+1];
                        listExampleNew1.Add(b);
                        listExampleNew1.Add(a);

                }
                
            }
            else {
                for (int i = 0; i < input1.Length - 1; i += 2)
                {
                    int a = input1[i];
                    int b = input1[i + 1];
                    listExampleNew1.Add(b);
                    listExampleNew1.Add(a);

                }
                listExampleNew1.Add(input1[input1.Length - 1]);
            }
            
            if (listExample2.Count % 2 == 0)
            {
                for (int i = 0; i < input2.Length - 1; i += 2)
                {
                    int a = input2[i];
                    int b = input2[i + 1];
                    listExampleNew2.Add(b);
                    listExampleNew2.Add(a);

                }
               
            }
            else
            {
                for (int i = 0; i < input2.Length - 1; i += 2)
                {
                    int a = input2[i];
                    int b = input2[i + 1];
                    listExampleNew2.Add(b);
                    listExampleNew2.Add(a);

                }
                listExampleNew2.Add(input2[input2.Length - 1]);
            }
            
            if (listExample3.Count % 2 == 0)
            {
                for (int i = 0; i < input3.Length - 1; i += 2)
                {
                    int a = input3[i];
                    int b = input3[i + 1];
                    listExampleNew3.Add(b);
                    listExampleNew3.Add(a);

                }
               
            }
            else
            {
                for (int i = 0; i < input3.Length - 1; i += 2)
                {
                    int a = input3[i];
                    int b = input3[i + 1];
                    listExampleNew3.Add(b);
                    listExampleNew3.Add(a);

                }
                listExampleNew3.Add(input3[input3.Length - 1]);

            }
            

            string result1 = string.Join(" ", listExampleNew1);
            Console.WriteLine(result1);
            string result2 = string.Join(" ", listExampleNew2);
            Console.WriteLine(result2);
            string result3 = string.Join(" ", listExampleNew3);
            Console.WriteLine(result3);
        }
    }
}
