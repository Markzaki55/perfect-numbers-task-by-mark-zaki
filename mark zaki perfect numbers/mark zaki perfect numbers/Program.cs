// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first num:");
int first_num = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second num:");
int second_num = int.Parse(Console.ReadLine());

Console.WriteLine("The perfect numbers between {0} and {1} are:", first_num, second_num);
for (int i = first_num; i <= second_num; i++)
{
    if (perfect_tester(i))
    {
        Console.Write(i + " ");
    }
}
        

        static bool perfect_tester(int number)
{
    int p = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            p += i;
        }
    }

    return p == number;
}

