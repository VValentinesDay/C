// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void Many(int a, int b)
// {
//     if (a < b)
//     {
//         if (a <= b)
//         {
//             System.Console.WriteLine(a);
//             Many(a + 1, b);
//         }
//     }
//     else if (a > b)
//     {
//         if (b <= a)
//         {
//             System.Console.WriteLine(b);
//             Many(a, b + 1);
//         }
//     }
//     else
//     {
//         System.Console.WriteLine(a);
//     }
// }

// Many(1, 6);

// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Написано на основе определения Петер

// int Akkn(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1; // базовый случай, условие выхода
//     }
//     else if (m == 0)
//     {
//         return Akkn(n - 1, 1);
//     }
//     else
//     {
//         return Akkn(n - 1, Akkn(n, m - 1));
//     }
// }

// System.Console.WriteLine(Akkn(3, 2));


// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };




// void Elements(int[] arr)
// {
//     if (arr.Length != 1)
//     {
//         System.Console.WriteLine(arr[arr.Length - 1]);

//         int[] arrcut = new int[arr.Length - 1];
//         Array.Copy(arr, 0, arrcut, 0, arr.Length - 1); // наверное есть решение по-проще
//         Elements(arrcut);
//     }
//     else
//     {
//         System.Console.WriteLine(arr[0]);
//     }
// }

// Elements(arr);





void Elements(int[] arr)
{
    void Number(int[] arr, int res)
    {
        if (res >= 0)
        {
            System.Console.Write(arr[res] + " ");
            Number(arr, res - 1);
        }
    }
    Number(arr, arr.Length - 1);
}

Elements(arr);
