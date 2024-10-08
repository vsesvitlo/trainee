using System;

namespace _04._10._2024__809_1
{
    internal class Program
    {

        /*Напишіть клас з назвою Circle для обчислення площі
          * круга за введеним радіусом. Клас Circle має містити метод, 
          * який обчислює площу круга.

Вхідні дані:

3
Вихідні дані:

28.26
            */

       
    }
    class Circle
    {
        public double radius;

        public Circle(double n) {
            radius = n;
                }
        public double CircleCalc()
        {

            return Math.Round((Math.PI * radius * radius), 2);
        }
    }

    class CalcCircle {
        static void Main(string[] args)
        {
            Circle square = new Circle(3);
            Console.WriteLine(square.CircleCalc());

        }
    } 
}
