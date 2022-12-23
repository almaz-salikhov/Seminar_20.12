// Задайте двумерный массив размером m × n
// заполненный случайными вещественными числами
// Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

// определить размер массива 
// сгенерить числа 
// наполнить ими массив 

void FillArrayWithRandomRealNumbers(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            arr[i, j] = Math.Round(rnd.Next(-10, 10) + rnd.NextDouble(), 2);
        }
        Console.WriteLine();
    }
}
void PrintArray(double[,] arr)
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

Console.WriteLine("Введите количество строк будущего массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов будущего массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
FillArrayWithRandomRealNumbers(array);
PrintArray(array);
Console.WriteLine();
