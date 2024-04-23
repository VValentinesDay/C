// int[,] table = new int[3, 3];
// Random rnd = new Random();

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         // Random rnd = new Random(); чтобы объект не создавать каждый раз в циклах, его выносят


//         table[i, j] = rnd.Next(1, 11);// м/у 1 и 10
//     }
// }

// for (int i = 0; i < table.GetLength(0); i++)
// {

//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         // Random rnd = new Random(); чтобы объект не создавать каждый раз в циклах, его выносят


//         System.Console.Write($"{table[i, j]} "); //интерполяция строк

//     }
//     System.Console.WriteLine();
// }


// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rows, int colomns, int min, int max)
{
    int[,] matrix = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            matrix[i, j] = 1;
        }
    }

    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}


void PrintMatrix1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write(array[i] + " ");

    }
}


// void Sq(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0)
//             {
//                 if (j % 2 == 0)
//                 {
//                     array[i,j] = 2;
//                 }
//             };
//         }
//         System.Console.WriteLine();
//     }
// }


int[,] Arr = CreateMatrix(3, 5, 1, 1);

// PrintMatrix(Arr);
// PrintMatrix(Arr);

// Sq(Arr);

// PrintMatrix(Arr);

// PrintMatrix(CreateMatrix(3, 5, 1, 1));



int[] MiddleArr(int[,] array)
{
    int[] result = new int[array.GetLength(0)];

    int sum = 0;

    for (int r = 0; r < result.Length; r++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // result[r] += array[i, j];
                sum += array[i, j];
            }
            // result[r] = result[r] / array.GetLength(1);

            result[r] = sum;

            sum = 0;
        }
    }

    return result;

}

// PrintMatrix1(MiddleArr(Arr));



int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

System.Console.WriteLine(numbers.GetLength(1));

System.Console.WriteLine(numbers[2,0]);
