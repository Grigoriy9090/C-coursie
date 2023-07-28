// echo "# 1111-A" >> README.md
// git init
// git add README.md
// git commit -m "first commit"
// git branch -M main
// git remote add origin https://github.com/Grigoriy9090/1111-A.git
// git push -u origin main




// git remote add origin https://github.com/Grigoriy9090/1111-A.git
// git branch -M main
// git push -u origin main

// Console.WriteLine("Hello, World!");

// // Домашнее задание: Задача 2: Напишите программу на языке C#, которая на вход принимает два числа и выдаёт, 
// // какое число большее, а какое меньшее 
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// // Console.WriteLine ("Ввидите первое число");
// // int a = int.Parse(Console.ReadLine());
// // Console.WriteLine ("Ввидите второе число");
// // int b = int.Parse(Console.ReadLine());
// // int max = Math.Max (a,b);
// // int min = Math.Min (a,b);
// // Console.WriteLine ($"Максимальное число: {max}");
// // Console.WriteLine ($"Минимальное число: {min}");

// // Домашнее задание: Задача 4: Напишите программу которая принимает на вход три числа и выдает 
// // максимальное их этих чисел:

// // Console.WriteLine ("Ввидите первое число");
// // int a = int.Parse(Console.ReadLine());
// // Console.WriteLine ("Ввидите второе число");
// // int b = int.Parse(Console.ReadLine());
// // Console.WriteLine ("Ввидите третье число");
// // int c = int.Parse(Console.ReadLine());
// // int max = Math.Max (a, Math.Max(b,c));
// // Console.WriteLine ($"Максимальное число: {max}");

// // Домашняя задача 6: Напишите программу, которая на вход принимает число и выдает, является ли 
// // число четным (делится ли оно на два без остатка)

// // Console.WriteLine("Введите число");
// // int number = Convert.ToInt32 (Console.ReadLine());

// // if (number % 2 == 0)
// // {
// //     Console.WriteLine("Число является четным");
// // }
// // else
// // {
// //     Console.WriteLine("Число не является четным");
// // }

// // Домашняя задача 8: Напишите программу, которая на вход принимает число (N), 
// // а на выходе показывает все четные числа от одного до N.

// // class Program
// // {
// //     static void Main()
// //     {
// //         Console.WriteLine("Введите число N:");
// //         int N = int.Parse(Console.ReadLine());

// //         Console.WriteLine("Четные числа от 1 до " + N + ":");

// //         for (int i = 1; i <= N; i++)
// //         {
// //             if (i % 2 == 0)
// //             {
// //                 Console.WriteLine(i);
// //             }
// //         }
// //     }
// // }

// // Новая лекция и семинар. Задача 1 найти максимальное из 9 при помощи стихийного подхода.

// // int a1 = 5;
// // int b1 = 21;
// // int c1 = 39;
// // int a2 = 12;
// // int b2 = 23;
// // int c2 = 33;
// // int a3 = 13;
// // int b3 = 23;
// // int c3 = 33;

// // int max = a1;
// // if(b1>max) max=b1;
// // if (c1>max) max=c1;

// // if(a2>max) max=a2;
// // if(b2>max) max=b2;
// // if (c2>max) max=c2;

// // if(a3>max) max=a3;
// // if(b3>max) max=b3;
// // if (c3>max) max=c3;

// // Console.WriteLine(max);

// // Новая лекция и семинар. Задача 1 найти максимальное из 9 при помощи функций. не работает

// // int Max(int arg1, int arg2, int arg3)
// // {
// //     int result = arg1;
// //     if (arg2 > result) result = arg2;
// //     if (arg3 > result) result = arg3;
// //     return result;
// // }

// // int a1 = 5;
// // int b1 = 21;
// // int c1 = 39;
// // int a2 = 12;
// // int b2 = 22223;
// // int c2 = 33;
// // int a3 = 13;
// // int b3 = 23;
// // int c3 = 33;

// // int max1 = Max(a1,b1,c1);
// // int max2 = Max(a2,b2,c2);
// // int max3 = Max(a3,b3,c3);
// // int max = Max(max1, max2, max3);

// // Console.WriteLine(max);

// // Console.WriteLine("Hello, World!");

// // Напишите программу, которая выводит случайное число из отрезка [от 1 до 99] 
// // и показывает наибольшую цыфру числа.

