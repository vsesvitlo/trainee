//11.Метод який приймає в себе строку і число. А повертає строку обрізану за числом.
//Наприклад строка "Hello Moto" а число 3, на виході буде "Hel" +


//12. Розширений варіант 11 завадння. Метод приймає в себе строку, число і ще одне число.
//Повертає строку від першого числа до 2 числа. Наприклад "SomeText" і числа 2, 5 то на виході буде "meT" +


//13. Метод який генерує суму двох рандомних чисел кубиків (від 1 до 6). +


//14.Метод який використовує метод 13) 2 рази.Цей метод нічого не приймає.
//Він емулює кидки пар кубиків двох гравців. І потім повертає текс в залежності в кого більше очок.
//Якщо в першого очок більше то "виграв перший", якщо однаково то "нічия" і якщо більше в другого то "виграв другий". +


//15. Метод який використовує 14) метод кілька разів. На вхід метод приймає кількість ігор.
//Далі викликається стільки разів 14 метод. І на вихід подається число % від виграша першого гравця.
//Наприклад якщо було ігор 10, перший гравець виграв 6 разів, 1 нічия і другий гравець виграв 3 рази,
//то повернеться 60% (double). 60 % вернеться тому що гравець виграв 6 разів із 10 ігор. 6/10 * 100% ++


//11
using System.Globalization;

static string SubString(string first, int toCut)
{
    string sub = first.Substring(0, toCut);
    //Console.WriteLine(sub);
    return sub;

};
SubString("Hello Moto", 3);

//12

static string SubStringBoth(string initialText, int firstNum, int length)
{
    string subText = initialText.Substring(firstNum, length - firstNum);
    //Console.WriteLine(subText);
    return subText;

};
SubStringBoth("SomeText", 2, 5);

//13
static int RandomSum()
{
    var randomNum1 = new Random();
    var randomNum2 = new Random();
    int transformRandom1 = randomNum1.Next(1, 6);
    int transformRandom2 = randomNum2.Next(1, 6);
    int sum = transformRandom1 + transformRandom2;
    //Console.WriteLine(transformRandom1);
    // Console.WriteLine(transformRandom2);
    //Console.WriteLine(sum);
    return sum;
};
RandomSum();

//14
static void RandomText()
{
    var player1 = new Random();
    var player2 = new Random();
    int firstPlayer1 = player1.Next(1, 6);
    int secondPlayer1 = player1.Next(1, 6);
    int firstPlayer2 = player2.Next(1, 6);
    int secondPlayer2 = player2.Next(1, 6);
    int sum1player = firstPlayer1 + secondPlayer1;
    int sum2player = firstPlayer2 + secondPlayer2;

    if (sum1player > sum2player)
    {
        //  Console.WriteLine("Player number 1 wins!");
    }
    else if (sum1player < sum2player)
    {
        // Console.WriteLine("Player number 2 wins!");
    }
    else
    {
        // Console.WriteLine("The result of competition is draw");
    }

};
RandomText();

//15

static double GreatGame(int howMuchGames)
{

    var player1 = new Random();
    var player2 = new Random();
    int count1ForPlayer1 = 0; player1.Next(1, 6);
    int count1ForPlayer2 = 0; player2.Next(1, 6);
    int count1 = 0;
    int count2 = 0;
    int sumCount = count1 + count2;
    int firstPlayerWins = 0;
    double firstPlayerWinsDouble = Convert.ToDouble(firstPlayerWins);

    for (sumCount = 0; sumCount < howMuchGames; sumCount++)
    {

        if (count1ForPlayer1 > count1ForPlayer2)
        {
            count1 += 1;
            firstPlayerWins = (count1 * 100) / howMuchGames;
            firstPlayerWinsDouble = Convert.ToDouble(firstPlayerWins);
            Console.WriteLine(firstPlayerWins);
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", firstPlayerWinsDouble/100)); ///???
        }
        //if (count1ForPlayer1 < count1ForPlayer2)
        //
        else{
            count2 += 1;

        }
        count1ForPlayer1 = player1.Next(1, 6);
        count1ForPlayer2 = player2.Next(1, 6);
       
    }

    return firstPlayerWinsDouble;

};
GreatGame(6);