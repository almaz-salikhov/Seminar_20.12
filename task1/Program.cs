// Задать двумерный массив Найти элементы с четными индексами (оба)
// И заменить их элементы на их квадраты 

// 1) создаем массив
void FillArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++) // внешний цикл - выбор строки 
    {
        for (int j = 0; j < arr.GetLength(1); j++) // внутренний цикл заполняет строку
        {
            arr[i, j] = rnd.Next(2, 5);
        }
    }
}
void PrintArray(int[,] arr)
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
void ChangeElementsToSquare(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; i < arr.GetLength(1); i++)
        {
            if (i % 2 == 0 & j % 2 == 0)
            {
                arr[i, j] *= arr[i, j]; // умножение с накоплением, умножение на себя
            }
        }
    }
}

int rowCount = 3;
int columnCount = 4;
int[,] array = new int[rowCount, columnCount];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeElementsToSquare(array);
PrintArray(array);