// // int num= new Random().Next(10,100);
// // Console.WriteLine(num);
// // int num1= num / 10;
// // int num2= num % 10;

// // if (num1>num2)
// // {
// //     Console.WriteLine(num1);
// // }
// // else if(num1==num2)
// // {
// //     Console.WriteLine(num1);
// // }
// // else
// // {
// //     Console.WriteLine(num2);
// // }

// // СЕМИНАР 2

// // Напишите программу, которая выводит случайное трехзанчное  число из отрезка [от 1 до 99] 
// // и удаляет среднее число.

// // int num= new Random().Next(100,1000);
// // Console.WriteLine(num);

// // int num1= num / 100;
// // int num2= num % 10;

// // Console.WriteLine($"{num1}{num2}");

// // Напишите программу будет принимать на вход два числа и выводить, 
// // является ли второе число кратным первому. Если число два не кратно 
// // числу один, то программа выводит остаток деления.

// // Console.WriteLine("Введите первое число:");
// // int num1=Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Ввидите второе число: ");
// // int num2=Convert.ToInt32(Console.ReadLine());

// // if(num1%num2==0)
// // {
// //     Console.WriteLine("Кратны");
// // }
// // else 
// // {
// //     Console.WriteLine($"Число не кратно {num1%num2}");
// // }

// // Напишите программу которая принимает 
// // на вход числои проверяет кратно оно одновремменно 7 и 23.

// // Console.WriteLine("Введите число:");
// // int num=Convert.ToInt32(Console.ReadLine());

// // if((num%7==0)&&(num%23==0))
// // {
// //     Console.WriteLine("DA");
// // }
// // else 
// // {
// //     Console.WriteLine("Net");
// // }

// // Напишите программу которая на вход принимает два числа,
// // и проверяет является ли одно число квадратом другого.

// // Console.WriteLine("Введите число:");
// // int number1=Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите второе число:");
// // int number2=Convert.ToInt32(Console.ReadLine());

// // if((number1==number2*number2)||(number2==number1*number1))
// // {
// //     Console.WriteLine("DA");
// // }
// // else 
// // {
// //     Console.WriteLine("Net");
// // }

// // Домашнее задание

// // Задача 10. Напишите прогрмамму которая принимает 
// // на вход трехзначное число и на выходе показывает вторую цыфру этого числа.

// // Console.WriteLine("Введите трехзначное число:");
// // int number=Convert.ToInt32(Console.ReadLine());
// // int secondDigit= ((number / 10) % 10);
// // Console.WriteLine("Вторая цыфра числа:" +secondDigit);

// // Задача 13. Напишите прогрмамму которая выводит третью цыфру 
// // заданного числа или сообщает что третьей цыфры нет.

// // Console.WriteLine("Введите число:");
// // int number=Convert.ToInt32(Console.ReadLine());
// // int thirdDigit=(number / 100) % 10; // Тут так не работает, ПОЧЕМУ???
// // if (thirdDigit !=0)
// // {
// //     Console.WriteLine("Третье число:" +thirdDigit);
// // }
// // else
// // {
// //     Console.WriteLine("Третьей цыфры нет:");
// // }

// // Задача 15 Напишите программу которая принимает на вход цыфру,
// //  заданного числа, или сообщает что третьей цыфры нет.

// // Console.WriteLine("Введите число:");
// // int number=Convert.ToInt32(Console.ReadLine());
// // int thirdDigit=(number /100) % 10; // И тут почему не раотает ???
// // if (thirdDigit !=0)
// // {
// //     Console.WriteLine("Третья цыфра числа: " +thirdDigit);
// // }
// // else
// // {
// //     Console.WriteLine("Третьей цыфры нет:");
// // }

// // Задача №17. Напишите программу, которая принимает 
// // на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// //  в которой находится эта точка.

// // Console.WriteLine("Введите X");
// // int X = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите Y");
// // int Y = Convert.ToInt32(Console.ReadLine());

// // if((X>0)&&(Y>0))  
// // {
// //     Console.WriteLine("1 Четверть");
// // }
// // else if(X<0 && Y>0)  
// // {
// //     Console.WriteLine("2 Четверть");
// // }
// // else if((X<0)&&(Y<0))  
// // {
// //     Console.WriteLine("3 Четверть");
// // }
// // else  
// // {
// //     Console.WriteLine("4 Четверть");
// // }

