/*завдання на ref: 
створити метод який приймає два параметри, 
перший int і другий int (другий із модифікатором ref).
Метод встановлює нове значення для другого параметра - 10. Методі нічого не повертає
*/

using System.Runtime.ExceptionServices;

namespace _24._11._2024___1
{
   
    internal class Program
    {
        public static void RefMethod(int first, ref int second)
        {
            second = 10;

        }
        static void Main(string[] args)
        {
            int first = 9;
            int second = 16;
            RefMethod(12,ref second);
            Console.WriteLine(second);
        }
    }
}
