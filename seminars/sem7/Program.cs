// **Задача 63:** Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

// void NumbersPrint(int a)
// {
//     if (a < 2)
//     {
//         System.Console.WriteLine(1);
//     }
//     System.Console.WriteLine(a);
//     NumbersPrint(a - 1);
// }

// NumbersPrint(5);

// void NumbersPrint(int a)
// {
//     if (a > 0)
//     {
//         NumbersPrint(a - 1);
//         System.Console.WriteLine(a);
//     }
// }
// NumbersPrint(5);



// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

// int Sum(int num)
// {
//     //условие выхода
//     if (num > 0)
//     {
//         return Sum(num / 10) + num % 10;
//     }

//     return 0;
// }


// int res = Sum(102);

// System.Console.WriteLine(res);



// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void Path(int N, int M)
// {
//     if (N < M)
//     {
//         if (N <= M)
//         {
//             System.Console.WriteLine(N);
//             Path((N + 1), M);
//         }
//         else//else if
//         {
//             {
//                 System.Console.WriteLine(M);
//                 Path((M + 1), N);
//             }
//         }
//     }
// }

// Path(1, 5);


// **Задача 69:** Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

int Mult(int a, int b)
{
    if (b != 0)
    {
        return a * Mult(a, b - 1);
    }

    return 1;
}



System.Console.WriteLine(Mult(3, 3));

