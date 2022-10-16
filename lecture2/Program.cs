int SumFor (int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
    {
        result += i;
    }
    return result;
}

int SumRec (int n)
{
    if (n == 0) 
    {
        return 0;
    }
    else 
    {
        return n + SumRec(n - 1);
    }
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int FactorialRec(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
        return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));