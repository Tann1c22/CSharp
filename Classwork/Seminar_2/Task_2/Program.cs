//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//78 -> 8

//12-> 2

//85 -> 8

//int number = new Random().Next(10, 100);
//string num = number.ToString();

//Console.WriteLine(number);
//if(num[0]>num[1]){
 //   Console.WriteLine(num[0]);
//}
//else{
   // Console.WriteLine(num[1]);
//}

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
int result = 0;

 result = numA % numB;
if (result == 0)
{
    Console.WriteLine("кратно");
} else {
    Console.WriteLine($"не кратно, остаток {result}");
}