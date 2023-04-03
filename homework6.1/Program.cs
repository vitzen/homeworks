﻿//Домашнее заданий 6.1
//Написать метод-рекурсию для вычисления N-ого элемента последовтельности Фиббоначчи

using System;

namespace homework6._1
{
    class Program
    {
        ///
        /// <summary>
        /// Метод, осуществляющий парсинг символа от пользователя
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void Parsing(string inputFromUser)
        {
            string unknownInput = inputFromUser;
            bool input = Int32.TryParse(unknownInput, out int nElement);
            if (input)
            {
                Print(Fibonachi(nElement));;
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }      
        }
        
        /// <summary>
        /// Алгоритм поиска n-т-ого элемента в ряду Фибоначчи
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        /// <summary>
        /// Метод для вывода на консоль
        /// </summary>
        /// <param name="fibonachResult"></param>
        public static void Print(int fibonachResult)
        {
            Console.WriteLine($"n-ое число Фибоначчи = {fibonachResult}");
        }

        public static void Main()
        {
            Console.WriteLine(
                "Программа для вычисления N-ого элемента последовтельности Фиббоначчи, используя метод-рекурсию \n" +
                "Введите n-ый элемент для вычисления его в ряду Фибоначчи");
            string inputSymbol = Console.ReadLine();
            Parsing(inputSymbol);
            
            
            // Delay
            Console.ReadKey();
        }
    }
}