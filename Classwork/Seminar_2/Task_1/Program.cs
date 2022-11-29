//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46

int number = new Random().Next(100,1000);

string num = number.ToString();
Console.WriteLine($"{number} - число со вторым знаком");
Console.WriteLine($"{num[0]}{num[2]} - число без второго знака");