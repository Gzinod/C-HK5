// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = FillArray(5);

Print(array);
System.Console.WriteLine();
void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

System.Console.WriteLine(FindDifferenceOfMaxAndMin(array));


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int FindDifferenceOfMaxAndMin(int[] numbers)
{
    int max = numbers[0];
    int min = numbers[0];
    foreach (var item in numbers)
    {
        if(item > max)
        {
            max = item;
        }
        else
        {
            if(item < min)
            {
                min = item;
            }
        }
    }   
    int difference= max - min;
    return (difference);
}