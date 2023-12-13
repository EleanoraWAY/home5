//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int ReadLine(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция (Метод) для заполнения 2D массива целыми (int) числами
int[,] Gen2DArrayInt(int row, int column)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, 100);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) вывода 2D  массива в консоль
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Метод считает сумму элементов строки массива
int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

// Основной код программы

Console.Clear();
// 1. Получение данных от пользователя
int row = ReadLine("Введите количество строк в массиве: ");
int col = ReadLine("Введите количество столбцов в массиве: ");

// 2. Генерируем 2D массив
int[,] arr2D = Gen2DArrayInt(row, col);

// 3. Печатаем 2D Массив
Print2DArr(arr2D);

// 4. Находим строку с наименьшей суммой
int minSumLine = 0;
int sumLine = SumLine(arr2D, 0);
for (int i = 1; i < arr2D.GetLength(0); i++)
{
    int tempSumLine = SumLine(arr2D, i);
    if (sumLine > tempSumLine)

{
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
minSumLine = minSumLine + 1;

// 5. Выводим результат на экран
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumLine);
Console.WriteLine("Наименьшая сумма: " + sumLine);
