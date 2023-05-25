// Console.WriteLine("введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
//     Console.WriteLine("{перве число} - максимальное значение, {второе число} - минимальное значение");
// else Console.WriteLine("{второе число} - максимальное значение, {первое число} - минимальное значение");

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num2 > num1)
//     if (num2 > num3)
// {
// Console.WriteLine($"Max: {num2}"); 
// }   
//     else
//     {
//          Console.WriteLine($"Max: {num3}"); 
//     }
//     else if(num1>num3)
//     {
//          Console.WriteLine($"Max: {num1}"); 
//     }

//     : Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num%2==0)
// {
//     System.Console.WriteLine("число четное");
// }
// else
// {
//    ; System.Console.WriteLine("число нечетное")
// }
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if (Number > 1)
{
    while (evenNumber <= Number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
