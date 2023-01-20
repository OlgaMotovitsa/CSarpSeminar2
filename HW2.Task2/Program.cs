// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32 (System.Console.ReadLine());
int result = 0;

if (number < 100)

{
    System.Console.WriteLine("В числе нет третьей цифры");
}

else
{
    while (number > 1000)
    {
        number = number / 10;
    }

    result = number % 10;


System.Console.WriteLine($"-> {result}");
}

