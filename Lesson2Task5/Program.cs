// 
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

int IndexOf(int[] collection, int find)
{
    int count =  collection.Length;
    int index = 0;
    //int position = 0; - ,было, но если хотим чтобы при поиске 666 числа 
    // не выходил индекс 0 то пишем искусственно int position = -1 и это будет
    // означать, что элемент не найден
    int position = -1;

    while (index < count) 
    {
        if(collection[index] == find)
        {
            // первое вхождение 4рки
        position = index;
        // написать здесь break и покажет индекс первой 4рки
        break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
//искусственно вводим доп элементы array[4]=4 и array[6]=4
array[4]=4;
array[6]=4;
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);