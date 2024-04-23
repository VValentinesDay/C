// Массивы

//Метод слздания массива

int[] CreateArray(int size, int min, int max)
{
    int[] Array = new int[size];


    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(min, max + 1);
    }

    return Array;
}

void PrintArray(int[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
    System.Console.WriteLine();
}

bool Find(int f, int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == f)
        {
            return true;
        }
    }
    return false;
}






System.Console.WriteLine("Количество");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Мин");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Макс");
int c = Convert.ToInt32(Console.ReadLine());

int[] A = CreateArray(a, b, c);

System.Console.WriteLine("Вывод массива:");

PrintArray(A);

System.Console.WriteLine("Число для поиска");
int f = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Find(f, A));