// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Console.WriteLine("Введите число"); 
// string userAnswer = Console.ReadLine();
// int userNumber = Convert.ToInt32(userAnswer);
// Console.WriteLine(userNumber * userNumber);

Console.WriteLine("Введите число");
string? answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int res = number * number;
Console.WriteLine(res);

if (res > 100);
{
    Console.WriteLine("Да");
}
