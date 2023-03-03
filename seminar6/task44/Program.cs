const int N = 8;


int[] Fibonacci = new int[N];

Fibonacci[0] = 0;
Fibonacci[1] = 1;

for(int i = 2; i < Fibonacci.Length; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
}

Console.WriteLine(string.Join(", ", Fibonacci));