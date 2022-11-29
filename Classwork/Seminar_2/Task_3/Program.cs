//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());

if (numA * numA == numB || numB * numB == numA)
{
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}*/