string NumbersFor (int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec (int a, int b)
{
    if (a < b)
    {
        return $"{a} " + NumbersRec(a + 1, b);
    }
    else
    {
        return $"{b}";
    }
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

string NumbersForNew (int a, int b)
{
    string result = string.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecNew (int a, int b)
{
    if (a < b - 1)
    {
        return NumbersRec(a + 1, b) + $"{b} ";
    }
    else
    {
        return string.Empty;
    }
}

Console.WriteLine(NumbersForNew(1, 10));
Console.WriteLine(NumbersRecNew(1, 10));