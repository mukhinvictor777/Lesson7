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

void printDoubleArray(double[] arrayToPrint)
{
    Console.WriteLine();
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i], 1) + " ");
    }
    Console.WriteLine();
}


double[] arithmeticMeanOfColumn(int[,] incomingArray)
{
    int sumOfEleventsInColumn = 0;
    int count = incomingArray.GetLength(0);
    int newArrayLenght = incomingArray.GetLength(1);
    double [] arMeanOfColumn = new double[newArrayLenght];
    for (int j = 0; j < newArrayLenght; j++)
    {
        for (int i = 0; i < count; i++)
        {
            sumOfEleventsInColumn = sumOfEleventsInColumn + incomingArray[i,j];
        }
        arMeanOfColumn[j] = Convert.ToDouble(sumOfEleventsInColumn) / Convert.ToDouble(count);
        sumOfEleventsInColumn = 0;
    }
    return arMeanOfColumn;
}

int[,] generatedArray = generate2DArray(15, 6, -10, 10);
Console.WriteLine();
print2DArray(generatedArray);
Console.WriteLine();
int[,] userArray =  {
                        {1, 4, 7, 2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4}
                    };
print2DArray(userArray);
Console.WriteLine();
double[] arithmeticMean = arithmeticMeanOfColumn(userArray);
printDoubleArray(arithmeticMean);
double[] arithmeticMeanRandom = arithmeticMeanOfColumn(generatedArray);
printDoubleArray(arithmeticMeanRandom);
Console.WriteLine();
