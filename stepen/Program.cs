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
    //return n == 0 ? 1 : PowerRec(a, n - 1) *= a;
    if (n == 0)
    {
        return 1;
    }
    else
        return StepenRec(a, n - 1) * a;
}

int StepenRecMath (int a, int n)
{
    if (n == 0) return 1;
    else 
    {
        if (n % 2 == 0)
        {
            return StepenRecMath (a * a, n / 2);
        }
        else
        {
            return StepenRecMath (a, n - 1) * a;
        }
        
    }
    
}

Console.WriteLine(StepenFor(2, 10));
Console.WriteLine(StepenRec(2, 10));
Console.WriteLine(StepenRecMath(2, 10));