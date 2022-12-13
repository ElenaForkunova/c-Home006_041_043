/*Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*Метод вывода натуральных чисел от N до 1:*/
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не подходит");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

Console.WriteLine("Введите натуральное число больше 1: ");
int number = int.Parse(Console.ReadLine());
NumberCounter(number);

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

//метод нахождения сумма натуральных элементов
void NumberSum (int m66, int n66, int sum)
{
    if (m66 > n66) 
    {
    Console.Write($"Сумма атуральных элементов в промежутке от M до N равна: {sum}");
    return;
    }
    sum = sum + (m66++);
    NumberSum(m66, n66,sum);
}
Console.WriteLine();
Console.WriteLine("Введите первое значение M: ");
int m66 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение:N ");
int n66 = Convert.ToInt32(Console.ReadLine());
NumberSum (m66, n66, 0);

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

///Метод вычисления функции Аккермана:
int AckermannFunction (int M68, int N68)
{
    if (M68 == 0) return N68 + 1;
    if (M68 != 0 && N68 == 0) return AckermannFunction(M68 - 1, 1);
    if (M68 > 0 && N68 > 0) return AckermannFunction(M68 - 1, AckermannFunction(M68, N68 - 1));
    return AckermannFunction(M68, N68);
}

Console.WriteLine();
Console.WriteLine("Введите начальное число M:");
int M68 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число N:");
int N68 = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для чисел A({M68},{N68}) = {AckermannFunction(M68, N68)}");