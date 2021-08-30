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
    }
}
