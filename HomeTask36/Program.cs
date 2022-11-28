// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] array = FillArray(7);
Print(array);
System.Console.WriteLine();
System.Console.WriteLine(SummOddNumber(array));



int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int SummOddNumber(int[] count)
{
    int result = 0;
    for(int i=0;i<array.Length;i++)
    if ( i%2==1)
    {
       result=result+array[i];
    }
    return result;
}


void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}