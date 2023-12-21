//Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] NewArray(int length, int min, int max)
{
    int[]array = new int[length];

    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}


void SwapArray(int[] array, int index)
{
    if (index >= array.Length)
        return;
    SwapArray(array, index+1);
    if (index < array.Length-1)
    Console.Write(", ");
    Console.Write(array[index]);
}

Console.WriteLine();
Console.Write("Write min count: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Write max count: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Write length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = NewArray(length, min, max);
Console.WriteLine(String.Join(", ", array));   
SwapArray(array, 0);
Console.WriteLine();


