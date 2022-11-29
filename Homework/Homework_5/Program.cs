//-----------------------------------------------------------Задача 34--------------------------------------------------------------------//

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
FillArray(size, array);
EvenNums(array, size);

//------------------------------------------Методы---------------------------------------------//

int[] FillArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,999);
        Console.Write(array[i] + " ");
    }
    return array;
}
void EvenNums (int[] array, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("         Кол-во четных чисел равно " + count);
}
*/



//-----------------------------------------------Задача 36--------------------------------------------------//



//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
FillArray(size, array);
Console.WriteLine("    Сумма чисел с нечетными индексами равна " + SumOfNotEvenNums(size, array));

//--------------------------------------Методы--------------------------------------//

int[] FillArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100,100);
        Console.Write(array[i] + " ");
    }
    return array;
}
int SumOfNotEvenNums(int size, int[] array)
{
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 1 || i == 1)
        {
            result = result + array[i];
        }
    }
    return result;
}
*/


//-----------------------------------------------Задача 37--------------------------------------------------//


//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayA = new int [size];
int[] arrayB = FillArray(size, arrayA);
ArrayOfPairNums(size, arrayB);

//--------------------------------------Методы--------------------------------------//

int[] FillArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100,100);
        Console.Write(array[i] + " ");
    }
    return array;
}
void ArrayOfPairNums(int size, int[] arrayB)
{
    int j = 0;
    int y = size - 1;
    for (int i = 0; i <= (size - 1)/2; i++)
    {
        if(i == size / 2)
        {
            arrayB[j] = arrayB[y];
            Console.Write(" " + arrayB[i]);
        } else {
            arrayB[j] = arrayB[i] * arrayB[y];
            j++;
            y--;
            Console.Write(" " + arrayB[i]);
        }
    }
}
*/


//-----------------------------------------------Задача 38--------------------------------------------------//

//Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
int[] arrayA = FillArray(size, array);
int result = MaxMinDiff(arrayA, size);
Console.WriteLine("    Разница минимального и максимального значения равна " + result);


//--------------------------------------Методы--------------------------------------//

int[] FillArray(int size, int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-11,11);
        Console.Write(array[i] + " ");
    }
    return array;
}
int MaxMinDiff(int[] array, int size)
{
    int max = 0;
    int min = 0;
    int result = 0;
    array[0] = max;
    array[0] = min;
    for (int i = 1; i < size; i++)
    {
        if(array[i] >= max)
        {
            max = array[i];
        } else if(array[i] <= min)
        {
            min = array[i];
        }
    }
    result = max - min;
    return result;
}
*/