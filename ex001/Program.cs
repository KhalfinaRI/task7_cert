// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumbers(int m, int n)
{
    if (m < n)

    {
        if (m > 0)
            Console.Write(m + ", ");
        PrintNumbers(m + 1, n);
    }

}

PrintNumbers(-2, 3);
Console.WriteLine();