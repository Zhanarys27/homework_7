

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 31);
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

// void RandomMatrix(int[,] array1)
// {
//     int LenRows = array1.GetLength(0);
//     int LenCols = array1.GetLength(1);
//     int[,] array2 = new int[LenRows, LenCols];
//     for(int i = 0 ; i<LenRows; i++)
//     {
//         for (int j = 0; j < LenCols; j++)
//         {
//             int rand = new Random().Next(LenCols*LenRows);

//         }
//     }
// }

// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// if (rows * cols % 2 == 0)
// {
//     int[,] array = new int[rows, cols];
//     FillArray(array);
//     PrintArray(array);
    
//     // System.Console.WriteLine();
//     // PrintArray(array);
// }
// else
// {
//     System.Console.WriteLine("Введенная матрица не четная!");
// }


int [] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);

}
foreach (var item in arr)
{
    System.Console.Write(item);
}
System.Console.WriteLine();
Array.Sort(arr);
foreach (var item in arr)
{
    System.Console.Write(item);
}