// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);
int result = (num / 100) * 10 + num % 10;
System.Console.WriteLine(result);
// System.Console.WriteLine($"{num} -> {result}");
// Этот вывод пишем вместо строки 7 и 9