int n = 5;
int m = 2;
PrintMToN(m, n);

void PrintMToN(int start, int end)
{
    if (end < start) return;
    PrintMToN(start, end - 1);
    Console.Write($"{end} ");
}