// // Напишите программу, которая по заданному номеру четверти, 
// // показывает диапазон возможных координат точек в этой четверти (x и y).

// // Console.WriteLine("Введите номер четверти");
// // int X = Convert.ToInt32(Console.ReadLine());

// // if(X==1)  
// // {
// //     Console.WriteLine("x>0,y>0");
// // }
// // else if(X==2)  
// // {
// //     Console.WriteLine("Во второй четверти Х<0, Y>0");
// // }
// // else if(X==3)  
// // {
// //     Console.WriteLine("В третьей четверти X<0, Y<0");
// // }
// // else if(X==4)  
// // {
// //     Console.WriteLine("В четвертой четверти X>0, Y<0");
// // }
// // else  
// // {
// //     Console.WriteLine("Нет");
// // }

// // Напишите программу, которая принимает на вход 
// // координаты двух точек и находит расстояние между 
// // ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09 
// // A (7,-5); B (1,-1) -> 7,21

// // Console.WriteLine("Введите координату");
// // int X1= Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите координату");
// // int Y1= Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите координату");
// // int X2= Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите координату");
// // int Y2= Convert.ToInt32(Console.ReadLine());

// // double result=Math.Sqrt((Math.Pow((X2-X1),2)) +  (Math.Pow((Y2-Y1),2)));

// // System.Console.WriteLine(result);

// // Напишите программу, которая принимает на вход 
// // координаты двух точек и находит расстояние между 
// // ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09 
// // A (7,-5); B (1,-1) -> 7,21

// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// // от 1 до N.

// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

// // Console.WriteLine("Введите координату");
// // int num= Convert.ToInt32(Console.ReadLine());

// // for(int i=1; i<=num; i++)
// // {
// //    Console.WriteLine(Math.Pow(i,2));
// // }

// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// // и находит расстояние между ними в 3D пространстве.
// // A(3,6,8); B (2,1,-7); -> 15.84
// // A(7,-5,0); B (1,-1,9); -> 11.53

// // Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
// // int x1 = Convert.ToInt32(Console.ReadLine());
// // int y1 = Convert.ToInt32(Console.ReadLine());
// // int z1 = Convert.ToInt32(Console.ReadLine());

// // Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
// // int x2 = Convert.ToInt32(Console.ReadLine());
// // int y2 = Convert.ToInt32(Console.ReadLine());
// // int z2 = Convert.ToInt32(Console.ReadLine());

// // double distance=Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

// // Console.WriteLine($"Расстояние между точками: {distance}");

// // Домашняя задача 19: Напишите программу, которая принимает на вход пятизначное число 
// // и проверяет, является ли число палиндромом.

// // using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         Console.WriteLine("Введите пятизначное число:");
// //         int number = Convert.ToInt32(Console.ReadLine());

// //         bool isPalindrome = CheckPalindrome(number);
// //         if (isPalindrome)
// //         {
// //             Console.WriteLine("Число является палиндромом.");
// //         }
// //         else
// //         {
// //             Console.WriteLine("Число не является палиндромом.");
// //         }
// //     }

// //     static bool CheckPalindrome(int number)
// //     {
// //         // Разбиваем число на отдельные цифры
// //         int digit1 = number / 10000;
// //         int digit2 = (number / 1000) % 10;
// //         int digit3 = (number / 100) % 10;
// //         int digit4 = (number / 10) % 10;
// //         int digit5 = number % 10;

// //         // Проверяем, является ли число палиндромом
// //         if (digit1 == digit5 && digit2 == digit4)
// //         {
// //             return true;
// //         }
// //         else
// //         {
// //             return false;
// //         }
// //     }
// // }

// // Домашняя задача 23: Напишите программу, которая принимает на вход число (N) 
// // и проверяет таблицу кубов чисел от 1 до (N).

// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         Console.WriteLine("Ввидите число N:");
// //         int number = Convert.ToInt32(Console.ReadLine());
// //         for (int i = 1; i <= number; i++)
// //         {
// //             Console.WriteLine($"Таблица кубов числа N:{Math.Pow(i, 3)}");
// //         }
// //     }
// // }

// // Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// // Задача 24: Напишите программу, которая принимает на 
// // вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// // тип возвращающего значения + Название +()+{ }

