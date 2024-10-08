/*Напишіть клас, який має як мінімум два методи: 
 *  перший - отримати рядок з вводу консолі, другий - друкувати рядок у верхньому регістрі.

Вхідні дані:

python
Вихідні дані:

PYTHON*/

namespace _08._10._2024___812
{
    public class Text
    {
        string text;

        public Text(string text)
        {
            this.text = text;
        }

        public string GetInfo()
        {
            Console.WriteLine("Please, enter the phrase");
            string step1 = Console.ReadLine();
            return step1;
        }
        public string ForUpperCase()
        {
           return GetInfo().ToUpper();
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Please, enter the n");
           //string step1 = Console.ReadLine();
            
            Text text = new Text("");
            //Console.WriteLine(text.GetInfo());
            Console.WriteLine(text.ForUpperCase());
        }
    }
}
