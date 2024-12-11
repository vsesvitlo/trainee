/*Задача 1: Implicit Перетворення
Створіть клас Point, який має два поля: x та y (цілі числа). 
Додайте до класу явне перетворення з типу Point в тип double.
Тобто, при перетворенні об'єкта Point в double,
слід обчислювати відстань від початку координат.*/
using System.ComponentModel;

namespace _10._12._2024___implicit
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static implicit operator double (Point point)
        {
            double resultX = 0 - point.x;
            double resultY = 0 - point.y;
            Point point2 = new Point((int)resultX, (int)resultY);
            return point.x + point.y;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(9, 6);
            Console.WriteLine(point + 3.5);
            Console.WriteLine(point.y.GetType());
        }
    }
}
