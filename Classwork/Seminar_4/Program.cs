//Напишите программу, которая по номеру четверти, показывает диапозон всех возможных координат в этой четверти

/*Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:{
        Console.WriteLine("Это первая четверть");
        break;
    }
    case 2:{
        Console.WriteLine("Это вторая четверть");
        break;
    }
    case 3:{
        Console.WriteLine("Это третья четверть");
        break;
    }
    case 4:{
        Console.WriteLine("Это четвертая четверть");
        break;
    }
    default:{
        Console.WriteLine("Такой четверти не существует");
        break;
    }
}*/

//Задача 17: Определить, является ли заданное шестизначное число счастливым. (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

/*Console.WriteLine("Введите шестизначное число");
string number = Console.ReadLine();
if (number.Length != 5 )
{
    Console.WriteLine("Вы ввели не шестизначное число");
} else {
    if (number[0] + number[1] + number[2] == number[3] + number[4] + number[5])
    {
        Console.WriteLine("Число счастливое");
    } else {
        Console.WriteLine("Число не счастливое");
    }
}*/



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


/*Console.WriteLine("Введите первое число координат по x");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число координат по x");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первое число координат по y");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число координат по y");
double y2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
Console.WriteLine($"result={result:f1}");*/



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//5 -> 1, 4, 9, 16, 25.

//2 -> 1,4

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i,2)} ");
}