// // Задача 24: Напишите программу, которая принимает на 
// // вход число (А) и выдаёт сумму чисел от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// // тип возвращающего значения + Название +()+{ }

// // Console.WriteLine("Введите число");
// // int number = Convert.ToInt32(Console.ReadLine());

// // int GetSumNumber()
// // {
// // int sum=0;
// // int count=1;

// // while(number>=count)
// // {
// //     sum=sum + count;
// //     count=count+1;
// // }
// //     int sum =0;

// //     for (int i = 0; i <= number; i++)
// //     {    
// //         sum=sum + i;
// //     }

// //     return sum;
// // }

// // int result=GetSumNumber();
// // Console.WriteLine(result);

// // Задача 26: Напишите программу, которая принимает
// //  на вход число и выдаёт количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5

// // тип возвращающего значения + Название +()+{ }

// // Console.WriteLine("Введите число");
// // int number = Convert.ToInt32(Console.ReadLine());

// // int GetCountNumber()
// // {
// //     int count=0;

// //     while(number>0)
// //     {
// //         number= number/10;
// //         count=count+1;
// //     }

// //     return count;
// // }

// // Console.WriteLine(GetCountNumber());

// // Задача 28: Напишите программу, которая принимает 
// // на вход число N и выдаёт произведение чисел от 1 до N.
// // 4 -> 24 
// // 5 -> 120

// // тип возвращающего значения + Название +()+{ }

// // Console.WriteLine("Введите число");
// // int number = Convert.ToInt32(Console.ReadLine());

// // int GetCountNumber()
// // {
// //     int result=1;

// //     for (int i = 1; i <= number; i++)
// //     {
// //         result= result*i;
// //     }

// //     return result;
// // }

// // Console.WriteLine(GetCountNumber());

// // Задача 30: Напишите программу, которая выводит 
// // массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

// // тип возвращающего значения + Название +()+{ }
// // int arrayLength =8;

// // int[] array= new int[arrayLength];

// // GetRandomArray();

// // void GetRandomArray()
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         array[i]= new Random().Next(0,2);
// //         Console.Write(array[i]+" ");
// //     }
// // }

// // Домашняя задача 29: Напишите программу которая задает массив из 8 элементов, и выводит их на экран

// // int arrayLength =8;
// // int[] array= new int[arrayLength];
// // Console.Write("Массив из случайных цифр: ");
// // for (int i = 0; i < arrayLength; i++)
// // {
// //     array[i] = new Random().Next(0,arrayLength);
// //     Console.Write(array[i]+" ");
// // }
// // System.Console.WriteLine();
// // System.Console.WriteLine();

// //Домашнее задание 27: Напишите прогрмамму которая принимает на вход число, и выдает сумму цыфр в числе.

// // Console.Write("Введите любое число: ");
// // int number = Convert.ToInt32(Console.ReadLine());

// // int sum = GetSumOfDigits(number);
// // Console.WriteLine("Сумма цифр в числе: " + sum);

// // int GetSumOfDigits(int number)
// // {
// // int sum = 0;
// // while (number != 0)
// // {
// //     int digit = number % 10;
// //     sum += digit;
// //     number /= 10;
// // }
// // return sum;
// // }

// // Домашняя задача 25: Напишите цыкл который принимает на вход два числа (А,Б) 
// // и возводит число A в натуральную степень B.

// // Console.Write("Ввидите число a: ");
// // int a = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Ввидите число b: ");
// // int b = Convert.ToInt32(Console.ReadLine());

// // int result = 1;
// // for (int i = 0; i < b; i++)
// // {
// //     result *= a;
// // }

// // Console.Write("Результат: " + result);
// // System.Console.WriteLine();

// // второй способ намного лучше!!!!
// // Console.Write("Ввидите число a: ");
// // int a = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Ввидите число b: ");
// // int b = Convert.ToInt32(Console.ReadLine());

// // double result=Math.Pow(a,b); 

// // Console.Write("Результат: " + result);
// // System.Console.WriteLine();

// // Задача 31: Задайте массив из 12 элементов, заполненный 
// // случайными числами из промежутка [-9, 9]. Найдите сумму 
// // отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// // положительных чисел равна 29, сумма отрицательных равна -20.

// // int arrayLength= 12;

// // int[] array = new int[arrayLength];

