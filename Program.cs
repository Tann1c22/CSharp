//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.WriteLine("Введите натуральное число больше 1 ");
int number = int.Parse(Console.ReadLine());
NumberCounter(number);

//------------Методы-------------//
void NumberCounter (int number)
{
    if (number < 0)
    {
        Console.Write($"{number} не натуральное число");
    } else if (number == 0){
        return;
    }  
    else 
    {
        Console.Write(" " + number);
        NumberCounter (number - 1);
    }

}
*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
SumOfNums(num1, num2, 0);
//Работает только если первое число меньше второго

void SumOfNums(int num1, int num2, int result)
{
    
    if (num1 > num2) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {result}"); 
        return;
    }
    result = result + (num1++);
    SumOfNums(num1, num2, result);

}
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Akk(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

