//Нужно написать программу, которая из имеющегося массива строк, 
//формирует новый массив из строк, длина которых задается пользователем.
string[] arrayText = FillArray();
Console.WriteLine("Введите длину строки в новом массиве \n(меньше или равно символов): ");
int lengthString = Convert.ToInt32(Console.ReadLine());
lengthString = CheckNumber(lengthString);
string[] arrayNew = FormingNewArray(arrayText, lengthString);
PrintArray(arrayText);
Console.Write($"  --->  ");
PrintArray(arrayNew);

string[] FillArray(){
    Console.Write("Введите размер массива строк: ");
    int size = Convert.ToInt32(Console.ReadLine());
    size = CheckNumber(size);
    string[] arr = new string[size];
    Console.WriteLine($"Введите строки: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{i + 1}  строка: ");
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}
string[] FormingNewArray(string[] arr, int len)
{
    string[] arr1 = new string[arr.Length];
    int count = 0, length = default;
    for (int i = 0; i < arr.Length; i++)
    {
        length = len + 1;
        if (arr[i][0] == '"')
            length += 1;
        if (arr[i][arr[i].Length - 1] == '"')
            length += 1;
        if (arr[i].Length < length)
        {
            arr1[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref arr1, count);
    return arr1;
}
int CheckNumber(int num)
{
    while (num < 1)
    {
        Console.WriteLine("Некорректный ввод числа!");
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}
void PrintArray(string[] arr)
{
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
            Console.Write($"{arr[i]}");
        else
            Console.Write($"{arr[i]}, ");
    }
    Console.Write($"]");
}