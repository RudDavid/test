/*****************************
*  Создал Руднев Д.А.        *
*  Вариант: универсальный    *
*  Язык программирования: C# *
*****************************/

using System;

namespace csharp2
{

    class Program
    {

        static int Exercise1(int arg1, int arg2)
        {

            int result = 1;

            for (int indexI = 0; indexI < arg2; ++indexI)
            {
                result *= arg1;
            }
            return result;

        }

        static void Main()
        {

            int borderForNumber1 = 2;
            int indexElevementOfString = 1;
            int number, pow;
            int indexFirstElementOfString = 0;
            string number1, num;
            char secondNum;

            Console.Write("Please enter the num: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number <= indexFirstElementOfString)
            {
                Console.Write("Please enter the natural number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter the degree: ");
            pow = Convert.ToInt32(Console.ReadLine());

            while (pow <= indexFirstElementOfString)
            {
                Console.Write("Please enter the natural number for the degree: ");
                pow = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Number a to the degree n: " + Exercise1(number, pow));

            // task 2
            Console.Write("Please enter the num for change: ");
            number1 = Console.ReadLine();

            while (number1.Length <= borderForNumber1 || number1[indexFirstElementOfString] == '-')
            {
                Console.WriteLine("Please enter num more than one hundred");
                number1 = Console.ReadLine();
            }

            num = number1;
            secondNum = number1[indexElevementOfString];
            number1 = number1.Remove(1, 1);
            number1 = number1 + secondNum;

            Console.WriteLine("x = " + num);
            Console.Write("n = " + number1);
        }
    }
}