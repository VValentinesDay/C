// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char[] chararray = new char[] { 'a', 'b', 'c', 'd', '1', '2', '3', '4' };

string ToString(char[] arr) 
    { 
    string res = "";

        for(int i = 0; i < arr.Length; i++)
        {
            res += arr[i];
        }
    return res;
    }

string res = ToString(chararray);


System.Console.WriteLine(res);



// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StrToCharArr(string str)
{
    char[] chars = new char[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }

    return chars;
}

char[] chars = StrToCharArr(res);

string nS = new string(chars);

System.Console.WriteLine("Новая строка: " + nS);



// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

System.Console.WriteLine("Слово на английском:");

string word = Console.ReadLine();

int CalculLetters(string str){
    if(char)
}