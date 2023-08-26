//Write a function that takes an array of words and smashes them together into
//a sentence and returns the sentence. You can ignore any need to sanitize words or add punctuation,
//but you should add spaces between each word.
//Be careful, there shouldn't be a space at the beginning or the end of the sentence!

/*
 static string Smash(string[] words)
{
    string result = "";
    string newResult = "";
    if (words.Length <= 1)
    {
        newResult += words[0].ToString();
    }
    else if (words.Length > 1)
    {
        for (int i = 0; i < words.Length; i++)
        {
            result += words[i].ToString();
            result += " ";

            for (int j = 0; j < result.Length; j++)
            {
                newResult = result.Substring(0, result.Length - 1);
            }
        }
    }
    return newResult;
}*/

//You must implement a function that returns the difference between the largest
//and the smallest value in a given list / array (lst) received as the parameter.
//lst contains integers, that means it may contain some negative numbers
//if lst is empty or contains a single element, return 0
//lst is not sorted


 /*static int MaxDiff(int[] lst)
    {
        int dif;

        if (lst.Length > 1)
        {
            int maxInt = lst[0];
            int minInt = lst[0];
            for (int j = 0; j < lst.Length; j += 1)
            {

                if (lst[j] > maxInt)
                {
                    maxInt = lst[j];
                }
                if (lst[j] < minInt)
                {
                    minInt = lst[j];
                }
            }
            dif = maxInt - minInt;
        }
        else
        {
            return 0;
        }


        return dif;
    }

MaxDiff(new int[] { 5, 1, 0, 6, 2, 3, 4 });*/

/*static void Main(string[] args)
        {
5, 1, 0, 6, 2, 3, 4 
            int[] mass = { 1, 5, 0, 2 };

            int max = mass[0];

            for (int i =1; i < mass.Length; i++) 
            { 
                if (mass[i]> max)
                {
                    max = mass[i];
                }
            }
            

        }*/