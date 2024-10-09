/*You are given two integers a
 and b
 (a≤b
). Over all possible integer values of c
 (a≤c≤b
), find the minimum value of (c−a)+(b−c)
.

Input
The first line contains t
 (1≤t≤55
) — the number of test cases.

Each test case contains two integers a
 and b
 (1≤a≤b≤10
).

Output
For each test case, output the minimum possible value of (c−a)+(b−c)
 on a new line.

Example
InputCopy
3
1 2
3 10
5 5
OutputCopy
1
7
0
Note
In the first test case, you can choose c=1
 and obtain an answer of (1−1)+(2−1)=1
. It can be shown this is the minimum value possible.

In the second test case, you can choose c=6
 and obtain an answer of (6−3)+(10−6)=7
. It can be shown this is the minimum value possible.


*/
Console.WriteLine("Please, enter an integer a");
string step1 = Console.ReadLine();
int a = int.Parse(step1);
Console.WriteLine("Please, enter an integer b >= a");
string step2 = Console.ReadLine();
int b = int.Parse(step2);
int d = 0;
int x = 0;
if (a < b)
{
for (int c = a; c < b; c++)
{
 d = (c - a) + (b - c);
        if (d < x)
        {
            x = d;
        }
        else
        {
            x = c;
        }

}
    Console.WriteLine(x);
}
else if (a > b)
{
    Console.WriteLine("Enter the correct numbers, please");
}
else
{
    Console.WriteLine(x);
}

/*for (int c = b; c >= a / 2; c--)
{
    d = (c - a) + (b - c);
    forC = c;

    for (int e = a; e <= b / 2; e++)
    {

        x = (e - a) + (b - e);
        forE = e;

        if (x > d)

        {
            Console.WriteLine(forE);
        }
        else
        {
            Console.WriteLine(forC);
        }
    }
}*/

