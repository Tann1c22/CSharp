//---------------------------------------------Задача 41----------------------------------------------------//

//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
/*
Console.WriteLine("Введите кол-во чисел");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.Write("          Количество положительных чисел больше нуля равно " + CountNumsMoreThanZero(array, num));

//--------------------------------Методы-------------------------------//

int[] FillArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(-10,10);
        Console.Write(" " + array[i]);
    }
    return array;
}
int CountNumsMoreThanZero (int [] array, int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
*/

//---------------------------------------------Задача 41----------------------------------------------------//

//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

Console.WriteLine("Введите размер массива больше 6");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 6)
{
    Console.WriteLine("Вы ввели размер массива меньше шести");
}
else
{
    int[] array = FillArray(size);
    int[] array2 = Sort(array);
    Console.Write($"     Упорядоченный по возрастанию массив - {String.Join(", " , array)}");
}

//--------------------------------------------------Методы---------------------------------------------------//

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 101);
        Console.Write(" " + array[i]);
    }
    return array;
}

int[] Sort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}
