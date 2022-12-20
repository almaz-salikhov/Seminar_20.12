// Заполнение двухмерного массива 
int[,] arr = new int[3, 3];

for (int i = 0; i < arr.GetLength(0); i++) // внешний цикл - выбор строки 
{
    for (int j = 0; j < arr.GetLength(1); j++) // внутренний цикл заполняет строку
    {
        arr[i, j] = i;
    }
}

