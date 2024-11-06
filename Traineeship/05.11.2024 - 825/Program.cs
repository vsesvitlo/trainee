/*Напишіть клас для перетворення десяткового числа в число в римській системі числення.

Вхідні дані:

111
99
25
Вихідні дані:

XCIX
CXI
XXV

 Here I represents 1,
V represents 5,
X represents 10,
L represents 50, 
C represents 100,
D represents 500,
and M represents 1000.*/
namespace _05._11._2024___825
{
    public class Numb
    {
        private int n;

        public Numb(int n)
        {
            this.n = n;
        }
        public string Conv()
        {
            string forCalc = n.ToString();
            string result1 = "";
            string result2 = "";
            string result3 = "";
            string result4 = "";
            string result = "";
            //for (int i =0; i < forCalc.Length; i++)
            
            if (forCalc.Length == 4)
            {
                int d = int.Parse(forCalc[forCalc.Length - 3].ToString());
                int c = int.Parse(forCalc[forCalc.Length - 2].ToString());
                int b = int.Parse(forCalc[forCalc.Length - 2].ToString());
                int a = int.Parse(forCalc[forCalc.Length - 1].ToString());
                if (a == 1)
                {
                    result1 += "I";
                }
                else if (a == 2)
                {
                    result1 += "II";
                }
                else if (a == 3)
                {
                    result1 += "II";
                }
                else if (a == 4)
                {
                    result1 += "IV";
                }
                else if (a == 5)
                {
                    result1 += "V";
                }
                else if (a == 6)
                {
                    result1 += "VI";
                }
                else if (a == 7)
                {
                    result1 += "VII";
                }
                else if (a == 8)
                {
                    result1 += "VIII";
                }
                else if (a == 9)
                {
                    result1 += "IX";
                }
                if (b == 1)
                {
                    result2 += "X";
                }
                else if (b == 2)
                {
                    result2 += "XX";
                }
                else if (b == 3)
                {
                    result2 += "XXX";
                }
                else if (b == 4)
                {
                    result2 += "XL";
                }
                else if (b == 5)
                {
                    result2 += "L";
                }
                else if (b == 6)
                {
                    result2 += "LX";
                }
                else if (b == 7)
                {
                    result2 += "LXX";
                }
                else if (b == 8)
                {
                    result2 += "LXXX";
                }
                else if (b == 9)
                {
                    result2 += "XC";
                }
                if (c == 1)
                {
                    result3 += "C";
                }
                else if (c == 2)
                {
                    result3 += "CC";
                }
                else if (c == 3)
                {
                    result3 += "CCC";
                }
                else if (c == 4)
                {
                    result3 += "CD";
                }
                else if (c == 5)
                {
                    result3 += "D";
                }
                else if (c == 6)
                {
                    result3 += "DC";
                }
                else if (c == 7)
                {
                    result3 += "DCC";
                }
                else if (c == 8)
                {
                    result3 += "DCCC";
                }
                else if (c == 9)
                {
                    result3 += "CM";
                }
                if (d == 1)
                {
                    result4 += "M";
                }
                else if (d == 2)
                {
                    result3 += "MM";
                }
                else if (d == 3)
                {
                    result3 += "MMM";
                }
                else if (d == 4)
                {
                    result3 += "IV";
                }
                else if (d == 5)
                {
                    result3 += "V";
                }
                else if (d == 6)
                {
                    result3 += "VM";
                }
                else if (d == 7)
                {
                    result3 += "VMM";
                }
                else if (d == 8)
                {
                    result3 += "VMMM";
                }
                else if (d == 9)
                {
                    result3 += "IX";
                }
                result = result4 + result3 + result2 + result1;
            }
            if (forCalc.Length == 3)
            {
                int c = int.Parse(forCalc[forCalc.Length - 2].ToString());
                int b = int.Parse(forCalc[forCalc.Length - 2].ToString());
                int a = int.Parse(forCalc[forCalc.Length - 1].ToString());
                if (b == 1)
                {
                    result2 += "X";
                }
                else if (b == 2)
                {
                    result2 += "XX";
                }
                else if (b == 3)
                {
                    result2 += "XXX";
                }
                else if (b == 4)
                {
                    result2 += "XL";
                }
                else if (b == 5)
                {
                    result2 += "L";
                }
                else if (b == 6)
                {
                    result2 += "LX";
                }
                else if (b == 7)
                {
                    result2 += "LXX";
                }
                else if (b == 8)
                {
                    result2 += "LXXX";
                }
                else if (b == 9)
                {
                    result2 += "XC";
                }
                if (a == 1)
                {
                    result1 += "I";
                }
                else if (a == 2)
                {
                    result1 += "II";
                }
                else if (a == 3)
                {
                    result1 += "II";
                }
                else if (a == 4)
                {
                    result1 += "IV";
                }
                else if (a == 5)
                {
                    result1 += "V";
                }
                else if (a == 6)
                {
                    result1 += "VI";
                }
                else if (a == 7)
                {
                    result1 += "VII";
                }
                else if (a == 8)
                {
                    result1 += "VIII";
                }
                else if (a == 9)
                {
                    result1 += "IX";
                }
                if (c == 1)
                {
                    result3 += "C";
                }
                else if (c == 2)
                {
                    result3 += "CC";
                }
                else if (c == 3)
                {
                    result3 += "CCC";
                }
                else if (c == 4)
                {
                    result3 += "CD";
                }
                else if (c == 5)
                {
                    result3 += "D";
                }
                else if (c == 6)
                {
                    result3 += "DC";
                }
                else if (c == 7)
                {
                    result3 += "DCC";
                }
                else if (c == 8)
                {
                    result3 += "DCCC";
                }
                else if (c == 9)
                {
                    result3 += "CM";
                }
                result = result3 + result2 + result1;
            }
           
            if (forCalc.Length == 2)
            {
                int b = int.Parse(forCalc[forCalc.Length - 2].ToString());
                int a = int.Parse(forCalc[forCalc.Length - 1].ToString());
                if (a == 1)
                {
                    result1 += "I";
                }
                else if (a == 2)
                {
                    result1 += "II";
                }
                else if (a == 3)
                {
                    result1 += "II";
                }
                else if (a == 4)
                {
                    result1 += "IV";
                }
                else if (a == 5)
                {
                    result1 += "V";
                }
                else if (a == 6)
                {
                    result1 += "VI";
                }
                else if (a == 7)
                {
                    result1 += "VII";
                }
                else if (a == 8)
                {
                    result1 += "VIII";
                }
                else if (a == 9)
                {
                    result1 += "IX";
                }
                if (b == 1)
                {
                    result2 += "X";
                }
                else if (b == 2)
                {
                    result2 += "XX";
                }
                else if (b == 3)
                {
                    result2 += "XXX";
                }
                else if (b == 4)
                {
                    result2 += "XL";
                }
                else if (b == 5)
                {
                    result2 += "L";
                }
                else if (b == 6)
                {
                    result2 += "LX";
                }
                else if (b == 7)
                {
                    result2 += "LXX";
                }
                else if (b == 8)
                {
                    result2 += "LXXX";
                }
                else if (b == 9)
                {
                    result2 += "XC";
                }


                result = result2 + result1;
            }
            
            if (forCalc.Length == 1)
            {
                int a = int.Parse(forCalc[forCalc.Length - 1].ToString());
                if (a == 1)
                {
                    result1 += "I";
                }
                else if (a == 2)
                {
                    result1 += "II";
                }
                else if (a == 3)
                {
                    result1 += "II";
                }
                else if (a == 4)
                {
                    result1 += "IV";
                }
                else if (a == 5)
                {
                    result1 += "V";
                }
                else if (a == 6)
                {
                    result1 += "VI";
                }
                else if (a == 7)
                {
                    result1 += "VII";
                }
                else if (a == 8)
                {
                    result1 += "VIII";
                }
                else if (a == 9)
                {
                    result1 += "IX";
                }
                result = result1;
            }
           
            return result;
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Numb first = new Numb(111);
            first.Conv();
            Numb second = new Numb(99);
            second.Conv();
            Numb third = new Numb(25);
            third.Conv();
            Console.WriteLine(first.Conv());
            Console.WriteLine(second.Conv());
            Console.WriteLine(third.Conv());
        }
    }
}
