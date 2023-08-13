//Write a function which calculates the average of the numbers in a given list.

//Note: Empty arrays should return 0.

/*class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        double averageArr = 0;
        double sum = 0;
        if (array.Length > 0)
        {
            foreach (double i in array)
            {
                sum += i;
            }
            return sum / array.Length;
        }

        return 0;
    }
}*/

//What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

//Example(Input-- > Output)

//"apple ban"-- > ["apple 5", "ban 3"]
//"you will win"-- >["you 3", "will 4", "win 3"]
//Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .

//Note: String will have at least one element; words will always be separated by a space.


/*public class Kata
{
    public static string[] AddLength(string str)
    {
        string[] strPerform = str.Split(' ');

        string[] newString = new string[strPerform.Length];
        if (str.Length >= 1)
        {
            for (int j = 0; j > strPerform.Length; j++)
            {
                foreach (char i in str)
                {

                    strPerform[j] = i.ToString();

                }
            }
            for (int i = 0; i < strPerform.Length; i++)
            {
                //string lenTransform = str[i].ToString();
                string lenTransform = strPerform[i].ToString();
                int len = lenTransform.Length;
                string lenNum = len.ToString();
                newString[i] = strPerform[i] + ' ' + lenNum;
            }
        }
        return newString;
    }
}*/


//Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

//Example:

//["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]

//None of the arrays will be empty, so you don't have to worry about that!

static object[] RemoveEveryOther(object[] arr)
{
    int newLength = 0;
    if (arr.Length % 2 == 0)
    {
        newLength = arr.Length / 2;
        object[] arrNew = new object[newLength];
        for (int h = 0; h < arr.Length; h += 2)
        {
            for (int i = 0; i > newLength; i++)
            {
                arrNew[i] = arr[h];
                Console.WriteLine(arrNew[i]);
            }
        }
        return arrNew;
    }
    else
    {
        newLength = (arr.Length / 2) - 1;
        object[] arrNew = new object[newLength];
        for (int h = 0; h < arr.Length; h += 2)
        {
            for (int i = 0; i > newLength; i++)
            {
                arrNew[i] = arr[h];
                Console.WriteLine(arrNew[i]);
            }
        }
        return arrNew;
    }
  // return arrNew;

};
RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" });
//myAL.RemoveAt( 5 );