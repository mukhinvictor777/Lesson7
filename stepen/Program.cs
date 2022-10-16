int StepenFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

int StepenRec(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
        return StepenRec(a, n - 1) * a;
}

Console.WriteLine(StepenFor(2, 10));
Console.WriteLine(StepenRec(2, 10));