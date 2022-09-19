int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//  0   1    2   3   4   6   6   7   8
int[] array = { 11, 521, 33, 44, 55, 66, 77, 88, 99 };

int result = Max(
    Max(array[0], array[1], array[3]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(result);
