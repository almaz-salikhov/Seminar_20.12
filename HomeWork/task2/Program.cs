// Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве
// возвращает значение этого элемента или же указание, что такого элемента нет.


void FillArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
        Console.WriteLine();
    }
}
void PrintArray(int[,] arr)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void ShowElementIfExist(int[,] arr, int row, int column)
{
    if (row > 0 & column > 0)
    {
        if (row <= arr.GetLength(0) & column <= arr.GetLength(1))
        {
            Console.WriteLine("Искомый элемент: " +
            (arr[row - 1, column - 1]));
        }
        else
        {
            Console.WriteLine("Такого числа в массиве нет");
        }
    }
    else
    {
        Console.WriteLine("Введен отрицательный индекс элемента");
    }
}

Console.WriteLine("Введите количество строк нового массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов нового массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите номер строки искомого элемента: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента: ");
int N = Convert.ToInt32(Console.ReadLine());

ShowElementIfExist(array, M, N);