//На char:
//1.Подивитися які коди в літерах "A", "B", "a", "b", вивести всі символи що знаходяться між "A" і "a" +
//2. Є string s = "HellOMotE" 
//Знайти кількість великих літер +

//На масиви:
//1.Використати генератор рандомних чисел із сідом 7.
//Згенерувати масив на 20 випадкових чисел в діапазоні випадковості від 1 до 100 +
//2. Є масив int mass = {4, 1, 6, 9, 2, 7, 10, 4, 0, 9}
//Знайти пару чисел сусідів в масиві які в сумі дають набільше значення


//1
string[] Alphabet()
{
    int count = 123 - 65;
    string[] letters = new string[count];
    char letr = 'A';
    for (int i = 0; i < count; i++)
    {
        letters[i] = Convert.ToString(letr);
        // Console.WriteLine(letr);
        letr++;
    }
    return letters;
}
Alphabet();


//2

int BigLetters(string s)
{
    int result = 0;
    for (int i = 0; i < s.Length; i++)
    {
        int a = Convert.ToInt32(s[i]);
        //Console.WriteLine(a);
        if (a < 90)
        {
            result++;
            // Console.WriteLine(result);
        }
    }
    return result;
}
BigLetters("HellOMotE");

//1
static int[] RandomList()
{
    var randomNum = new Random(0);
    int[] randomList = new int[20];

    for (int i = 0; i < randomList.Length; i++)
    {
        int transformRandom = randomNum.Next(1, 100);
        randomList[i] = transformRandom;
        //Console.WriteLine(randomList[i]);
    }

    return randomList;
};
RandomList();


//2

int[] MaxPair(int[] mass)
{
    int[] pairResult = new int[2];
    int indexForPlus = mass[0];
    int indexForPlusFirst = mass[1];
    int sum = indexForPlus + indexForPlusFirst;
    for (int i = 2; i < mass.Length; i++)
    {
        if (mass[i - 1] + mass[i] > sum)
        {
            indexForPlus = mass[i - 1];
            indexForPlusFirst = mass[i];

            // Console.WriteLine(indexForPlus);
            //Console.WriteLine(indexForPlusFirst);
            sum = indexForPlus + indexForPlusFirst;
            //Console.WriteLine(sum);
            // for (int k = 0; k < pairResult.Length; k++)
            //{
            pairResult[0] = mass[i - 1];
            pairResult[1] = mass[i];
            Console.WriteLine(pairResult[0]);
            Console.WriteLine(pairResult[1]);
            // }

        }


    }

    return pairResult;
}
MaxPair(new int[] { 4, 1, 6, 9, 2, 7, 10, 4, 0, 9 });
