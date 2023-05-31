// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int rev1 = number / 10 % 10;
int rev2 = number % 10;
 
            if  (num1 == rev2 && num2 == rev1)
            {
            Console.WriteLine("Введенное число палиндром");
            }
            else
            {
            Console.WriteLine( "Введенное число не палиндром");
            }

       


 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine($"Введите число :");
int num = int.Parse(Console.ReadLine())!;

for (int i = 1; i <= num; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

    System.Console.WriteLine("Введите координату x1");
    double x1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите координату y1");
    double y1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите координату z1");
    double z1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите координату x2");
    double x2 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите координату y2");
    double y2 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите координату z2");
    double z2 = Convert.ToDouble(Console.ReadLine());
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
    {
        Console.WriteLine(dist);
    }
