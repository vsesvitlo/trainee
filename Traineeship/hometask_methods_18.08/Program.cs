//ThirdFromMac( [1, 2, 5, 1, 3, 4, 1, 14]; [ 4, 3, 4, 4, 1, 8, 2, 9 ]);

//Є два масива. Створити третій масив який буде розміром таким же як і перший і другий. Але елементи в ньому
//будуть масимальні. Приклад
//int[] masA = { 1, 2, 5, 1, 3, 4, 1, 14};
//int[] masB = { 4, 3, 4, 4, 1, 8, 2, 9 };
//int[] masC = { 4, 3, 5, 4, 3, 8, 2, 14 };  // Завдання в тому щоб третій масив мав максимальнів відповідні елементи. 
// Тобто беремо елементи з індексом 0. В перешому масиві це число 1, в другому масиві це число 4. Чотири більше за 1,
// тому беремо 4. 
// Беремо число з індексом 1. В першому масиві це число 2, в другому це число 3. Число три більше за 2 тому беремо 3. +

//1. Метод який приймає масив чисел і масив стрінгів. Числа це мілісекунди затримки за
//якими будуть виведені слова на екран. Нариклад для таких даних 
//{ 400, 300, 1000}
//{ "Hello", " how do ", "you do?"}
//після запуску програми через 400 мілісекунд виведеться "Hello", після цього через 300 мілісекунд виведеться "how do",
//і потім через 1000 мілісекунд (1 сек) виведеться останнє. +
//2.Метод який повертає масив інтів. Метод пропонує користувачу ввести 5 int і записує їх в масив +
//3. Метод який повертає масив стрінгів. Метод пропонує користувачу ввести 5 string і записує їх в масив. +
// 4. Використавши 3 верхні методи зробіть один метод який буде пропонувати користувачу вводити часові діапазони і текст,
//а потім їх виводити +

static int[] ThirdFromMac( int[] first, int[] second)
{
    int[] result = new int[first.Length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Max(first[i], second[i]);
        Console.WriteLine(result[i]);
    }

    return result;
};

ThirdFromMac( new int[] { 1, 2, 5, 1, 3, 4, 1, 14 }, new int[] { 4, 3, 4, 4, 1, 8, 2, 9 });

static void Collab(int[] ints, string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        Thread.Sleep(ints[i]);
        Console.WriteLine(words[i]);

    }
};
Collab(new int[] { 2000, 3000, 4000 }, new string[] { "Hello", " how do ", "you do?" });


static int[] Add(int n)
{
    int[] result = new int[n];
    string fromUser = "";
    int numFromUser = 0;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Please, enter number from 0 to 99");
        fromUser = Console.ReadLine();
        numFromUser = Convert.ToInt32(fromUser);
        result[i] = numFromUser;
        Console.WriteLine(result[i].GetType());
    }
    return result;
};
Add(5);

static string[] AddString(int n)
{
    string[] result = new string[n];
    string fromUser = "";
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Please, enter something, 1 word per 1 time");
        fromUser = Console.ReadLine();
        result[i] = fromUser;
        Console.WriteLine(result[i].GetType());
    }
    return result;
};
AddString(5);

static void Result()
{
    Collab(Add(5), AddString(5));
};
Result();