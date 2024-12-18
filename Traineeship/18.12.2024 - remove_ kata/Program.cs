/*Remove odd number continuous exclamation marks and question marks(from the left to the right), 
 * until no continuous exclamation marks and question marks exist. Please note: 
 * One exclamation mark or question mark 
 * is not a continuous exclamation marks or question marks. The string only contains ! and ?.
 remove("") === ""
remove("!") === "!"
remove("!!") === "!!"
remove("!!!") === ""
remove("!??") === "!??"
remove("!???") === "!"
remove("!!!??") === "??"
remove("!!!???") === ""
remove("!??") === "!??"
remove("!???!!") === ""
("!???!!" --> "!!!" --> "")
remove("!????!!!?") === "!"
("!????!!!?" --> "!?????" --> "!")
 */

namespace _18._12._2024___remove__kata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "!????!!!?";
            string result = Kata.Removing(s);
            Console.WriteLine(result);
        }
    }
    public class Kata
    {
        public static string Removing (string str)
        {

            
            while (str.Length > 2)
            {
                int e = 0;
                int q = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 33)
                    {
                        e++;
                        if (q > 1 && q % 2 == 1)
                        {
                            str = str.Substring(0, i - q) + str.Substring(i);
                            break;
                        }
                        q = 0;
                    }
                    if (str[i] == 63)
                    {
                        q++;
                        if (e > 1 && e % 2 == 1)
                        {
                            str = str.Substring(0, i - e) + str.Substring(i);
                            break;
                        }
                        e = 0;
                    }

                }
                if (q > 1 && q % 2 == 1)
                {
                    str = str.Substring(0, str.Length - q);
                    
                }

                if (e > 1 && e % 2 == 1)
                {
                    str = str.Substring(0, str.Length - e);
                }

            }

            return str;
        }
    }
}