// // int positiveNumber=0;
// // int negNumber=0;

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i]= new Random().Next(-9, 10);
// //     Console.Write(array[i]+" ");

// //     if (array[i]>0)
// //     {
// //         // positiveNumber=positiveNumber+array[i];
// //         positiveNumber+=array[i];
// //     }
// //     else
// //     {
// //         negNumber+=array[i];

// //     }
// // }
// // Console.WriteLine();
// // Console.WriteLine($"Сумма положительных: {positiveNumber} и отрицательных: {negNumber}");

// // Задача 32: Напишите программу замена элементов массива:
// //  положительные элементы замените на соответствующие 
// //  отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// // int arrayLength= 4;

// // int[] array = new int[arrayLength];

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i]= new Random().Next(-9, 10);
// //     Console.Write(array[i]+" ");

// // }

// // Console.WriteLine();

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i]= array[i]* -1;
// //     Console.Write(array[i]+" ");
// // }

// // Задача 33: Задайте массив. Напишите программу, 
// // которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да

// // Console.WriteLine("Введите число");
// // int num = Convert.ToInt32(Console.ReadLine());

// // int arrayLength= 4;
// // bool isFind=false;

// // int[] array = new int[arrayLength];

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i]= new Random().Next(-9, 10);
// //     Console.Write(array[i]+" ");

// //     if(num==array[i])
// //     {
// //         isFind=true;
// //     }
// // }

// // if (isFind==true)
// // {
// //     System.Console.WriteLine( "Да");
// // }
// // else
// // {
// //     System.Console.WriteLine( "Нет");
// // }

// // Задача 35: Задайте одномерный массив из 123 случайных чисел.
// //  Найдите количество элементов массива, значения которых 
// //  лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём
// //  решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// // int arrayLength= 123;
// // int countNumber=0;

// // int[] array = new int[arrayLength];

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i]= new Random().Next(123);
// //     Console.Write(array[i]+" ");

// //     if((array[i]>9)&&(array[i]<100))
// //     {
// //         countNumber++;
// //     }
// // }

// // System.Console.WriteLine("Кол. = "+ countNumber);

// // Задача 37: Найдите произведение пар чисел в одномерном
// //  массиве. Парой считаем первый и последний элемент,
// //   второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3   
// // [6 7 3 6] -> 36 21 

// // int arrayLength= 5;

// // int[] array = new int[arrayLength];
// // int [] array2 = new int[array.Length/2+array.Length % 2];

// // for (int i = 0; i < array.Length; i++)
// // {
// //     array[i]= new Random().Next(10);
// //     Console.Write(array[i]+" ");
// // }
// // Console.WriteLine();

// // for (int i = 0; i < array2.Length; i++)
// // {
// //     array2[i]= array[i]*array[arrayLength-1-i];

// //     if (i==arrayLength-1-i)
// //     {
// //         array2[i]=array[i];
// //     }
// //     Console.Write(array2[i]+" ");
// // }
// // Console.WriteLine();

// // Домашнее задание 34: Задайте массив заполненный случайными положительными трехзначными числами.
// // Напишите программу, которая покажет количество четных чисел в массиве.
// // пример решения 
// // [345, 897, 568, 234] -> 2

// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         int arrayLangth = 5;
// //         int[] array = new int[arrayLangth];
// //         for (int i = 0; i < arrayLangth; i++)
// //         {
// //             array[i] = new Random().Next(100, 1000);
// //             Console.Write(array[i]+", ");
// //             // (string.Join(", ", arr));
// //         }
// //         int count = 0;
// //         foreach (int num in array)
// //         {
// //             if (count % 2 == 0)
// //             {
// //                 count++;
// //             }
// //         }
// //         Console.Write($"Количество четных чисел в массиве: {count}");
// //         Console.WriteLine();
// //     }
// // }


// // Идеаотное решение

// // using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         // создаем массив из 10 случайных трехзначных чисел
// //         int[] arr = new int[5];
// //         Random rand = new Random();
// //         for (int i = 0; i < arr.Length; i++)
// //         {
// //             arr[i] = rand.Next(100, 1000);
// //         }
// //         Console.WriteLine(string.Join(", ", arr));

// //         // считаем количество четных чисел в массиве
// //         int count = 0;
// //         foreach (int num in arr)
// //         {
// //             if (num % 2 == 0)
// //             {
// //                 count++;
// //             }
// //         }

