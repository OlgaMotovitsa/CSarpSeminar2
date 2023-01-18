// 
// создали массив, назвали его array = решили чьл в нем будет 10 элементов 
// новый массив всегда заполнен 0 -лями

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index =0;
    while (index < length)
    {
        collection[index]= new Random().Next(1,10);

        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int posision = 0;
    while (posision < count)
{
    System.Console.WriteLine(col[posision]);
    posision++;
}

}

int[] array = new int[10];

FillArray(array);
PrintArray(array);