// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

void Search(int[,] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == num)
            {
                count++;
            }
    }
    if(count>0)
    {
        System.Console.WriteLine($"Ваше число встречается в массиве {count} раз");
    }
    else
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }


}

System.Console.WriteLine("значение которое вы ищете: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

Search(array, num);