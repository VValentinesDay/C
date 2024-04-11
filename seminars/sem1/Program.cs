// Console.WriteLine("Write sm number wich will be mult by 2 :");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Your result is " + a*2);
// System.Console.WriteLine();
// System.Console.WriteLine("Пример хитрой вставки через знак долара");
// System.Console.WriteLine($"Квадрат числа {a} это {a*a}");
// System.Console.WriteLine();
// System.Console.WriteLine("Чтобы закомментировать код используется связка ctrl+/");
// int b = 10;
// System.Console.WriteLine();
// System.Console.WriteLine("Работа с блоком if");
// if (b == a*b - b) {System.Console.WriteLine(' ');}
// else{
//     System.Console.WriteLine("...");
// }



//Задача, чтобы при вводе числа выводился ряд от -чилос до число
System.Console.WriteLine("Write N:");
int N =  Convert.ToInt32(Console.ReadLine());
int start =  -N;

while(start<=N){
    // Console.Write(start + ' '); // Видимо шарп не умеет в конкатенацию чаров и прочего
     Console.Write(start + " ");
    start++;
}
//Условия и && и или ||
if (N > 99 && N < 999) {System.Console.WriteLine("Число не трёхзначное");}





