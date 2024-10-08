/*Напишіть клас під назвою Rectangle для визначення площі прямокутника 
 * за введеними довжиною та шириною сторін. Клас прямокутника має містити метод, 
 * який обчислює площу прямокутника.

Вхідні дані:

2
3
Вихідні дані:

6
*/

namespace _08._10._2024___810_1
{
    internal class Program
    {
        class Rectangle
        {
            public int a;
            public int b;

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public int Calculation()
            {
                return a * b;
            }
        }
        
        class CalcCircle
        {
            static void Main(string[] args)
            {
                Rectangle rectangleResult = new Rectangle(2, 3);
                Console.WriteLine(rectangleResult.Calculation());

            }
        }
    }
}
