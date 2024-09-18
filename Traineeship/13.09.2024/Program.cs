// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write the number 25");
string a = Console.ReadLine();
int result = 0;
bool check = int.TryParse(a, out result);
if (check == false)
{
    Console.WriteLine("Write the number 25");
}

else if(result != 25)
{
    Console.WriteLine("Write the number 25");
}
else
{
    Console.WriteLine("Good");
}
