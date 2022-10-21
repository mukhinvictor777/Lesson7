double [,] generate2DArray(int hight, int wight, double randomStart, double randomEnd)
{
    double [,] twoDArray = new double [hight, wight];
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
        {
            twoDArray[i, j] = Math.Round(new Random().NextDouble()*(randomStart+(randomEnd-randomStart)),2);
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

void print2DArray(double[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+1 + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+1 + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
           Console.Write(arrayToPrint[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}

double [,] generatedArray = generate2DArray(10, 10, -100 , 100);
print2DArray(generatedArray);