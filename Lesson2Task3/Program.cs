// See https://aka.ms/new-console-template for more information

int[] array = {1, 12, 42, 4, 18, 66, 46, 27, 18, };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

if (array[index] == find)
{
    System.Console.WriteLine(index);
}
index++;
}