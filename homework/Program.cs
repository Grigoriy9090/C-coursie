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

// Домашняя задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] array = new int[,]
//         {
//             {5, 2, 9, 1},
//             {3, 8, 4, 6},
//             {7, 0, 2, 5}
//         }; // создаем двумерный массив

//         // выводим исходный массив на экран
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // упорядочиваем элементы каждой строки по возрастанию
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 for (int k = j + 1; k < array.GetLength(1); k++)
//                 {
//                     if (array[i, j] > array[i, k])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
//             }
//         }

//         // выводим упорядоченный массив на экран
//         Console.WriteLine("Упорядоченный массив:");
//         PrintArray(array);

//         Console.ReadKey();
//     }

//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Домашняя задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] array = new int[,]
//         {
//             {5, 2, 9, 1},
//             {3, 8, 4, 6},
//             {7, 0, 2, 5}
//         }; // создаем двумерный массив

//         // выводим исходный массив на экран
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // находим строку с наименьшей суммой элементов
//         int minRow = 0;
//         int minSum = int.MaxValue;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int rowSum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 rowSum += array[i, j];
//             }
//             if (rowSum < minSum)
//             {
//                 minRow = i;
//                 minSum = rowSum;
//             }
//         }

//         // выводим строку с наименьшей суммой элементов на экран
//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
//         Console.WriteLine($"Сумма элементов в этой строке: {minSum}");

//         Console.ReadKey();
//     }

//     static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Домашняя задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] matrix1 = new int[,]
//         {
//             {1, 2},
//             {3, 4},
//             {5, 6}
//         }; // создаем первую матрицу

//         int[,] matrix2 = new int[,]
//         {
//             {7, 8, 9},
//             {10, 11, 12}
//         }; // создаем вторую матрицу

//         // выводим исходные матрицы на экран
//         Console.WriteLine("Первая матрица:");
//         PrintMatrix(matrix1);

//         Console.WriteLine("Вторая матрица:");
//         PrintMatrix(matrix2);

//         // проверяем, можно ли перемножить матрицы
//         if (matrix1.GetLength(1) != matrix2.GetLength(0))
//         {
//             Console.WriteLine("Нельзя перемножить эти матрицы");
//             Console.ReadKey();
//             return;
//         }

//         // создаем новую матрицу для записи результата
//         int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

//         // перемножаем матрицы
//         for (int i = 0; i < matrix1.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix2.GetLength(1); j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < matrix1.GetLength(1); k++)
//                 {
//                     sum += matrix1[i, k] * matrix2[k, j];
//                 }
//                 resultMatrix[i, j] = sum;
//             }
//         }

//         // выводим результат на экран
//         Console.WriteLine("Результат умножения матриц:");
//         PrintMatrix(resultMatrix);

//         Console.ReadKey();
//     }

//     static void PrintMatrix(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Домашняя задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// using System;// без рекурсии

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число N: ");
//         int n = int.Parse(Console.ReadLine());
//         PrintNumbers(n);
//     }

//     static void PrintNumbers(int n)
//     {
//         Console.Write(n + ", ");
//         if (n > 1)
//         {
//             PrintNumbers(n - 1);
//         }
//     }
// }

// System.Console.WriteLine("Введите число N: ");//Не работает.как повернуть отсчет в обратную сторону
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// string PrintNumber(int start, int end)
// {
//     if(start==end)
//     {
//         return start.ToString();
//     }
//     return (PrintNumber(start+1, end));
// }
// System.Console.WriteLine(PrintNumber(count, num));

// Домашняя задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// using System;

// class Program {
//     static void Main(string[] args) {
//         int M = 1;
//         int N = 15;
//         Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {Sum(M, N)}");

//         M = 4;
//         N = 8;
//         Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {Sum(M, N)}");
//     }

//     static int Sum(int start, int end) {
//         if (start == end) {
//             return start;
//         } else {
//             return start + Sum(start + 1, end);
//         }
//     }
// }

// Домашняя задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// using System;

// class Program {
//     static void Main(string[] args) {
//         int m = 2;
//         int n = 3;
//         Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");

//         m = 3;
//         n = 2;
//         Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
//     }

//     static int Ackermann(int m, int n) {
//         if (m == 0) {
//             return n + 1;
//         } else if (n == 0) {
//             return Ackermann(m - 1, 1);
//         } else {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }
// }