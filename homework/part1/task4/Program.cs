// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string str = "asdQWE";

// string Down(string str)
// {
//     return str.ToLower();
// }
// System.Console.WriteLine(Down(str));

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// System.Console.WriteLine("Проверка на полиндром: ");
// System.Console.WriteLine("Введите слово :");

// string word = Console.ReadLine();

// bool flag = true;

// bool PoliCheck(string word) { 
// for(int i = 0; i < word.Length - 1; i++) {
//     if(word[i] == word[word.Length - 1 - i]) {
//         flag = true;
//     }
//     else {flag = false;}
// }
// return flag;
// }

// System.Console.WriteLine(PoliCheck(word));

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.


string meesege = "for the Motherland";




string Versa(string str){
        int spaces = 0;
        string temp = string.Empty;

                for(int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' '){ spaces++; }
                }   

                string[] arr = new string[spaces + 1];


int temp2 = 0;
            for(int j = 0; j < arr.Length; j++) 

           {     
            
            for(int i = temp2; i < str.Length; i++)
                {
                    temp2++;
                    if (str[i] == ' '){ break; }
                    temp += str[i];
                }  
                arr[j] = temp;
                // System.Console.WriteLine(temp);
                temp = "" ;
                 }

        temp = "";

        for(int i = 0; i < arr.Length;i++){
            temp += arr[arr.Length-1-i];
            temp = temp + " ";
        }
return temp;
        }

        string a = Versa(meesege);
System.Console.WriteLine(Versa(meesege));