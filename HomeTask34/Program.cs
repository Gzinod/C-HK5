// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = FillArray(15);
Print(array);
System.Console.WriteLine(FindEvenNumber(array));


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}



void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

int FindEvenNumber(int[] count)
{
    int result=0;
       foreach (var item in count)
    {
            if(item%2==0)
        {
            result++;
        }
    }
     return result;
}
