// See https://aka.ms/new-console-template for more information
//2
Console.WriteLine("Please, enter your name");
string name = Console.ReadLine();
Console.WriteLine("Please, enter your age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your hobby");
string hobby = Console.ReadLine();
string result = "My name is " + name + ". I am " + age + " and my hobby is " + hobby + ".";
Console.WriteLine(result);
