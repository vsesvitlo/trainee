/*
class A

Микола Оліфірович, [22/11/2024 12:45]
int x, int y

Микола Оліфірович, [22/11/2024 12:45]
A a1;
A a2;
a1>a2

Микола Оліфірович, [22/11/2024 12:46]
більше те число в якого сума двох чисел більша*/
using System.ComponentModel.DataAnnotations;

namespace _22._11._2024
{
    public class A
    {
        public int x;
        public int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Sum()
        {
            int sum = this.x + this.y;
            return sum;
        }
        public static int Minus1(int x, int y)
        {
            int min = x - y;

            return min;

        }
        public static bool operator > (A a1, A a2){
            if (a1.Sum() > a2.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
            }
        public static bool operator < (A a1, A a2)
        {
            if (a1.Sum() < a2.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >= (A a1, A a2)
        {
            if (a1.Sum() >= a2.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <= (A a1, A a2)
        {
            if (a1.Sum() <= a2.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator == (A a1, A a2)
        {
            if (a1.Sum() == a2.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator != (A a1, A a2)
        {
            if (a1.Sum() != a2.Sum())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(9, 6);
            A a2 = new A(6, 8);
            Console.WriteLine(a1>a2);
        }
    }
}
