//Нужно написать программу, которая из имеющегося массива строк, 
//формирует новый массив из строк, длина которых задается пользователем.
string[] arrayText = FillArray();
PrintArray(arrayText);

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