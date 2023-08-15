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

/*static object[] RemoveEveryOther(object[] arr)
{
    int newLength = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        newLength += 1;
    }

    object[] arrNew = new object[newLength];
    for (int j = 0, h = 0; h < arr.Length; j++, h += 2)
    {
        arrNew[j] = arr[h];
    }
    return arrNew;
};
RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" });*/

//Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'.
//Return the resulting string.

//Note: input will never be an empty string

/*
 static string FakeBin(string x)
{
    var result = String.Empty;
    int[] arrNew = new int [x.Length];
    int[] arrNewResult = new int[arrNew.Length];

    for (int i = 0; i < x.Length; i++)
    {
        arrNew[i] = x[i];
    };
    for (int j = 0; j < arrNew.Length; j++)
    {
        if (arrNew[j] < 5)
        {
            arrNewResult[j] = 0;
        }
        else if (arrNew[j] >= 5)
        {
            arrNewResult[j] = 1;
        }
        arrNewResult[j] = arrNew[j] ;
        Console.WriteLine(arrNewResult[j]);
    };

    foreach(var k in arrNewResult)
    {
        result += k;
        Console.WriteLine(result);
    }
    //arrNewResult.ToString();

    return result;
}
FakeBin("45385593107843568");

*/

//Write a function that takes a single string (word) as argument.
//The function must return an ordered list containing the indexes of all capital letters in the string.

  static int[] Capitals(string word)
  {
    int count = 0;
    //bool result1;
    for (int i = 0; i < word.Length; i++){
        // Console.WriteLine(word.GetType());
        //string a = word[i].ToString();
        // Console.WriteLine(a.GetType());
      //  char a = word[i];
    //result1 = Char.isUpper(a);
       // if (Char.isUpper(word[i])){
        count +=1;
     //}
    }
    int[] result = new int [count];
    for(int j = 0, k = 0; j < word.Length; j++, k++){
     // if(word[j].isUpper()){
        result[k] = j;
     // }
    }
		return result;
  }
Capitals("CodEWaRs");

//its elements is odd or even.

//Give your answer as a string matching "odd" or "even".

//If the input array is empty consider it as: [0] (array with a zero).


/*
 static string OddOrEven(int[] array)
{
    int sum = 0;
    string result = "";
    string even = "even";
    string odd = "odd";
    if (array.Length == 0)
    {
        sum = 0;
    }
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        Console.WriteLine(sum);
    }
    if (sum % 2 == 1 || sum % 2 == -1)
    {
        result = odd;
    }
    else
    {
        result = even;
    }
    Console.WriteLine(result);
    return result;
};

OddOrEven(new int[] { 0, -1, 2 });
OddOrEven(new int[] { 0, 1, -4 });
OddOrEven(new int[] { -1023, -1, 3 });

*/