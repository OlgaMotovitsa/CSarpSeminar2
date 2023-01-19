
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay < 6) 
{
  System.Console.WriteLine(numberDay + " " + "будний день");
}
else if (numberDay < 8)
{
  System.Console.WriteLine(numberDay + " " + "выходной");  
}
else if ((numberDay == 0) || (numberDay > 8 ))
{
  System.Console.WriteLine ( "Недопустимое значение");  
}





