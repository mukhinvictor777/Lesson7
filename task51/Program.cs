int[,] generate2DArray(int hight, int wight, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[hight, wight];
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

int sumOfDiagonallyNumbers(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) <= array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,i];
        }
    }
    else
    {
         for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i,i];
        }
    }
    return sum;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
           Console.Write(arrayToPrint[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int[,] generatedArray = generate2DArray(15, 6, -10, 10);
Console.WriteLine();
print2DArray(generatedArray);
Console.WriteLine();
int sumOfRandom = sumOfDiagonallyNumbers(generatedArray);
Console.WriteLine($"Сумма главных элементов по главной диагонали равна {sumOfRandom}");
Console.WriteLine();
int[,] userArray =  {
                        {1, 4, 7, 2},
                        {5, 9, 3, 3},
                        {8, 4, 2, 4}
                    };
print2DArray(userArray);
Console.WriteLine();
int sumUser = sumOfDiagonallyNumbers(userArray);
Console.WriteLine($"Сумма главных элементов по главной диагонали равна {sumUser}");
Console.WriteLine();