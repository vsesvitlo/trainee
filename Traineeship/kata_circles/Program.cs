int[] num = new int[4] { 6, 7, 9, 1 };
string a = "";
string element = "";
int sum = 0;
int[] reverse = new int[num.Length];

for (int i = 0; i < num.Length; i++)
{
    a += num[i];
}
Console.WriteLine(a);

int.TryParse(a, out int sumConvert);
sum = sumConvert + 1;
string sumForReverse = sum.ToString();
Console.WriteLine(sumForReverse);
Console.WriteLine(sumForReverse.GetType());

for (int j = 0; j < sumForReverse.Length; j++)
{
    element = sumForReverse[j].ToString();

    reverse[j] = int.Parse(element);
    Console.WriteLine(reverse[j]);
}

