string[] GetArray(int size)
{
    string[] strArray = new string[size];
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.WriteLine("Введите данные в массив");
        strArray[i] = Console.ReadLine();
    }
    return strArray;
}

Console.WriteLine("Задайте размер массива");
int SizeCount = Convert.ToInt32(Console.ReadLine());

string[] array = GetArray(SizeCount);

Console.WriteLine($"[{String.Join(";", array)}]");

