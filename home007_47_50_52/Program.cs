/*Задача 47. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void ArrayRandom47 (double[,] array47)
{
    for (int i = 0; i < array47.GetLength(0); i++)
    {
        for (int j = 0; j < array47.GetLength(1); j++)
        {
            array47[i, j] = Math.Round(new Random().NextDouble(), 4) * 100; //в целом это работает, но иногда проскакивают числа с множеством занков после запятой.Почему?
            Console.Write(array47[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество элементов в массиве M: ");
int m47 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в массиве N: ");
int n47 = Convert.ToInt32(Console.ReadLine());
double [,] array47 = new double[m47,n47];
ArrayRandom47(array47);

/*Задача 50. Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива 
и возвращать значение элемента, стоящего в этой позиции. Если такой позиции в массиве нет, то сообщить об этом пользователю.
Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. Использование методов для заполнения массива обязательно.
Остальное можно реализовать в главной программе.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.*/

void ArrayRandom(int[,] array50)
{
for (int i = 0; i < array50.GetLength(0); i++)
    {
        for (int j =0; j < array50.GetLength(1); j++)
        {
            array50[i, j] = new Random().Next(1,10);
            Console.Write(array50[i, j] + " ");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите количество элементов в массиве M: ");
int m50 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов в массиве N: ");
int n50 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [m50,n50];
ArrayRandom(array);
Console.WriteLine();

Console.Write("Введите позицию M1: ");
int M50 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию N1: ");
int N50 = Convert.ToInt32(Console.ReadLine());
if (M50 >= array.GetLength(0) | N50 >= array.GetLength(1))
{
    Console.WriteLine("В массиве отсутствует элемент в такой позиции");
}
else
{
    Console.WriteLine($"В массиве присутствует элемент в такой позиции, его значение {array[M50,N50]}");
}

/*Задача 52. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void ArrayRandom52(int[,] array52)
{
for (int i = 0; i < array52.GetLength(0); i++)
    {
        for (int j =0; j < array52.GetLength(1); j++)
        {
            array52[i, j] = new Random().Next(1,10);
            Console.Write(array52[i, j] + " ");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве M: ");
int n52 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве N: ");
int m52 = Convert.ToInt32(Console.ReadLine());
int[,] array52 = new int [n52,m52];
ArrayRandom52(array52);

double avarage = 0;
for (int j = 0; j < array52.GetLength(1); j++)
{
    for (int i = 0; i < array52.GetLength(0); i++)
    {
        avarage = (avarage + array52[i, j]);
    }
    avarage = Math.Round(avarage/n52, 1);
    Console.Write(avarage + "; ");
}
