// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите число");
if(number == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if(number == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if(number == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if(number == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else{
    Console.WriteLine("Ошибка ввода");
}