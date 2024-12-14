using System;

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
               // Console.WriteLine((num3[k]));
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

            int counter = 0;
            int j = 0;
            int o = 0;
            for (int i = 0; i < integerList.Length; i++)
            {

                if ( integerList[i] == valuesList[j]) //&& j < valuesList.Length)
                {
                    counter++;
                  
                }
            }
            j++;
            int[] integerNew = new int[counter];
            Console.WriteLine(counter) ;
            int m = 0;
            for (int k = 0; k < integerList.Length; k++)
            {
                if ( m < counter)
                {
                    if (integerList[k] != valuesList[o])
                    {
                        integerNew[m] = integerList[k];
                        //Console.WriteLine(integerNew[m]);
                    }
                    Console.WriteLine(integerNew[m]);
                }
             
                m++;
            }
            o++;
            
            return integerNew;
        }
    }
}
