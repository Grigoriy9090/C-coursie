// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Домашняя зада 47: Задайте двухмерны массив m*n, Заполненный случайными числами.
// Вот пример кода на C#, который создает двумерный массив размером 3 на 4 и заполняет его случайными числами:


// using System;

// class Program {
//     static void Main(string[] args) 
//     {
//         int m = 3; // количество строк
//         int n = 4; // количество столбцов
//         int[,] arr = new int[m, n]; // создаем двумерный массив

//         Random rnd = new Random(); // создаем объект для генерации случайных чисел

//         // заполняем массив случайными числами
//         for (int i = 0; i < m; i++) 
//         {
//             for (int j = 0; j < n; j++) 
//             {
//                 arr[i, j] = rnd.Next(10); // генерируем случайное число от 0 до 9
//             }
//         }

//         // выводим массив на экран
//         for (int i = 0; i < m; i++) 
//         {
//             for (int j = 0; j < n; j++) 
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Программа создает массив размером 3 на 4, заполняет 
// его случайными числами от 0 до 9 и выводит его на экран:


// 7 5 3 6 
// 1 9 2 8 
// 4 5 3 6

// Домашняя задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

// using System;

// class Program
// {

//     static void Main(string[] args)
//     {
//         int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // пример двумерного массива

//         Console.Write("Введите номер строки: ");
//         int row = int.Parse(Console.ReadLine());
//         Console.Write("Введите номер столбца: ");
//         int column = int.Parse(Console.ReadLine());

//         if (row >= array.GetLength(0) || column >= array.GetLength(1))
//         {
//             Console.WriteLine("Такого элемента не существует!");
//         }
//         else
//         {
//             Console.WriteLine("Значение элемента: " + array[row, column]);
//         }

//         Console.ReadKey();
//     }
// }

// Домашняя задача 52: Задайте двумерный массив из целых чисел. Найдите средннее арифметическое элементов в каждом столбце.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // пример двумерного массива

//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         for (int j = 0; j < columns; j++)
//         {
//             double sum = 0;
//             for (int i = 0; i < rows; i++)
//             {
//                 sum += array[i, j];
//             }
//             double average = sum / rows;
//             Console.WriteLine("Среднее арифметическое элементов в столбце " + j + ": " + average);
//         }

//         Console.ReadKey();
//     }
// }

