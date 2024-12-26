using System;
/*Define a method/function that removes from a given array of integers all the values contained in a second array.

Examples (input -> output):
* [1, 1, 2, 3, 1, 2, 3, 4], [1, 3] -> [2, 2, 4]
* [1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8], [1, 3, 4, 2] -> [5, 6, 7, 8]
* [8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2, 3], [2, 4, 3] -> [8, 7, 6, 5, 1]
Enjoy it!!*/
namespace _14._12._2024___array_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 1, 2, 3, 1, 2, 3, 4 };
            int[] num2= { 1, 3 };
            // int[] num1 = { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
            int[] num3 = Kata.Remove(num1, num2);
            //int[] newNum2 = Kata.UpArray(newNum1);
            for (int k = 0; k < num3.Length; k++)
            {
               Console.WriteLine((num3[k]));
            }
            //for (int k = 0; k < newNum2.Length; k++)
            {
                //Console.WriteLine((newNum2[k]));
            }
        }
    }
    public class Kata
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {

            int counterTwice = 0;
            int counter = 0;
            for(int i = 0; i < valuesList.Length; i++)
            {
                for (int j = 0; j < integerList.Length; j++)
                {
                    if (valuesList[i] == integerList[j])
                    {
                        counterTwice++;
                    }
                    
                }
                counter = integerList.Length - counterTwice;
            }
            int[] integerNew = new int[counter];
            int k = 0;
            if (k < counter)
            {

               

                foreach (int l in integerList)
                {
                    bool isNotTrue = true;
                    foreach (int h in valuesList)
                    {
                        if (h == k)
                        {
                            isNotTrue = false;
                            break;
                        }

                    }
                    if (isNotTrue)
                    {
                        integerNew[k] = l;
                        k++;

                    }
                }
            }

            /*for (int j = 0; j < integerList.Length; j++)
            { 
                if (!valuesList.Contains(integerList[j]))
                {
                    integerNew[k] = integerList[j];
                    k++;
                }
            }*/
            return integerNew;
        }
    }
}
