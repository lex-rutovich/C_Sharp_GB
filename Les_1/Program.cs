/* See https://aka.ms/new-console-template for more information
Console.WriteLine("2 Hello, World!");
*/

// Console.WriteLine("Введите ваше имя ");
// string username = Console.ReadLine();
// Console.WriteLine("Привет, ");
// Console.WriteLine(username);

// Console.Write("Введите ваше имя ");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);

// Написать программу на языке C# для Windows и Mac OS,
// [в которую пользователь вводит два числа]
// [в которой записаны два числа]
// [два числа генерируются случайным образом]
// и получает сумму

// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);

// или:

// int numberA = 31;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// int numberA = 12;
// int numberB = 5;
// Console.WriteLine(numberA / numberB);

// double numberA = 12;
// double numberB = 5;
// Console.WriteLine(numberA / numberB);

// int numberA = new Random().Next(1, 10); //1 2 3 4 ... 9
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);

// Начало
// Ввести имя пользователя
// ЕСЛИ имя пользователя совпадает с "Маша" то...
// поприветствовать по особенному
// ИНАЧЕ поприветствовать по обычному
// Конец

// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();
// 
// if(username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }

// Example006:
// 
// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e =4;
// 
// int max = a;
// 
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;
// 
// Console.Write("max = ");
// Console.WriteLine(max);

/*
Синтаксис:начало

Алгоритм:
1.Определить три точки
2.Выбрать две любых
3.Найти середину
4.Поставить точку
5.Выбрать случайную вершину треугольника
6.Соединить её с полученной на 4 шаге точкой
7.Перейти к шагу 3
8.Шаги 3 - 7 повторить 9,28,31 раз
clear
Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("+");
*/

int xa = 30, ya = 1, 
    xb = 1, yb = 30,
    xc = 60, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
    
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 10000);
{
    int what = new Random().Next(0, 3);   // [0;3) -полуинтервал, могут выдоваться числа 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // Можно использовать такую запись: count ++;
}

// фрактальное изображение Треугольник Серпинского



