using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            try
            {
                int getNumber = Convert.ToInt32(Console.ReadLine());
                bool isPrimeNumber = IsPrimeNumber(getNumber);
                if (isPrimeNumber)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Строка не является числом");
            }

            //Задание 3
            Console.WriteLine(FibonachiRec(10));
            Console.WriteLine(FibonachiCycle(10));
            Console.ReadLine();
        }

        static public bool IsPrimeNumber(int number)
        {
            int d = 0;
            int i = 2;
            if (number <= 1)
            {
                return false;
            }
            
            while (true)
            {
                if (i < number)
                {
                    if (number % i == 0)
                    {
                        d++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    return (d == 0);
                }
            }
        }
        //Задание 2
        public static int StrangeSum(int[] inputArray) //O(n*n*n) = O(n^3)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) //O(n)
            {
                for (int j =0; j < inputArray.Length; j++) //O(n)
                {
                    for (int k = 0; k < inputArray.Length; k++) //O(n)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[j] + i + k + j + y;
                    }

                }
            }
            return sum;
        }
        
        //Задание 3
        public static int FibonachiCycle(int n, int num1 = 0, int num2 = 1)
        {
            if (n <= 1) return num1;
            int num;
            for (int i = 2; i <= n; i++)
            {
                num = num1;
                num1 = num2;
                num2 = num2 + num;
            }
            return num2;
        }
       
        static int FibonachiRec(int n, int num1 = 0, int num2 = 1)
        {
            return n == 0 ? num1 : FibonachiRec(n - 1, num2, num1 + num2);
        }
    }
}