// //         Console.WriteLine($"Количество четных чисел в массиве: {count}");
// //     }
// // }

// // Домашняя задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6]-> 0

// // Идеальное решение:
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // создаем массив из 4 случайных чисел
//         int[] arr = new int[4];
//         Random rand = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rand.Next(-10, 10);
//         }
//         Console.WriteLine(string.Join(", ", arr));

//         // считаем сумму элементов на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2)
//         {
//             sum += arr[i];
//         }

//         Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
//     }
// }

// // Домашняя задача 38: Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // создаем массив из 5 вещественных чисел
//         double[] arr = { 3.22, 4.2, 1.15, 77.15, 65.2 };
//         Console.WriteLine(string.Join(", ", arr));

//         // ищем минимальный и максимальный элементы
//         double min = arr[0];
//         double max = arr[0];
//         for (int i = 1; i < arr.Length; i++)
//         {
//             if (arr[i] < min)
//             {
//                 min = arr[i];
//             }
//             if (arr[i] > max)
//             {
//                 max = arr[i];
//             }
//         }

//         // выводим разницу между ними
//         double diff = max - min;
//         Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
//     }
// }

// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3= Convert.ToInt32(Console.ReadLine());

// if((num1<num2+num3)&&(num2<num1+num3)&&(num3<num1+num2))
// {
//     Console.WriteLine("Существует");
// }
// else
// {
//     Console.WriteLine("Такого треугольника не может быть");
// }

// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// string result= "";

// while(num>0)
// {
//     result= num%2+result;
//     num= num/2;

// }

// System.Console.WriteLine(result);

// Задача 44: Не используя рекурсию, выведите первые N
//  чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// int firstNum=0;
// int secondNum=1;

// System.Console.Write(firstNum+ " "+ secondNum+" ");

// for (int i = 2; i < num; i++)
// {
//     int newNum= firstNum+secondNum;
//     System.Console.Write(newNum+" ");
//     firstNum=secondNum;
//     secondNum=newNum;
// }

// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом
//   месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int [] array = new int[] {1,2,3,4,5};

// for (int i = 0; i < array.Length/2; i++)
// {
//     int temp = array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i]+" ");
// }

// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера m на n,
//  каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//   Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i+j;
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i+j;
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("________");

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         if(i%2==0 && j%2==0)
//         {
//             // Console.Write(matrix[i,j]*matrix[i,j] + " ");
//             matrix[i,j]= Convert.ToInt32(Math.Pow(matrix[i,j],2));
//         }
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int sum=0;
// int [,] matrix= new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
        
//         matrix[i,j] = i+j;
//         if(i==j)
//         {
//             sum= sum+matrix[i,j];
//         }
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// System.Console.WriteLine("Сумма равна "+ sum);


// // Домашнее задание 34: Задайте массив заполненный случайными положительными трехзначными числами.
// // Напишите программу, которая покажет количество четных чисел в массиве.
// // пример решения 
// // [345, 897, 568, 234] -> 2

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int arrayLangth = 5;
//         int[] array = new int[arrayLangth];
//         for (int i = 0; i < arrayLangth; i++)
//         {
//             array[i] = new Random().Next(100, 1000);
//             Console.Write(array[i]+", ");
//             // (string.Join(", ", arr));
//         }
//         int count = 0;
//         foreach (int num in array)
//         {
//             if (count % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         Console.Write($"Количество четных чисел в массиве: {count}");
//         Console.WriteLine();
//     }
// }


// // Идеаотное решение

// // using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         // создаем массив из 10 случайных трехзначных чисел
// //         int[] arr = new int[5];
// //         Random rand = new Random();
// //         for (int i = 0; i < arr.Length; i++)
// //         {
// //             arr[i] = rand.Next(100, 1000);
// //         }
// //         Console.WriteLine(string.Join(", ", arr));

// //         // считаем количество четных чисел в массиве
// //         int count = 0;
// //         foreach (int num in arr)
// //         {
// //             if (num % 2 == 0)
// //             {
// //                 count++;
// //             }
// //         }

// //         Console.WriteLine($"Количество четных чисел в массиве: {count}");
// //     }
// // }

// // Домашняя задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6]-> 0

