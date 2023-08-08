int[] arr = new int[6] { 2, 6, 8, 3, 7, 3 };
int counter = 0;
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
};

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] % 2 == 0)
    {
        counter += 1;
    }
};

int[] arr2 = new int[counter];

for (int j = 0, k = 0; j < arr.Length && k < counter; j++)
{
    if (arr[j] % 2 == 0)
    {
        arr2[k] = arr[j];

        Console.WriteLine(arr2[k]);
        k++;
    }
};
