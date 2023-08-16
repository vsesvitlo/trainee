
//На методи: 
//1.Метод який бере три числа і повертає їх добуток +

//2. Метод який приймає одне число і повертає його квадрат +

//3. Метод який генерує рандомне число від 1 до 6. (Random random = new Random(); random.next(1, 20); 
//-подивіться в документації і прикладах як це працює) +

//4.Метод який нічого не приймає, а генерує а масив чисел {1,3,5,7}; +

//5.Метод який приймає масив і повертає суму всіх елементів. +

//6. Метод який прймає масив і просто виводить його на екран, нічого не повертає +

//7. Метод який приймає будь яку кількість аргументів типу int (не масив,
//гляньте що таке params в методах, це ключове слово допомагає зробити).
//Приймає багато int повертає суму +

//8. Метод який приймає число double а повертає з нього int врізаний вниз.
//Тобто якщо було 3,5 то верне 3. Якщо було 9,999 то поверне 9. Якщо було -3,1 то поверне -4. +

//9. Метод який приймає в себе строчку, повретає із неї кілкьість символів. +

//10. Метод який приймає строчку і повертає таку ж строчку тільки втричі більшу зліплену разом.
//Наприклад на вході було "Hi!" то на виході буде "Hi!Hi!Hi!Hi!" +

//1
static int Multiplication(int a, int b, int c)
{
    int multiplication = a * b * c;
    //Console.WriteLine(multiplication);
    return multiplication;

}
Multiplication(3, 6, 8);

//2
static int TransformationSquare(int x)
{
    double tranformation = Convert.ToInt32(x);
    double squareTransformation = Math.Pow(x, 2);
    int result = Convert.ToInt32(squareTransformation);
    //Console.WriteLine(result);
    return result;
}
TransformationSquare(7);


//3
static int RandomNumber()
{
    var randomNum = new Random();
    // Console.Write(randomNum.Next(0, 6));
    //Console.WriteLine();
    return randomNum.Next(0, 6);
}
RandomNumber();

//4
static Array RowNumber()
{
    int[] RowNumber = new int[4];

    int calculation = 1;
    for (int j = 0; j < 4; j++)
    {
        RowNumber[j] = calculation;
        calculation += 2;
        //  Console.WriteLine(RowNumber[j]);
    }
    return RowNumber;
}
RowNumber();

//int[] array = { 5, 8, 9, 3 }; int[] num = new int[4] { 6, 7, 9, 1 };int[] theArray = { 1, 3, 5, 7, 9 };
//PrintArray(theArray);

//5
int[] array = { 5, 8, 9, 3 };
static int SumAllElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        //Console.WriteLine(sum);
    }
    return sum;
};
SumAllElements(array);

//6
int[] arrayToShow = { 4, 9, 6, 98 };
static void Show(int[] arrayToShow)
{
    foreach (int i in arrayToShow)
    {
          Console.WriteLine("{0} ", i);
    }
};
Show(arrayToShow);

//7

static void SeparateNumbers(params int[] someAmount)
{
    int sum = 0;
    foreach (int i in someAmount)
    {
        sum += i;
        //return sum; ?
    }
    // Console.WriteLine(sum);

};
SeparateNumbers(1, 8, 7, 66);



//8

static int ToDoubleAndMore(double a)
{
    int aToInt = Convert.ToInt32(a);
    decimal aToDecimal = Convert.ToDecimal(aToInt);
    decimal aToRound = Math.Round(aToDecimal - 1);
    int aToIntResult = Convert.ToInt32(aToRound);
    //Console.WriteLine(aToIntResult);
    return aToIntResult;
};
ToDoubleAndMore(3.5);
ToDoubleAndMore(9.999);
ToDoubleAndMore(-3.1);

//9

static int CalculatingLetters(string forCalculating)
{
    int sumLetters = forCalculating.Length;
    //Console.WriteLine(sumLetters);
    return sumLetters;
};
CalculatingLetters("hvjbvj");

//10

static string Prolong(string initialShort)
{
    string longerThan = initialShort + initialShort + initialShort;
    string result = "";
    /*char a;
    string together;
    string result = "";
    for (int i = 0; i > initialShort.Length; i++)
    {
        Console.WriteLine(i);
            a = initialShort[i];
        
        string longerThan = new string(a, 3);

        result = Convert.ToString(longerThan) + initialShort;
        Console.WriteLine(longerThan);
    }*/
    result = Convert.ToString(longerThan) + initialShort;
    Console.WriteLine(result);
    return result;
};
Prolong("Hi!");


