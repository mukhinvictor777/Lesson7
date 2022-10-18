string path = "/Users/mukhi/Desktop/Geek Brains/Знакомство с С#/Practice6";
DirectoryInfo d1 = new DirectoryInfo(path);
System.Console.WriteLine(d1.CreationTime);
FileInfo[] fi = d1.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}