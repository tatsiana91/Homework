
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// string NaturalRec(int num)
// {
//     if (num == 0) return string.Empty;
//     else return ($"{num}, ") + NaturalRec(num - 1);
// }

// System.Console.WriteLine("Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(NaturalRec(num));

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.WriteLine("Введите целое число M ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите целое число N ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int Summa(int num1, int num2)
// {
//     if (num1 == num2) return (num2);
//     else return num1 + Summa(num1 + 1, num2);
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {Summa(num1, num2)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
System.Console.WriteLine("Введите целое неатрицательное число m ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое неатрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());
int AckermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AckermanRec(m - 1, 1);
    else return (AckermanRec(m - 1, AckermanRec(m, n - 1)));
}
Console.Write(AckermanRec(m, n));