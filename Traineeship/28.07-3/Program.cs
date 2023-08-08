//1,10,100,1000,10000
int a = 1;

for (int i = 0; i < 10; i++)
{
    //Console.Write(i);


    for (int j = 0; j < 10; j++)
    {
        if (j > i - 1 && j < i + 1)
        {
            Console.Write("0");
        }
        else
        {
            Console.Write("!");
        }

    }

    Console.WriteLine();
}

for (int i = 0; i < 10; i++)
{

    for (int j = 10; j > 0; j--)
    {
        if (j > i - 1 && j < i + 1)
        {
            Console.Write("0");
        }
        else
        {
            Console.Write("!");
        }

    }

    Console.WriteLine();
}



for (int i = 0; i < 10; i++)
{

    for (int j = 10; j > 0; j--)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write("0");
        }
        else
        {
            Console.Write("!");
        }

    }

    Console.WriteLine();
}
