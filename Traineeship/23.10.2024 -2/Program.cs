/*Завдання 2: Фігури Створіть базовий клас Shape, який має метод CalculateArea().
 * Створіть класи-нащадки Circle та Rectangle, які
 * наслідують клас Shape та реалізують метод CalculateArea() 
 * для обчислення площі кола та прямокутника відповідно.*/

namespace _23._10._2024__2
{
    public class Shape
    {
        double x;

        public Shape(double x)
        {
            this.x = x;
        }

        public virtual string CalculateArea()
        {
            return "area";
        }
    }
    public class Circle : Shape
    {
        double radius;

        public Circle ( double radius) : base(0)
        {
            this.radius = radius;
        }
        public override string CalculateArea()
        {
            double area = Math.PI * this.radius * this.radius;
            return area.ToString();
        }
    }
    public class Rectangle : Shape
    { 
        int a;
        int b;

        public Rectangle(int a, int b) : base(0)
        {
            this.a = a;
            this.b = b;
        }
        public override string CalculateArea()
        {
            int area = this.a * this.b;
            return area.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape example = new Shape(0);
            Circle circle = new Circle(4); 
            Rectangle rectangle = new Rectangle(8, 6);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculateArea());

        }
    }
}
