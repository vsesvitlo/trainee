
/*Монокарп работает над своим новым сайтом, и сейчас он пытается заставить пользователей выбирать надежные пароли.

Монокарп решил, что надежные пароли должны удовлетворять следующим условиям:

пароль должен состоять только из строчных латинских букв и цифр;
не должно быть цифр, идущих после буквы (то есть, после каждой буквы следует либо другая буква, либо конец строки);
все цифры должны быть отсортированы в неубывающем порядке;
все буквы должны быть отсортированы в неубывающем порядке.
Обратите внимание, что разрешено, чтобы пароль состоял только из букв или только из цифр.

Монокарпу удалось реализовать первое условие, но он не справляется с оставшимися. Можете ли вы помочь ему проверить пароли?

Входные данные
В первой строке записано одно целое число t
 (1≤t≤1000
) — количество наборов входных данных.

В первой строке каждого набора входных данных записано одно целое число n
 (1≤n≤20
) — длина пароля.

Во второй строке записана строка, состоящая из ровно n
 символов. Каждый символ является либо строчной латинской буквой, либо цифрой.

Выходные данные
Для каждого набора входных данных выведите «YES», если данный пароль является надежным, и «NO» в противном случае.

Пример*/namespace _17._10._2024___codeforce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the t - the quantity of passwords");
            string step1 = Console.ReadLine();
            int t = int.Parse(step1);


            Console.WriteLine("Please, enter the n - the length of future password");
            string step2 = Console.ReadLine();
            int n = int.Parse(step1);


            Console.WriteLine("Please, enter the password with n-length - it could be numbers or/and latin letters are available." +
                "It should not be numbers after letters." +
                "All the numbers and letters should be sorted in the increasing order");
            string step3 = Console.ReadLine();
            //int p = int.Parse(step1);
            for(int k = 0; k <= n; k++)
            {
                
                if ((t >= 1) && (t <= 1000) && (n >= 1) && (n <= 20))
                {
                    for (int i = 0; i < step3.Length; i++)
                    {
                        if (((step3[i] >= 97) && (step3[i] <= 122)) || ((step3[i] >= 30) && (step3[i] <= 39)))
                        {
                            for (int j = 1; j <= step3.Length - 1; j++)
                            {
                                if (step3[i] <= step3[j])
                                {
                                    Console.WriteLine("YES");
                                }
                            }
                        }

                    }
                }
            }
            
            Console.WriteLine("NO");
        }
    }
}
