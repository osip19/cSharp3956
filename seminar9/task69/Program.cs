﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int myNumberA = 3;
int myNumberB = 5;
Console.WriteLine(A(myNumberA, myNumberB));

int PowAToB(int a, int b)
{
    if(b == 0) return 1;
    return a * PowAToB(a, b - 1);
}

int A (int m, int n)