// // Идеальное решение:
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // создаем массив из 4 случайных чисел
//         int[] arr = new int[4];
//         Random rand = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rand.Next(-10, 10);
//         }
//         Console.WriteLine(string.Join(", ", arr));

//         // считаем сумму элементов на нечетных позициях
//         int sum = 0;
//         for (int i = 1; i < arr.Length; i += 2)
//         {
//             sum += arr[i];
//         }

//         Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
//     }
// }

// // Домашняя задача 38: Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // создаем массив из 5 вещественных чисел
//         double[] arr = { 3.22, 4.2, 1.15, 77.15, 65.2 };
//         Console.WriteLine(string.Join(", ", arr));

//         // ищем минимальный и максимальный элементы
//         double min = arr[0];
//         double max = arr[0];
//         for (int i = 1; i < arr.Length; i++)
//         {
//             if (arr[i] < min)
//             {
//                 min = arr[i];
//             }
//             if (arr[i] > max)
//             {
//                 max = arr[i];
//             }
//         }

//         // выводим разницу между ними
//         double diff = max - min;
//         Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
//     }
// }

// Домашняя задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите количество чисел: ");
//         int m = int.Parse(Console.ReadLine());

//         int count = 0; // счетчик чисел больше 0
//         for (int i = 0; i < m; i++)
//         {
//             Console.Write($"Введите число {i + 1}: ");
//             int num = int.Parse(Console.ReadLine());
//             if (num > 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество чисел больше 0: {count}");
//     }
// }

// Домашняя задача 43:Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение b1: ");
//         double b1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите значение k1: ");
//         double k1 = double.Parse(Console.ReadLine());

//         Console.Write("Введите значение b2: ");
//         double b2 = double.Parse(Console.ReadLine());

//         Console.Write("Введите значение k2: ");
//         double k2 = double.Parse(Console.ReadLine());

//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;

//         Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
//     }
// }

// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,10);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строчек");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// Console.WriteLine("Введите количество колонок");
// int columns = Convert.ToInt32(System.Console.ReadLine());

// int [,] matrix = new int [rows, columns];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     int temp=0;
//     int indexLastRows= matrix.GetLength(0)-1;

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         temp = matrix[0,i];
//         matrix[0,i]= matrix[indexLastRows,i];
//         matrix[indexLastRows,i]= temp;
//     }
// }

// GetArray();
// PrintArray();
// ChangeArray();
// System.Console.WriteLine("_________");
// PrintArray();

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если
//  это невозможно, программа должна вывести сообщение для пользователя.


// Console.WriteLine("Введите количество строчек");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// Console.WriteLine("Введите количество колонок");
// int columns = Convert.ToInt32(System.Console.ReadLine());

// int [,] matrix = new int [rows, columns];
// int [,] matrix1 = new int [rows, columns];

// void GetArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     if(rows== columns)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrix1[j,i]=matrix[i,j];
//             }
//         }
//     }
    
// }

// GetArray();
// PrintArray(matrix);
// ChangeArray();
// System.Console.WriteLine("_________");
//  if(rows== columns)
//     {
//         PrintArray(matrix1);
//     }
// else
// {
//     Console.WriteLine("Массив не подходит");
// }

// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец,
//   на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Console.WriteLine("Введите количество строчек");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// Console.WriteLine("Введите количество колонок");
// int columns = Convert.ToInt32(System.Console.ReadLine());

// int [,] matrix = new int [rows, columns];

// int minValue= int.MaxValue;
// int minIndexRows=0;
// int minIndexColumns=0;

// void GetArray()
// {
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //          for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             matrix[i,j]= new Random().Next(0,10);

// //             if(minValue> matrix[i,j])
// //             {
// //                 minValue=matrix[i,j];
// //                 minIndexRows=i;
// //                 minIndexColumns=j;
// //             }
// //         }
// //     }
// // }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if(i!=minIndexRows)
//         {
//              for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j!=minIndexColumns)
//                 {
//                     Console.Write(matrix[i,j]+ " ");
//                 }
                
//             }
//             System.Console.WriteLine();
//         }
        
//     }
//     System.Console.WriteLine(minIndexColumns);
//     System.Console.WriteLine(minIndexRows);
// }

// GetArray();
// PrintArray();
// System.Console.WriteLine("_________");
// ChangeArray();



