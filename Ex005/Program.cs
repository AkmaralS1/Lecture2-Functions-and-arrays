//  взять, например, метод, передать в него массив и заполнить массив нужным количеством элементов. На следующем этапе опишем метод, который будет выводить все элементы по порядку. Затем превратим наш код поиска нужного индекса в метод. 

// Определяем новый массив
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

// Теперь сделаем метод void, который будет печатать массив
void PrintArray(int[] col)


{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// метод IndexOf - находим позицию нужного элемента в массиве. 
int IndexOf(int[] col, int find)
{
    int count = col.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(col[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Определили массив из 10 элементов

FillArray(array); // метод который заполнит нам массив
PrintArray(array); // метод который все распечатает
Console.WriteLine(); // пустая строчка

int pos = IndexOf(array, 4); // результа работы метода IndexOF
Console.WriteLine(pos); // вывод на экран