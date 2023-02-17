int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadNumber("Введите число");
for(int i = 1; i < N; i++)
{
    Console.Write(i * i + ", ");
}
Console.WriteLine(N * N + ".");