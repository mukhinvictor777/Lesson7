int getNumberFromUser(string userInformation)
{
    int  result = 0;
    while (result == 0 || result < 1)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 || result < 1) Console.WriteLine($"Введите целое число больше нуля, вы вввели {userLine}"); else break;
    }
    return result;
}


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

int findNumberFromIndex(int[,] array, int index)
{
    int result = 0;
    int indexI = 0;
    int indexJ = 0;
    int countOfElements = array.GetLength(0)*array.GetLength(1)-1;
    if (countOfElements < index) return result;
    else
    {        
        indexI = index / array.GetLength(1);
        indexJ = index % array.GetLength(1);
        result = array[indexI, indexJ];
        return result;
    }
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
int indexToFind = getNumberFromUser("Введите порядкой номер элемента массива для поиска: ");
int result = findNumberFromIndex(generatedArray, indexToFind);
if (result == 0) Console.WriteLine($"{indexToFind} -> такого числа в массиве нет");
else Console.WriteLine($"В заданном массиве порядковому номеру {indexToFind} соответтвует элемент: {result}");
Console.WriteLine();
int indexToFind2 = getNumberFromUser("Введите порядкой номер элемента массива для поиска: ");
int result2 = findNumberFromIndex(userArray, indexToFind2);
if (result2 == 0) Console.WriteLine($"{indexToFind2} -> такого числа в массиве нет");
else Console.WriteLine($"В заданном массиве порядковому номеру {indexToFind2} соответтвует элемент: {result2}");
Console.WriteLine();
