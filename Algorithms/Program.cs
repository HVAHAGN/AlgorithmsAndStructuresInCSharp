using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от эффективности существует много типов алгоритмов, среди которых можно 
            //выделить следующие типы алгоритмов (перечислены в порядке уменьшения эффективности):
            //1. Константный-Приложение выполняет фиксированное количество операций, которые, как правило, требуют постоянного времени.
            int x = 10;
            if(x>10)
            {
                x--;
            }
            else
            {
                x++;
            }
            
            //5. Кубический (N3) В программах, которые соответствуют этому алгоритму, используются три цикла.
            char[] chars = new char[] { 'A', 'B', 'C' };
            for (int i = 0; i < chars.Length; i++)
            {

                for (int j = 0; j < chars.Length; j++)
                {
                    for (int k = 0; k < chars.Length; k++)
                    {
                        Console.WriteLine($"{chars[i]} {chars[j]} {chars[k]}");
                    }

                }
            }
            /*
A A A
A A B
A A C
A B A
A B B
A B C
A C A
A C B
A C C
B A A
B A B
B A C
B B A
B B B
B B C
B C A
B C B
B C C
C A A
C A B
C A C
C B A
C B B
C B C
C C A
C C B
C C C
             
             */

            Console.ReadLine();
        }

        //2. Логарифмический (logN)-Выполняется медленнее, чем программы с постоянным временем. 
        //Примером подобного алгоритма может служить алгоритм бинарного поиска.
        public static int Rank(int key, int[]numbers)
        {
            int low = 0;
            int high = numbers.Length - 1;
            while (low <= high)
            {// находим середину
                int mid = low + (high - low) / 2;
                // если ключ поиска меньше значения в середине
                // то верхней границей будет элемент до середины
               if(key<numbers[mid])
                {
                    high = mid - 1;
                }
                else if(key>numbers[mid])
                {
                    low = mid + 1;

                }
               else
                {
                    return mid;
                }  
            }
            return -1;
        }
        /*Линейный (N) Как правило, встречается там, где метод основан на цикле. К примеру, функция факториала:*/
            public static int Factorial (int n)
        {
            int result = 1;
            for (int i = 1; i <=n; i++)
            {
                result *= i;

            }
            return result;

        }
        public static int Factoiral2(int x)
        {
            if (x == 0)
                return 1;
            else 
                return x* Factoiral2(x-1); 
        }

        /* 3. Линейно-логарифмический (NlogN)Примером подобного алгоритма может служить сортировка слиянием (merge sort)
        4. Квадратичный (N2) Как правило, методы, которые соответствуют данному алгоритму, содержит два цикл - внешний и вложенный, 
        которые выполняются для всех значений вплоть до N. В качестве примера можно привести программу сортировки пузырьком (bubble sort)
        массива из N элементов, в которой в худшем случае нам надо совершить обход N*N элементов с помощью двух циклов:*/
        public static void BubbleSort(int[] nums)
        {
            int temp;
            for (int i = 0; i <nums.Length-1; i++)
            {
                for (int j =i+ 1; j <nums.Length; j++)
                {
                    if(nums[i]>nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }

            }
        }

    }
}
