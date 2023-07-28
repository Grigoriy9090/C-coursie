// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Домашняя зада 47: Задайте двухмерны массив m*n, Заполненный случайными числами.
// Вот пример кода на C#, который создает двумерный массив размером 3 на 4 и заполняет его случайными числами:


using System;

class Program {
    static void Main(string[] args) 
    {
        int m = 3; // количество строк
        int n = 4; // количество столбцов
        int[,] arr = new int[m, n]; // создаем двумерный массив

        Random rnd = new Random(); // создаем объект для генерации случайных чисел

        // заполняем массив случайными числами
        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                arr[i, j] = rnd.Next(10); // генерируем случайное число от 0 до 9
            }
        }

        // выводим массив на экран
        for (int i = 0; i < m; i++) 
        {
            for (int j = 0; j < n; j++) 
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


// Программа создает массив размером 3 на 4, заполняет 
// его случайными числами от 0 до 9 и выводит его на экран:


// 7 5 3 6 
// 1 9 2 8 
// 4 5 3 6