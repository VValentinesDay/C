// ЗАДАНИЕ 1
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


// System.Console.WriteLine("Введите целое число");
// int a = Convert.ToInt32( System.Console.ReadLine());


// if (a%7 == 0 && a%23 == 0) {
//     System.Console.WriteLine("число кратно 7 и 23.");
// }
// else{
//     System.Console.WriteLine("число не кратно 7 и 23.");
// }

// ЗАДАНИЕ 2
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите координату Х, не ноль");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y, не ноль");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > 0) { if (b>0){
//  System.Console.WriteLine("I");
// }else{
//     System.Console.WriteLine("IV");
// }
// }
// else { 
//     if (b>0){
//  System.Console.WriteLine("II");
// }else{
//     System.Console.WriteLine("III");
// }
// }

// ЗАДАНИЕ 3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// System.Console.WriteLine("Введите число от 10 до 99");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a > 99 &&  a < 10) { 
//     System.Console.WriteLine("Число вне диапозона, error32");
// }

// int a1 = a/10;
// int a2 = a%10;

// if (a1 >= a2) {System.Console.WriteLine(a1);}
//     else {System.Console.WriteLine(a2);}

// ЗАДАНИЕ 4
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
System.Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0 ) { a = a *(-1);}

while(a >= 0){

        System.Console.Write(a);
        if (a > 0) {System.Console.Write(",");}
        a--;
    }

