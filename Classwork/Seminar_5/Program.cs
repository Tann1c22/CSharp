//Напишите программу, которая принимает на вход число А и выдает сумму от 1 до А

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма от одного до {num} будет равна {SumOfNums(num)}");
//------------------------------------------МЕТОДЫ-------------------------------------------//
int SumOfNums(int limit)
{
    int result = 0;
    for (int i = 0; i <= limit; i++)
    {
        result = i + result;
    }
    return result;
}*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3

//78 -> 2

//89126 -> 5

/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number<0)
{
    number = -number;
}
Console.WriteLine($"В числе {NumOfDigits(number)} цифр");
//-----------------------------------------------Методы---------------------------------------------------------//
int NumOfDigits(int count)
{
    int i = 1;
    int j = 0;
    while (i<count)
    {
        count = count/10;
        j++;
    }
    return j;
}*/
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

int[] arraySize = FillArray(10);
Console.WriteLine($"{String.Join(",", arraySize)}");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"{sumArray(arraySize, num)}");

//-------------------------------МЕТОД----------------------------------------//

int sumArray(int[] array, int num)
{
    int sum = 1;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < num)
                sum *= array[i];
        }
    return sum;
}

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(50, 101);
    }        
    return arr;
}