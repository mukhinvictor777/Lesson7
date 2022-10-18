char[] s = {'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++, -5} {s[i]}");
}
Console.WriteLine();


void FindWords(string alphabet, char[] word, int Length = 0)
{
       if (Length == word.Length)
    {
        Console.WriteLine($"{new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[Length] = alphabet[i];
        FindWords(alphabet, word, Length + 1);
    }
}

FindWords ("аисв", new char[2]);