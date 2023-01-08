// Определить массив
//Найти минимальное значение
//Отсортировать попорядку

int[] array = {1, 65, 5, 2, 1, 651, 65, 654, 6, 84, 874, 1574, 321};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int countt = array.Length -1;
    for (int i = 0; i < countt; i++)
    {
        int minPosition = i;
        int count = array.Length;
        for (int j = i + 1; j < count; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
 }



PrintArray(array);
SelectionSort(array);
PrintArray(array);
