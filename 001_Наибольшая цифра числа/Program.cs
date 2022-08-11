﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randomNumber = GetRandomNumber(10,99);
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 10;
int lastDigit = randomNumber % 10;

int maxDigit = Max(firstDigit, lastDigit);

Console.WriteLine(maxDigit);

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int Max(int a, int b)
{
    int max = 0;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    return max;
}