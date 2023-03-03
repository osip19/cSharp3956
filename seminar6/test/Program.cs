int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

const int LENGTH = 6;
const int LEFTBORDER = -10;
const int RIGHTBORDER = 10;

int[] myArray1 = GetRandomArray(LENGTH, LEFTBORDER, RIGHTBORDER);
//int[] myArray2 = myArray1; 


int[] myArray2 = new int[myArray1.Length];

// for(int i = 0; i < myArray2.Length; i++)
// {
//     myArray2[i] = myArray1[i];
// }

Array.Copy(myArray1, myArray2, 3);
Console.WriteLine(string.Join(", ", myArray1));
Console.WriteLine(string.Join(", ", myArray2));




