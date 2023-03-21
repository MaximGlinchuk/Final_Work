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

var SortArray = new string[array.Length];
var SortSize = 0;
for (int i = 0; i < SizeCount; i++)
{
    if (array[i].Length <= 3 )
    {
        SortArray[SortSize] = array[i];
        SortSize++;
    }
}
Array.Resize(ref SortArray, SortSize);

Console.WriteLine("Массив с значениями длинной <= 3:");
Console.WriteLine($"[{String.Join(";", SortArray)}]");

