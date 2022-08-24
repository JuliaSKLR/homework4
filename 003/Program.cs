//  Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. 
//И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] generateArray(int length)             //создаем массив от 0 до 100
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void printArray(int[] array)                //  печатаем массив
{
    int count = 0;
    while (count < array.Length)
    {
        System.Console.Write($"{array[count]}\t ");
        count++;
    }
}

int[] array = generateArray(8);
printArray(array);


int FindMax(int[] array)            //функция поиска макса по индексу
{
    int max = array[0];
    int indexMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
            indexMax = i;
        }

    }
    return indexMax;
    
}

int result = FindMax(array);   //нашли первый макс 
System.Console.WriteLine($"Максимальное первое {array[result]}");     
array[result] = 0;              //обнуляем максимальное, чтобы найти второе 
result = FindMax(array);
System.Console.WriteLine($"Максимальное второе {array[result]}");

