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

int[,] generatedArray = generate2DArray(10, 10, -999, 999);
print2DArray(generatedArray);