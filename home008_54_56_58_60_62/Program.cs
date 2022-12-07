/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

// Заполнение массива случайными числами и вывод на экран
void ArrayRandom(int[,] array54)
{
    for (int i = 0; i < array54.GetLength(0); i++)
    {
        for (int j = 0; j < array54.GetLength(1); j++)
        {
            array54[i, j] = new Random().Next(1, 10);
            Console.Write(array54[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Сортировка элементов в строках массива по убыванию значений 
void SortLines(int[,] array54)
{
    int temp = 0;
    for (int i = 0; i < array54.GetLength(0); i++) // внешний цикл - по строкам двумерного массива
    {
        for (int j = 0; j < array54.GetLength(1); j++) // средний цикл - по столбцам двумерного массива
        {
            for (int k = j + 1; k < array54.GetLength(1); k++)  // внутренний цикл - по элементам строки          
            {
                if(array54[i,k] > array54[i,j])
                {
                    temp = array54[i, j];
                    array54[i, j] = array54[i, k];
                    array54[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите количество строк (M): ");
int m54 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (N): ");
int n54 = Convert.ToInt32(Console.ReadLine());

int[,] Array54 = new int[m54, n54];

ArrayRandom(Array54);
SortLines(Array54);

Console.WriteLine();

for (int i = 0; i < Array54.GetLength(0); i++)
{
    for (int j = 0; j < Array54.GetLength(1); j++)
    {
        Console.Write(Array54[i, j] + " ");
    }
    Console.WriteLine();
}

/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка(не учтено, если несколько строк с одинаковой суммой)*/

void ArrayRandom56(int[,] array56)
{
    for (int i = 0; i < array56.GetLength(0); i++)
    {
        for (int j = 0; j < array56.GetLength(1); j++)
        {
            array56[i, j] = new Random().Next(1, 10);
            Console.Write(array56[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Sum56(int[,] array56)
{
    int min = 0;
    int index = 0;
    for (int i = 0; i < array56.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array56.GetLength(1); j++)
        {
            sum = sum + array56[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            min = sum;
        }
        else if (sum <= min)
        {
            min = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}");
}

Console.WriteLine("Введите количество строк прямоугольного двумерного массива(M): ");
int m56 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов прямоугольного двумерного массива(N): ");
int n56 = Convert.ToInt32(Console.ReadLine());

int[,] Array56 = new int[m56, n56];
if(m56 > n56 | m56 < n56)
{
    ArrayRandom56(Array56);
    Sum56(Array56);
}
else
{
    Console.WriteLine("Это не прямоугольный массив, в прямоугольном массиве одна сторона больше другой");
}

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

//рандом для массива будет браться из задачи 54:)

void NewArray(int[,] array58, int[,]array1, int[,]array2) 
{
    for (int i = 0; i < array58.GetLength(0); i++)
    {
        for (int j = 0; j < array58.GetLength(1); j++)
        {
            array58[i,j] += (array1[i,j] * array2[i,j]);
            Console.Write(array58[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк двумерного массива(M): ");
int m58 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива(N): ");
int n58 = Convert.ToInt32(Console.ReadLine());

int[,] Array1 = new int[m58, n58];
int[,] Array2 = new int[m58, n58];
int[,] array58 = new int[m58, n58];

ArrayRandom(Array1);
Console.WriteLine();
ArrayRandom(Array2);
Console.WriteLine();
NewArray(array58, Array1, Array2); 

/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);
Console.WriteLine();

// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 4;
            }
        }
    }
}

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array62 = new int[size, size];
ArraySpiral(array62);
WriteArray(array62);

void ArraySpiral(int[,] array62)
{
int temp = 1;
int i = 0;
int j = 0;
    while (temp <= size * size)
    {
        array62[i, j] = temp;
        if (i <= j + 1 && i + j < size - 1)
            {
                j++;
            }
            else if (i < j && i + j >= size - 1)
            {
                i++;
            }
            else if (i >= j && i + j > size - 1)
            {
                j--;
            }
            else
            {
                i--;
            }
        temp++;
    } 
}

void WriteArray (int[,] array62)
{ 
    for (int i = 0; i < array62.GetLength(0); i++)
    {
        for (int j = 0; j < array62.GetLength(1); j++)
        {
            Console.Write(String.Format("{0:d2}", array62[i, j]) + " ");
        }
        Console.WriteLine();
    }
}