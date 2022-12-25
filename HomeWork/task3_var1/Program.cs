// Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
// В каждом столбце найдите среднее арифметическое среди тех элементов
// которые являются палиндромами 
// (если палиндромов нет, то среднее арифметическое считать равным 0). 
// Полученные средние арифметические занести в одномерный массив.

// генерация массива 10 x 10 случайными трехзначными числами (целые)
// проверяю столбцы на наличие палиндромов, проходясь по 1
// нахожу среднее арифметическое всех палиндромов каждого столбца 
// палиндромов нет — avg = 0
// полученные avg занести в массив 
// вывести массив 

void FillArray(int[,] arr) // Fill array with random 3-digit numbers
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(100, 999);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] arr) // Showing array
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[10, 10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] arrayAvg = new int[array.GetLength(1)];
int k = 0;

for (int j = 0; j < array.GetLength(1); j++)
{
    int countOfPalindrom = 0;
    int sum = 0; // сумма палиндромов 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int one = array[i, j] / 100;
        int three = array[i, j] % 10;
        if (one == three) // проверяем, является ли оно палиндромом
        {
            sum = sum + array[i, j];
            countOfPalindrom++;
        }
    }
    if (countOfPalindrom == 0)
    {
        arrayAvg[k] = 0;
        k++;
    }
    else
    {
        arrayAvg[k] = sum / countOfPalindrom;
        k++;
    }
}
Console.WriteLine(string.Join(", ", arrayAvg));
