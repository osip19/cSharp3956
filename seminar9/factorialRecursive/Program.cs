//Вычислить факториал введенного числа N
// 4 -> 24
// 5 -> 120



int number = -5;

int Factorial(int n)
{
    if (n < 0) throw new Exception($"Невозможно высчитать факториал числа {n}");
    if (n == 0 || n == 1) return 1;
    return n * Factorial(n - 1);
}


Console.WriteLine(Factorial(number));
