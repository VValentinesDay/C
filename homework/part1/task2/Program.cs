      int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
      int count = 0;
      
     for (int i = 0; i < numbers.Length; i++) 
      { 
         if( numbers[i]<= 90 && numbers[i]>=10) 
           {
         count++;
            }
      }
      return count;
    }


             
        void PrintResult(int[] array)
    {
        
          //Введите сюда свое решение
 
          int minRange = 1;
        int maxRange = 100;
        // for(){}
          Console.WriteLine(CountItemsRange(array, minRange, maxRange));
    }

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива

PrintResult(array);
