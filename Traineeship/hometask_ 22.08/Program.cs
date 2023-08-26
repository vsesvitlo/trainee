/*1. Є два масива 
a = { 7, 10, -1, -3, 4, -4, 6}
b = { 3, 7, 9 2, 6, -7, 4}
створити третій масив в який вкласти позитивні із першого (a)  і парні з другого (b) масивів +
2. Є два масива 
a = {7, 10, -1, -3, 4, -4, 6, 17, 11, 3}
b = { 3, 7, 9 2, 6, -7, 4, -8, 6, 3, 33, 1}
Вивести в третій масив ті числа з обох масивів які більше загального середнього. +
3. Є два відсортовані списки
sorted_a = {-1, 3, 15, 27, 82, 104, 105, 108, 600}
sorted_b = { 0, 17, 90, 405, 409, 417, 512}
Злити два відсортовані масиви в третій так щоб він був теж відсортований*/
/*
int[] SortFromTwoArrays(int[] first, int[] second)
{
    int countPositive = 0;
    int countPair = 0;
    for (int i = 0; i < first.Length; i++)
    {
        if (first[i] >= 0)
        {
            countPositive += 1;
        }
    }
    for (int i = 0; i < second.Length; i++)
    {
        if (second[i] % 2 == 0)
        {
            countPair += 1;
        }
    }
    int count = countPair + countPositive;
    //Console.WriteLine(count);
    int[] result = new int[count];
    int positive;
    int pair;
    int j = 0;
    if(j < count)
    {
        for (int i = 0; i < first.Length; i++)
        {
            positive = first[i];
            if (positive > 0)
            {
                result[j] = positive;
               
                Console.WriteLine(result[j]);
                j++;
            }
            }
        for (int k = 0; k < second.Length; k++)
        {
            pair = second[k];
            if (pair % 2 == 0)
            {
                result[j] = pair;
                Console.WriteLine(result[j]);
                j++;
            } 
        }   
    }
    return result;
}
SortFromTwoArrays(new int[] { 7, 10, -1, -3, 4, -4, 6 },
new int[] { 3, 7, 9, 2, 6, -7, 4 });
*/
/*int[] ConnectTwoArrays(int[] a, int[] b)
{
    int countAverageA = 0;
    int sumA = 0;
    int countAverageB = 0;
    int sumB = 0;
    int count1 = 0;
    int count2 = 0;
    int lengthSum = 0;
    for(int i = 0; i < a.Length; i++)
    {
        sumA += a[i];
        count1++;
    }
    countAverageA = sumA / a.Length;
    //Console.WriteLine(sumA);
    //Console.WriteLine(a.Length);
    //Console.WriteLine(countAverageA); //5
    for (int j = 0; j < a.Length; j++)
    {
        sumB += b[j];
        count2++;
    }
    countAverageB = sumB / b.Length;
    //Console.WriteLine(sumB);
    //Console.WriteLine(b.Length);
    //Console.WriteLine(countAverageB);//2
    lengthSum = count1 + count2;
    int[] result = new int[lengthSum];

    int moreAverageFirst = a[0];
    int moreAverageSecond = b[0];
    int k = 0;
    if(k < lengthSum)
    {
        for (int i = 0; i < a.Length; i++)
        {
            moreAverageFirst = a[i];
            if (moreAverageFirst > countAverageA)
            {
                result[k] = moreAverageFirst;
                Console.WriteLine(result[k]);
                k++;
            }
        }
        for (int j = 0; j < b.Length; j++)
        {
            moreAverageSecond = b[j];
            if (moreAverageSecond > countAverageB)
            {
                result[k] = moreAverageSecond;
                Console.WriteLine(result[k]);
                k++;
            }
        }
    }
    return result;
}
ConnectTwoArrays(new int[] { 7, 10, -1, -3, 4, -4, 6, 17, 11, 3 },
new int[] { 3, 7, 9, 2, 6, -7, 4, -8, 6, 3, 33, 1 });*/
int[] ArraySorter(int[] sorted_a, int[] sorted_b)
{
    int lengthForResult = sorted_a.Length + sorted_b.Length;
    //Console.WriteLine(sorted_a.Length);
    //Console.WriteLine(sorted_b.Length);
    int[] result = new int[lengthForResult];
    for (int i = 0; i < lengthForResult; i++)
    {
        for (int j = 0; j < sorted_a.Length; j++)
        {
            result[i] = sorted_a[j];

        }
        for (int k = 0; k < sorted_b.Length; k++)
        {
            result[i] = sorted_b[k];

        }

    }
    for (int g = 0; g < result.Length; g++)
    {
        Console.WriteLine(result[g]);
    }

    return result;

}
ArraySorter(new int[] { -1, 3, 15, 27, 82, 104, 105, 108, 600 },
    new int[] { 0, 17, 90, 405, 409, 417, 512 });