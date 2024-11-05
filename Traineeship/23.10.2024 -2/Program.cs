/*Завдання 2: Фігури Створіть базовий клас Shape, який має метод CalculateArea().
 * Створіть класи-нащадки Circle та Rectangle, які
 * наслідують клас Shape та реалізують метод CalculateArea() 
 * для обчислення площі кола та прямокутника відповідно.*/

namespace _23._10._2024__2
{
     public abstract class Shape
    {
       public double x;

        public Shape(double x)
        {
            this.x = x;
        }

        public abstract double CalculateArea();

    }
    public class Circle : Shape
    {
        public double radius;

        public Circle ( double radius) : base(0)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            double area = Math.PI * this.radius * this.radius;
            return area;
        }
    }
    public class Rectangle : Shape
    { 
        public int a;
        public int b;

        public Rectangle(int a, int b) : base(0)
        {
            this.a = a;
            this.b = b;
        }
        public override double CalculateArea()
        {
            int area = this.a * this.b;
            return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape example = new Circle(4);
            Circle circle = new Circle(4); 
            Rectangle rectangle = new Rectangle(8, 6);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculateArea());

        }
    }
}
