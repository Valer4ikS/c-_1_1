int[] array = { 21, 42, 21, 15, 21, 55, 22, 54 };


int n = array.Length;
int find = 21;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}