// Знайти суму всіх чисел +
// Знайти суму всіх парних чисел +
// Знайти суму всіх позитивних парних чисел +
// Знайти суму всіх позитивних парних біля яких є парний сусід(сусід може бути і відємним) +
// Знайти суму всіх таких чисел, біля яких правий сусід більший за це число. +
// (Останнє число рахувати меншим за його не існуючого сусіда)
// Щоб визнчати чи число парне треба просто взяти остачу від ділення на 2
//якщо x%2==0 - то парне



int[] array = { 2, 4, 5, 7, 10, -1, 4, 6, -8, 8, 1, 10, 2, 6, 3, 14, 0, -2, 4, 1, 6, 8 };
int sum = 0;
int sumPositive = 0;
int sumPositiveDouble = 0;
int sumPositiveDoubleNeigbor = 0;
int sumPositiveDoubleNeigborBigger = 0;
int sumPositiveDoubleNeigborLeft = 0;

for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
Console.WriteLine(sum);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }

}
Console.WriteLine(sumPositive);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0 && array[i] % 2 == 0)
    {
        sumPositiveDouble += array[i];
    }

}
Console.WriteLine(sumPositiveDouble);

for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] > 0 && array[i] % 2 == 0 && array[i + 1] % 2 == 0)
    {
        sumPositiveDoubleNeigbor += array[i];
    }
}
Console.WriteLine(sumPositiveDoubleNeigbor);


for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] < array[i + 1])
    {
        sumPositiveDoubleNeigborBigger += array[i];
    }
}
Console.WriteLine(sumPositiveDoubleNeigborBigger);



if (array[0] > 0 && array[0] % 2 == 0 && array[1] % 2 == 0)
{
    sumPositiveDoubleNeigborLeft += array[0];
}
if (array[^1] > 0 && array[^1] % 2 == 0 && array[^2] % 2 == 0)
{
    sumPositiveDoubleNeigborLeft += array[^1];
}
for (int i = 1; i < array.Length - 1; i++)
{

    if (array[i] > 0 && array[i] % 2 == 0 && array[i + 1] % 2 == 0 && array[i - 1] % 2 == 0)
    {
        sumPositiveDoubleNeigborLeft += array[i];
    }
}


Console.WriteLine(sumPositiveDoubleNeigborLeft);

