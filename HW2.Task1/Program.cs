// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32 (System.Console.ReadLine());

int firstNum = number / 10;
int secondNum = firstNum % 10;

System.Console.WriteLine($"{number} -> {secondNum}");



    











