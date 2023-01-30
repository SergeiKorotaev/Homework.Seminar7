int lines = ReadInt("Введите индекс строки: ");
int columns = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[4, 4];
FillArray(numbers);
PrintArray(numbers);

if (lines < numbers.GetLength(0) && columns < numbers.GetLength(1)) 
Console.WriteLine(numbers[lines, columns]);

else 
Console.WriteLine($"{lines}{columns} -> такого числа в массиве нет");


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}