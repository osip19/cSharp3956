//Задача 32: Напишите программу замена элементов 
//массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

void InvertElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}


int lengthOfArray = 12;
int leftBorder = -9;
int rightBorder = 9;

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
InvertElements(myArray);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
